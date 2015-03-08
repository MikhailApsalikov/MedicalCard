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
	using System.Collections.Generic;

	public class PatientsController : ApiController
	{
		private readonly MedicalCardDbContext db = new MedicalCardDbContext();
		// GET: api/Patients
		public IEnumerable<Patient> GetPatients()
		{
			return from patient in new PatientLogic().Get()
				   select new Patient
				   {
					   Id = patient.Id,
					   Address = patient.Address,
					   BirthDate = patient.BirthDate,
					   Email = patient.Email,
					   FirstName = patient.FirstName,
					   Gender = patient.Gender,
					   LastName = patient.LastName,
					   MiddleName = patient.MiddleName,
					   Phone = patient.Phone,
					   Disability = patient.Disability,
					   InsurancePolicy = patient.InsurancePolicy,
					   Snils = patient.Snils,
				   };
		}

		// GET: api/Patients/5
		[ResponseType(typeof (Patient))]
		public async Task<IHttpActionResult> GetPatient(int id)
		{
			var patient = await new PatientLogic().Get(id);
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

			try
			{
				await new PatientLogic().Update(id, patient);
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!new PatientLogic().IsExists(id))
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

			await new PatientLogic().Create(patient);
			return CreatedAtRoute("DefaultApi", new { id = patient.Id }, patient);
		}

		// DELETE: api/Patients/5
		[ResponseType(typeof (Patient))]
		public async Task<IHttpActionResult> DeletePatient(int id)
		{
			var patient = await new PatientLogic().Delete(id);
			if (patient != null)
			{
				return Ok(patient);
			}

			return NotFound();
		}
	}
}