using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using MedicalCard.Common;

namespace MedicalCard.Helpers
{
	internal static class MappingHelper
	{
		private static readonly ConcurrentDictionary<Type, Tuple<ReaderWriterLockSlim, IDictionary<string, string>>> Register
			= new ConcurrentDictionary<Type, Tuple<ReaderWriterLockSlim, IDictionary<string, string>>>();

		private static readonly Func<Type, Tuple<ReaderWriterLockSlim, IDictionary<string, string>>> CreateNewEntry =
			type =>
				new Tuple<ReaderWriterLockSlim, IDictionary<string, string>>(new ReaderWriterLockSlim(),
					new Dictionary<string, string>());

		private static readonly string DefaultMappingKey = String.Empty;

		internal static void RegisterMapping<T>(string from, string to)
		{
			ArgumentGuard.ThrowOnStringIsNullOrEmpty(from, "from");
			ArgumentGuard.ThrowOnStringIsNullOrEmpty(to, "to");

			var item = Register.GetOrAdd(typeof (T), CreateNewEntry);
			try
			{
				item.Item1.EnterWriteLock();
				item.Item2[from] = to;
			}
			finally
			{
				item.Item1.ExitWriteLock();
			}
		}

		internal static void RegisterDefaultMapping<T>(string to)
		{
			ArgumentGuard.ThrowOnStringIsNullOrEmpty(to, "to");

			var item = Register.GetOrAdd(typeof (T), CreateNewEntry);
			try
			{
				item.Item1.EnterWriteLock();
				item.Item2[DefaultMappingKey] = to;
			}
			finally
			{
				item.Item1.ExitWriteLock();
			}
		}

		internal static void UnregisterMapping<T>(string from)
		{
			ArgumentGuard.ThrowOnStringIsNullOrEmpty(from, "from");

			var item = Register.GetOrAdd(typeof (T), CreateNewEntry);
			try
			{
				item.Item1.EnterWriteLock();
				item.Item2.Remove(from);
			}
			finally
			{
				item.Item1.ExitWriteLock();
			}
		}

		internal static void UnregisterDefaultMapping<T>()
		{
			var item = Register.GetOrAdd(typeof (T), CreateNewEntry);
			try
			{
				item.Item1.EnterWriteLock();
				item.Item2.Remove(DefaultMappingKey);
			}
			finally
			{
				item.Item1.ExitWriteLock();
			}
		}

		internal static string GetMapping<T>(string from)
		{
			ArgumentGuard.ThrowOnStringIsNullOrEmpty(from, "from");

			return GetMappingImpl<T>(from);
		}

		internal static string GetDefaultMapping<T>()
		{
			return GetMappingImpl<T>(DefaultMappingKey);
		}

		private static string GetMappingImpl<T>(string from)
		{
			Tuple<ReaderWriterLockSlim, IDictionary<string, string>> item;
			if (!Register.TryGetValue(typeof (T), out item))
				return null;

			try
			{
				item.Item1.EnterReadLock();
				string to;
				return item.Item2.TryGetValue(from, out to) ? to : null;
			}
			finally
			{
				item.Item1.ExitReadLock();
			}
		}

		internal static void UnregisterAllTypeMappings<T>()
		{
			var item = Register.GetOrAdd(typeof (T), CreateNewEntry);
			try
			{
				item.Item1.EnterWriteLock();
				item.Item2.Clear();
			}
			finally
			{
				item.Item1.ExitWriteLock();
			}
		}

		internal static void UnregisterAllMappings()
		{
			Register.Clear();
		}
	}
}