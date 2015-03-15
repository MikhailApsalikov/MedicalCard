namespace MedicalCard.BLL
{
	using System;
	using System.Data.Entity;
	using System.Linq;
	using System.Linq.Expressions;
	using System.Threading;
	using Common;
	using Repositories;

	public abstract class BaseRepository<T, TKey> : IRepository<T, TKey> where T : class
	{
		#region [.ctor]

		protected BaseRepository(MedicalCardDbContext dbContext)
		{
			ArgumentGuard.ThrowOnNull(dbContext, "dbContext");
			this.dbContext = dbContext;
		}

		#endregion

		#region [IDisposable implementation]

		public void Dispose()
		{
			Dispose(true);
		}

		#endregion

		public void SaveChanges()
		{
			dbContext.SaveChanges();
		}

		protected abstract DbSet<T> GetDbSet(MedicalCardDbContext dbContext);

		protected virtual void OnAdding(T item)
		{
		}

		protected virtual void OnAdded(T item)
		{
		}

		protected virtual void OnUpdateing(T item)
		{
		}

		protected virtual void OnUpdated(T item)
		{
		}

		protected virtual void OnRemoving(T item)
		{
		}

		protected virtual void OnRemoved(T item)
		{
		}

		protected virtual void Dispose(bool disposing)
		{
			dbContext.Dispose();
		}

		protected virtual IQueryable<T> ApplyIncludedPathes(IQueryable<T> source)
		{
			var includedPathes = _includedPathes;
			if (includedPathes != null
			    && Interlocked.CompareExchange(ref includedPathes.Item1, 1, 0) == 0)
			{
				foreach (var path in includedPathes.Item2)
				{
					source = source.Include(path);
				}
			}
			return source;
		}

		#region [Fields]

		protected readonly MedicalCardDbContext dbContext;

		private volatile Holder<int, string[]> _includedPathes;

		#endregion

		#region [Properties]

		private DbSet<T> DbSet
		{
			get { return GetDbSet(dbContext); }
		}

		private IQueryable<T> DataSet
		{
			get
			{
				IQueryable<T> result = DbSet;
				return ApplyIncludedPathes(result);
			}
		}

		#endregion

		#region [IRepository implementation]

		public IQueryable<T> GetAll()
		{
			return DataSet;
		}

		public IQueryable<T> GetRange<TValue>(Expression<Func<T, TValue>> keySelector, int offset, int count)
		{
			ArgumentGuard.ThrowOnNull(keySelector, "keySelector");
			ArgumentGuard.ThrowOnOutOfRange(offset, "offset", x => x >= 0);
			ArgumentGuard.ThrowOnOutOfRange(count, "count", x => x > 0);

			return DataSet.OrderBy(keySelector).Skip(offset).Take(count);
		}

		public IQueryable<T> Filter(Expression<Func<T, bool>> filter)
		{
			ArgumentGuard.ThrowOnNull(filter, "filter");

			return DataSet.Where(filter);
		}

		public IQueryable<T> Filter<TValue>(Expression<Func<T, bool>> filter, Expression<Func<T, TValue>> keySelector,
			int offset, int count)
		{
			ArgumentGuard.ThrowOnNull(filter, "filter");
			ArgumentGuard.ThrowOnNull(keySelector, "keySelector");
			ArgumentGuard.ThrowOnOutOfRange(offset, "offset", x => x >= 0);
			ArgumentGuard.ThrowOnOutOfRange(count, "count", x => x > 0);

			return DataSet.Where(filter).OrderBy(keySelector).Skip(offset).Take(count);
		}

		public T FilterSingle(Expression<Func<T, bool>> filter)
		{
			ArgumentGuard.ThrowOnNull(filter, "filter");

			return DataSet.SingleOrDefault(filter);
		}

		public T FilterFirst(Expression<Func<T, bool>> filter)
		{
			ArgumentGuard.ThrowOnNull(filter, "filter");

			return DataSet.FirstOrDefault(filter);
		}

		public T GetById(TKey key)
		{
			var item = DbSet.FindOrThrow(key);
			return item;
		}

		public T Add(T item)
		{
			ArgumentGuard.ThrowOnNull(item, "item");
			OnAdding(item);
			item = DbSet.Add(item);
			SaveChanges();
			OnAdded(item);
			return item;
		}

		public T Update(T item)
		{
			ArgumentGuard.ThrowOnNull(item, "item");

			OnUpdateing(item);

			dbContext.Update(item);
			SaveChanges();

			OnUpdated(item);

			return item;
		}

		public void Remove(T item)
		{
			ArgumentGuard.ThrowOnNull(item, "item");

			OnRemoving(item);

			DbSet.Remove(item);
			SaveChanges();

			OnRemoved(item);
		}

		public void RemoveById(TKey key)
		{
			Remove(GetById(key));
		}

		public void SetIncludedPathes(params string[] pathes)
		{
			_includedPathes = new Holder<int, string[]>(0, pathes != null ? pathes.ToArray() : null);
		}

		#endregion
	}
}