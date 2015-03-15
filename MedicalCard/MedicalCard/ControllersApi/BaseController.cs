namespace MedicalCard.ControllersApi
{
	using System;
	using System.Data;
	using System.Linq;
	using System.Web.Http;
	using AutoMapper;
	using BLL.Interfaces;
	using BLL.Repositories;
	using Entities.Exceptions;
	using Entities.Interfaces;
	using Helpers;
	using Models.Filters;

	public abstract class BaseController<TBusiness, TKey, TModel> : ApiController
		where TBusiness : class, IEntityWithId<TKey>
		where TModel : IEntityWithId<TKey>
	{
		#region [Fields]

		protected readonly IRepository<TBusiness, TKey> repository;

		#endregion

		#region [.ctor]

		protected BaseController(IRepository<TBusiness, TKey> repository)
		{
			this.repository = repository;
		}

		#endregion

		#region [Properties]

		protected abstract string ControllerName { get; }

		#endregion

		// GET api/<controller>
		public virtual IHttpActionResult Get([FromUri] TextFilterQuery query)
		{
			try
			{
				var source = query != null ? ApplyFilter(repository, query) : repository.GetAll();

				if (query != null && query.IsFilterSpecified())
				{
					query.CheckAndFixFilterParams();

					return Ok(Pagination.Get(
						source,
						query.Page.Value,
						query.PageSize.Value,
						Mapper.Map<TModel>,
						query.SortField,
						query.SortDirection));
				}
				return Ok(source.Select(Mapper.Map<TModel>));
			}
			catch (Exception)
			{
				return InternalServerError();
			}
		}

		// GET api/<controller>/5
		public virtual IHttpActionResult Get(TKey id)
		{
			try
			{
				var entity = repository.GetById(id);

				return Ok(Mapper.Map<TModel>(entity));
			}
			catch (EntityNotFoundException)
			{
				return NotFound();
			}
			catch (Exception)
			{
				return InternalServerError();
			}
		}

		// POST api/<controller>
		public virtual IHttpActionResult Post([FromBody] TModel value)
		{
			try
			{
				value = Mapper.Map<TModel>(repository.Add(Mapper.Map<TBusiness>(value)));

				return Created(
					new Uri(String.Format("{0}/{1}", ControllerName, value.Id), UriKind.Relative),
					value);
			}
			catch (Exception)
			{
				return InternalServerError();
			}
		}

		// PUT api/<controller>/5
		public virtual IHttpActionResult Put(TKey id, [FromBody] TModel value)
		{
			try
			{
				value.Id = id;
				return Ok(Mapper.Map<TModel>(repository.Update(Mapper.Map<TBusiness>(value))));
			}
			catch (DataException)
			{
				return NotFound();
			}
			catch (Exception)
			{
				return InternalServerError();
			}
		}

		// DELETE api/<controller>/5
		public virtual IHttpActionResult Delete(TKey id)
		{
			try
			{
				repository.RemoveById(id);
				return Ok();
			}
			catch (EntityNotFoundException)
			{
				return NotFound();
			}
			catch (Exception)
			{
				return InternalServerError();
			}
		}

		protected abstract IQueryable<TBusiness> ApplyFilter(IRepository<TBusiness, TKey> repository, TextFilterQuery query);

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);

			repository.Dispose();
		}
	}
}