namespace System
{
	using Data.Entity;
	using MedicalCard.Entities.Exceptions;

	public static class DbSetExtensions
	{
		public static T FindOrThrow<T>(this DbSet<T> dbSet, params object[] key) where T : class
		{
			var item = dbSet.Find(key);
			if (item == null)
			{
				throw new EntityNotFoundException();
			}

			return item;
		}
	}
}