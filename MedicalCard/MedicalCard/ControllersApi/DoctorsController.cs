namespace MedicalCard.ControllersApi
{
	using MedicalCard.BLL;
	using MedicalCard.Entities;
	using System.Collections.Generic;
	using System.Data.Entity;
	using System.Data.Entity.Infrastructure;
	using System.Linq;
	using System.Net;
	using System.Threading.Tasks;
	using System.Web.Http;
	using System.Web.Http.Description;

	public class DoctorsController : ApiController
	{
		// GET: api/Doctors
		public IEnumerable<Doctor> GetDoctors()
		{
			return from doctor in new DoctorLogic().Get()
				   select new Doctor
				   {
					   Id = doctor.Id,
					   Address = doctor.Address,
					   BirthDate = doctor.BirthDate,
					   Email = doctor.Email,
					   FirstName = doctor.FirstName,
					   Gender = doctor.Gender,
					   LastName = doctor.LastName,
					   MiddleName = doctor.MiddleName,
					   Phone = doctor.Phone,
					   PhotoId = doctor.PhotoId,
					   Position = doctor.Position,
				   };
		}

		// GET: api/Doctors/5
		[ResponseType(typeof(Doctor))]
		public async Task<IHttpActionResult> GetDoctor(int id)
		{
			var doctor = await new DoctorLogic().Get(id);
			if (doctor == null)
			{
				return NotFound();
			}

			return Ok(doctor);
		}

		// PUT: api/Doctors/5
		[ResponseType(typeof(void))]
		public async Task<IHttpActionResult> PutDoctor(int id, Doctor doctor)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			if (id != doctor.Id)
			{
				return BadRequest();
			}

			try
			{
				await new DoctorLogic().Update(id, doctor);
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!new DoctorLogic().IsExists(id))
				{
					return NotFound();
				}
				throw;
			}

			return StatusCode(HttpStatusCode.NoContent);
		}

		// POST: api/Doctors
		[ResponseType(typeof(Doctor))]
		public async Task<IHttpActionResult> PostDoctor(Doctor doctor)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			await new DoctorLogic().Create(doctor);

			return CreatedAtRoute("DefaultApi", new { id = doctor.Id }, doctor);
		}

		// DELETE: api/Doctors/5
		[ResponseType(typeof(Doctor))]
		public async Task<IHttpActionResult> DeleteDoctor(int id)
		{
			var doctor = await new DoctorLogic().Delete(id);
			if (doctor != null)
			{
				return Ok(doctor);
			}

			return NotFound();
		}
	}
}