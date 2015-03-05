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

	public class MedCardsController : ApiController
	{
		private readonly MedicalCardDbContext db = new MedicalCardDbContext();
		// GET: api/MedCards
		public IQueryable<MedCard> GetMedCards()
		{
			return db.MedCards;
		}

		// GET: api/MedCards/5
		[ResponseType(typeof (MedCard))]
		public async Task<IHttpActionResult> GetMedCard(int id)
		{
			var medCard = await db.MedCards.FindAsync(id);
			if (medCard == null)
			{
				return NotFound();
			}

			return Ok(medCard);
		}

		// PUT: api/MedCards/5
		[ResponseType(typeof (void))]
		public async Task<IHttpActionResult> PutMedCard(int id, MedCard medCard)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			if (id != medCard.Id)
			{
				return BadRequest();
			}

			db.Entry(medCard).State = EntityState.Modified;

			try
			{
				await db.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!MedCardExists(id))
				{
					return NotFound();
				}
				throw;
			}

			return StatusCode(HttpStatusCode.NoContent);
		}

		// POST: api/MedCards
		[ResponseType(typeof (MedCard))]
		public async Task<IHttpActionResult> PostMedCard(MedCard medCard)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			db.MedCards.Add(medCard);
			await db.SaveChangesAsync();

			return CreatedAtRoute("DefaultApi", new {id = medCard.Id}, medCard);
		}

		// DELETE: api/MedCards/5
		[ResponseType(typeof (MedCard))]
		public async Task<IHttpActionResult> DeleteMedCard(int id)
		{
			var medCard = await db.MedCards.FindAsync(id);
			if (medCard == null)
			{
				return NotFound();
			}

			db.MedCards.Remove(medCard);
			await db.SaveChangesAsync();

			return Ok(medCard);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				db.Dispose();
			}
			base.Dispose(disposing);
		}

		private bool MedCardExists(int id)
		{
			return db.MedCards.Count(e => e.Id == id) > 0;
		}
	}
}