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

		protected override void OnAdding(Account item)
		{
			if (item.Role == Role.Patient)
			{
				item.Patient = new Patient();
			}

			if (item.Role == Role.Doctor)
			{
				item.Doctor = new Doctor();
			}
		}
	}
}