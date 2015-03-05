namespace MedicalCard.BLL
{
	using System.Collections.Generic;
	using System.Data.Entity;
	using System.Linq;
	using System.Threading.Tasks;
	using MedicalCard.Entities;

	public class AccountLogic
	{
		public List<Account> GetAccounts()
		{
			using (var db = new MedicalCardDbContext())
			{
				return db.Accounts.ToList();
			}
		}

		public async Task<Account> GetAccount(int id)
		{
			return await new MedicalCardDbContext().Accounts.FindAsync(id);
		}

		public async Task PutAccount(int id, Account account)
		{
			var db = new MedicalCardDbContext();
			db.Entry(account).State = EntityState.Modified;
			await db.SaveChangesAsync();
		}

		public async Task<int> PostAccount(Account account)
		{
			var db = new MedicalCardDbContext();
			db.Accounts.Add(account);
			await db.SaveChangesAsync();

			return account.Id;
		}

		public async Task<Account> DeleteAccount(int id)
		{
			var db = new MedicalCardDbContext();
			var account = await db.Accounts.FindAsync(id);
			if (account == null)
			{
				return null;
			}

			db.Accounts.Remove(account);
			await db.SaveChangesAsync();

			return account;
		}

		public bool AccountExists(int id)
		{
			return new MedicalCardDbContext().Accounts.Count(e => e.Id == id) > 0;
		}
	}
}