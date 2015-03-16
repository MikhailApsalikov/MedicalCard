namespace MedicalCard.ControllersApi
{
	using System;
	using System.Linq;
	using System.Net;
	using System.Web.Http;
	using BLL;
	using BLL.Interfaces;
	using BLL.Repositories;
	using Entities;
	using Models;
	using Models.Filters;

	public class AccountsController : BaseController<Account, int, AccountModel>
	{
		public AccountsController() : base(new AccountRepository(new MedicalCardDbContext()))
		{
		}

		protected override string ControllerName
		{
			get { return "Accounts"; }
		}

		protected override IQueryable<Account> ApplyFilter(IRepository<Account, int> repository, TextFilterQuery query)
		{
			return String.IsNullOrEmpty(query.Search)
				? repository.GetAll()
				: repository.Filter(g =>
					(g.Username != null && g.Username.Contains(query.Search)));
		}

		public override IHttpActionResult Delete(int id)
		{
			return StatusCode(HttpStatusCode.MethodNotAllowed);
		}
	}
}