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

	public class DoctorsController : BaseController<Doctor, int, DoctorModel>
	{
		public DoctorsController() : base(new DoctorsRepository(new MedicalCardDbContext()))
		{
		}

		protected override string ControllerName
		{
			get { return "Doctors"; }
		}

		protected override IQueryable<Doctor> ApplyFilter(IRepository<Doctor, int> repository, TextFilterQuery query)
		{
			return String.IsNullOrEmpty(query.Search)
				? repository.GetAll()
				: repository.Filter(g =>
					(g.FirstName != null && g.FirstName.Contains(query.Search))
					|| (g.LastName != null && g.LastName.Contains(query.Search))
					|| (g.MiddleName != null && g.MiddleName.Contains(query.Search)));
		}

		public override IHttpActionResult Delete(int id)
		{
			return StatusCode(HttpStatusCode.MethodNotAllowed);
		}

		public override IHttpActionResult Post(DoctorModel value)
		{
			return StatusCode(HttpStatusCode.MethodNotAllowed);
		}
	}
}