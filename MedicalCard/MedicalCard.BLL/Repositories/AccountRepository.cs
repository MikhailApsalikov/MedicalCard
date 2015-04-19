namespace MedicalCard.BLL.Repositories
{
	using System.Data.Entity;
	using Entities;
	using Entities.Enums;

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