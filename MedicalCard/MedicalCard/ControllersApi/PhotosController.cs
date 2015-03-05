namespace MedicalCard.ControllersApi
{
	using System.Data.Entity;
	using System.Data.Entity.Infrastructure;
	using System.Linq;
	using System.Net;
	using System.Threading.Tasks;
	using System.Web.Http;
	using System.Web.Http.Description;
	using MedicalCard.BLL;
	using MedicalCard.Entities;

	public class PhotosController : ApiController
	{
		private readonly MedicalCardDbContext db = new MedicalCardDbContext();
		// GET: api/Photos
		public IQueryable<Photo> GetPhotos()
		{
			return db.Photos;
		}

		// GET: api/Photos/5
		[ResponseType(typeof (Photo))]
		public async Task<IHttpActionResult> GetPhoto(int id)
		{
			var photo = await db.Photos.FindAsync(id);
			if (photo == null)
			{
				return NotFound();
			}

			return Ok(photo);
		}

		// PUT: api/Photos/5
		[ResponseType(typeof (void))]
		public async Task<IHttpActionResult> PutPhoto(int id, Photo photo)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			if (id != photo.Id)
			{
				return BadRequest();
			}

			db.Entry(photo).State = EntityState.Modified;

			try
			{
				await db.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!PhotoExists(id))
				{
					return NotFound();
				}
				throw;
			}

			return StatusCode(HttpStatusCode.NoContent);
		}

		// POST: api/Photos
		[ResponseType(typeof (Photo))]
		public async Task<IHttpActionResult> PostPhoto(Photo photo)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			db.Photos.Add(photo);
			await db.SaveChangesAsync();

			return CreatedAtRoute("DefaultApi", new {id = photo.Id}, photo);
		}

		// DELETE: api/Photos/5
		[ResponseType(typeof (Photo))]
		public async Task<IHttpActionResult> DeletePhoto(int id)
		{
			var photo = await db.Photos.FindAsync(id);
			if (photo == null)
			{
				return NotFound();
			}

			db.Photos.Remove(photo);
			await db.SaveChangesAsync();

			return Ok(photo);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				db.Dispose();
			}
			base.Dispose(disposing);
		}

		private bool PhotoExists(int id)
		{
			return db.Photos.Count(e => e.Id == id) > 0;
		}
	}
}