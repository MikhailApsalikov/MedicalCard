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

	public class PatientsController : ApiController
	{
		private readonly MedicalCardDbContext db = new MedicalCardDbContext();
		// GET: api/Patients
		public IQueryable<Patient> GetPatients()
		{
			return db.Patients;
		}

		// GET: api/Patients/5
		[ResponseType(typeof (Patient))]
		public async Task<IHttpActionResult> GetPatient(int id)
		{
			var patient = await db.Patients.FindAsync(id);
			if (patient == null)
			{
				return NotFound();
			}

			return Ok(patient);
		}

		// PUT: api/Patients/5
		[ResponseType(typeof (void))]
		public async Task<IHttpActionResult> PutPatient(int id, Patient patient)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			if (id != patient.Id)
			{
				return BadRequest();
			}

			db.Entry(patient).State = EntityState.Modified;

			try
			{
				await db.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!PatientExists(id))
				{
					return NotFound();
				}
				throw;
			}

			return StatusCode(HttpStatusCode.NoContent);
		}

		// POST: api/Patients
		[ResponseType(typeof (Patient))]
		public async Task<IHttpActionResult> PostPatient(Patient patient)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			db.Patients.Add(patient);

			try
			{
				await db.SaveChangesAsync();
			}
			catch (DbUpdateException)
			{
				if (PatientExists(patient.Id))
				{
					return Conflict();
				}
				throw;
			}

			return CreatedAtRoute("DefaultApi", new {id = patient.Id}, patient);
		}

		// DELETE: api/Patients/5
		[ResponseType(typeof (Patient))]
		public async Task<IHttpActionResult> DeletePatient(int id)
		{
			var patient = await db.Patients.FindAsync(id);
			if (patient == null)
			{
				return NotFound();
			}

			db.Patients.Remove(patient);
			await db.SaveChangesAsync();

			return Ok(patient);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				db.Dispose();
			}
			base.Dispose(disposing);
		}

		private bool PatientExists(int id)
		{
			return db.Patients.Count(e => e.Id == id) > 0;
		}
	}
}