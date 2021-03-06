﻿namespace MedicalCard.BLL.Repositories
{
	using System.Data.Entity;
	using Entities;

	public class AccountRepository : BaseRepository<Account, int>
	{
		public AccountRepository(MedicalCardDbContext dbContext)
			: base(dbContext)
		{
		}

		protected override DbSet<Account> GetDbSet(MedicalCardDbContext dbContext)
		{
			return dbContext.Accounts;
		}
	}
}