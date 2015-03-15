using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web;
using MedicalCard.Common;
using MedicalCard.Models;
using MedicalCard.Models.Filters;

namespace MedicalCard.Helpers
{
	internal static class Pagination
	{
		static Pagination()
		{
			var methods = typeof(Queryable).GetMethods(BindingFlags.Public | BindingFlags.Static);
			OrderByMethodInfo = methods.First(m => m.Name.Equals("OrderBy")
												   && m.GetParameters().Length == 2);
			OrderByDescendingMethodInfo = methods.First(m => m.Name.Equals("OrderByDescending")
															 && m.GetParameters().Length == 2);
		}

		internal static EntitiesListContainer<TResult> Get<TSource, TResult>(IQueryable<TSource> source, int page, int pageSize, Func<TSource, TResult> translator, string orderBy = null, ListSortDirection? sortDirection = null)
		{
			ArgumentGuard.ThrowOnNull(source, "source");
			ArgumentGuard.ThrowOnOutOfRange(page, "page", x => x >= BaseFilterQuery.DefaultPage);
			ArgumentGuard.ThrowOnOutOfRange(pageSize, "pageSize", x => x > 0);
			ArgumentGuard.ThrowOnNull(translator, "translator");

			IEnumerable<TSource> items;
			var totalCount = GetPartition(source, page, pageSize, orderBy, sortDirection, out items);

			return new EntitiesListContainer<TResult>
			{
				Items = items.Select(x => translator(x)).ToList(),
				Page = page,
				PageSize = pageSize,
				TotalItems = totalCount
			};
		}

		internal static EntitiesListContainer<T> Get<T>(IQueryable<T> source, int page, int pageSize, string orderBy = null, ListSortDirection? sortDirection = null)
		{
			ArgumentGuard.ThrowOnNull(source, "source");
			ArgumentGuard.ThrowOnOutOfRange(page, "page", x => x >= BaseFilterQuery.DefaultPage);
			ArgumentGuard.ThrowOnOutOfRange(pageSize, "pageSize", x => x > 0);

			IEnumerable<T> items;
			var totalCount = GetPartition(source, page, pageSize, orderBy, sortDirection, out items);

			return new EntitiesListContainer<T>
			{
				Items = items,
				Page = page,
				PageSize = pageSize,
				TotalItems = totalCount
			};
		}



		private static int GetPartition<TSource>(IQueryable<TSource> source, int page, int pageSize, string orderBy, ListSortDirection? sortDirection, out IEnumerable<TSource> items)
		{
			var totalCount = source.Count();
			page -= TextFilterQuery.DefaultPage;

			var shouldPagginate = page > 0;
			// apply sort options
			if (!String.IsNullOrEmpty(orderBy) || shouldPagginate)
			{
				var mapping = String.IsNullOrEmpty(orderBy)
					? null
					: CamelCasePropertyNamesConverter.FromCamelCase(orderBy);

				orderBy = String.IsNullOrEmpty(mapping)
					? MappingHelper.GetDefaultMapping<TSource>()
					: (MappingHelper.GetMapping<TSource>(mapping) ?? mapping);

				var keySelector = GetProperty(source, orderBy);
				var method = sortDirection != ListSortDirection.Descending
								? OrderByMethodInfo
								: OrderByDescendingMethodInfo;
				source = source.Provider.CreateQuery<TSource>(
					Expression.Call(null, method.MakeGenericMethod(new Type[]
	                    {
		                    typeof(TSource),
		                    keySelector.ReturnType
	                    }), new Expression[]
	                    {
		                    source.Expression,
		                    Expression.Quote(keySelector)
	                    }));
			}
			// navigate to necessary page
			if (page > 0)
			{
				source = source.Skip(page * pageSize);
			}
			// take page items
			items = source.Take(pageSize).ToList();

			return totalCount;
		}

		private static LambdaExpression GetProperty<T>(IEnumerable<T> source, string orderBy)
		{
			var typeToAccess = typeof(T);
			var key = new SortKey(typeToAccess, orderBy);

			LambdaExpression cachedResult;
			if (!_propertyAccessorCache.TryGetValue(key, out cachedResult))
			{
				var pathes = orderBy.Split(PropertiesSeparator);

				var entityParameter = Expression.Parameter(typeToAccess, "inst");
				Expression orderByProperty = null;
				foreach (var path in pathes)
				{
					orderByProperty = Expression.Property(
						orderByProperty ?? entityParameter,
						orderByProperty != null ? orderByProperty.Type : typeToAccess,
						path);
				}

				var type = typeof(Func<,>).MakeGenericType(typeof(T), orderByProperty.Type);
				cachedResult = Expression.Lambda(type, orderByProperty, entityParameter);
				_propertyAccessorCache[key] = cachedResult;
			}

			return cachedResult;
		}


		private static readonly MethodInfo OrderByMethodInfo;
		private static readonly MethodInfo OrderByDescendingMethodInfo;
		private static readonly char[] PropertiesSeparator = new char[] { '.' };
		private static readonly IDictionary<SortKey, LambdaExpression> _propertyAccessorCache = new ConcurrentDictionary<SortKey, LambdaExpression>();


		private sealed class SortKey
		{
			private readonly Type _type;
			private readonly string _property;

			private readonly int _hashCode;

			internal SortKey(Type type, string property)
			{
				_type = type;
				_property = property;

				_hashCode = CalculateHashCode(type, property);
			}

			public override int GetHashCode()
			{
				return _hashCode;
			}

			public override bool Equals(object obj)
			{
				if (ReferenceEquals(this, obj))
					return true;

				if (ReferenceEquals(null, obj) || obj.GetType() != typeof(SortKey))
					return false;

				return Equals((SortKey)obj);
			}

			public bool Equals(SortKey other)
			{
				if (ReferenceEquals(this, other))
					return true;

				if (ReferenceEquals(null, other))
					return false;

				return Equals(_type, other._type)
						&& String.Equals(_property, other._property, StringComparison.Ordinal);
			}

			private static int CalculateHashCode(Type type, string property)
			{
				unchecked
				{
					var result = type.GetHashCode();
					if (!String.IsNullOrEmpty(property))
					{
						result = result * 397 + property.GetHashCode();
					}
					return result;
				}
			}
		}
	}
}