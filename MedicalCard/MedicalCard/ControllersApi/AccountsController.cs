namespace MedicalCard.ControllersApi
{
	using System.Collections.Generic;
	using System.Data.Entity.Infrastructure;
	using System.Linq;
	using System.Net;
	using System.Threading.Tasks;
	using System.Web.Http;
	using System.Web.Http.Description;
	using MedicalCard.BLL;
	using MedicalCard.Entities;

	public class AccountsController : ApiController
	{
		// GET: api/Accounts
		public IEnumerable<Account> GetAccounts()
		{
			return from account in new AccountLogic().Get()
				select new Account
				{
					Id = account.Id,
					Username = account.Username,
					Password = account.Password,
					Role = account.Role,
					PatientId = account.PatientId,
					DoctorId = account.DoctorId,
				};
		}

		// GET: api/Accounts/5
		[ResponseType(typeof (Account))]
		public async Task<IHttpActionResult> GetAccount(int id)
		{
			var account = await new AccountLogic().Get(id);
			if (account == null)
			{
				return NotFound();
			}

			return Ok(account);
		}

		// PUT: api/Accounts/5
		[ResponseType(typeof (void))]
		public async Task<IHttpActionResult> PutAccount(int id, Account account)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			if (id != account.Id)
			{
				return BadRequest();
			}

			try
			{
				await new AccountLogic().Update(id, account);
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!new AccountLogic().IsExists(id))
				{
					return NotFound();
				}
				throw;
			}

			return StatusCode(HttpStatusCode.NoContent);
		}

		// POST: api/Accounts
		[ResponseType(typeof (Account))]
		public async Task<IHttpActionResult> PostAccount(Account account)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			await new AccountLogic().Create(account);

			return CreatedAtRoute("DefaultApi", new {id = account.Id}, account);
		}

		// DELETE: api/Accounts/5
		[ResponseType(typeof (Account))]
		public async Task<IHttpActionResult> DeleteAccount(int id)
		{
			var account = await new AccountLogic().Delete(id);
			if (account != null)
			{
				return Ok(account);
			}

			return NotFound();
		}
	}
}