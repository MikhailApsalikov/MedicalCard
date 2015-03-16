namespace MedicalCard.ControllersApi
{
	using System.Linq;
	using System.Net;
	using System.Web.Http;
	using BLL;
	using BLL.Interfaces;
	using BLL.Repositories;
	using Entities;
	using Models;
	using Models.Filters;

	public class PositionController : BaseController<Position, int, PositionModel>
	{
		public PositionController() : base(new PositionRepository(new MedicalCardDbContext()))
		{
		}

		protected override string ControllerName
		{
			get { return "Position"; }
		}

		protected override IQueryable<Position> ApplyFilter(IRepository<Position, int> repository, TextFilterQuery query)
		{
			return repository.GetAll();
		}

		public override IHttpActionResult Delete(int id)
		{
			return StatusCode(HttpStatusCode.MethodNotAllowed);
		}

		public override IHttpActionResult Post(PositionModel value)
		{
			return StatusCode(HttpStatusCode.MethodNotAllowed);
		}

		public override IHttpActionResult Put(int id, PositionModel value)
		{
			return StatusCode(HttpStatusCode.MethodNotAllowed);
		}
	}
}