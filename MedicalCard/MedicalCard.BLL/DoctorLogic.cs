namespace MedicalCard.BLL
{
	using MedicalCard.Entities;
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
	using System.Linq;
	using System.Threading.Tasks;

	public class DoctorLogic
	{
		public List<Doctor> Get()
		{
			using (var db = new MedicalCardDbContext())
			{
				return db.Doctors.ToList();
			}
		}

		public async Task<Doctor> Get(int id)
		{
			return await new MedicalCardDbContext().Doctors.FindAsync(id);
		}

		public async Task Update(int id, Doctor doctor)
		{
			var db = new MedicalCardDbContext();
			db.Entry(doctor).State = EntityState.Modified;
			await db.SaveChangesAsync();
		}

		public async Task<int> Create(Doctor doctor)
		{
			throw new NotImplementedException("Доктора можно создать только при создании учетной записи");
		}

		public async Task<Doctor> Delete(int id)
		{
			var db = new MedicalCardDbContext();
			var doctor = await db.Doctors.FindAsync(id);
			if (doctor == null)
			{
				return null;
			}

			db.Doctors.Remove(doctor);
			await db.SaveChangesAsync();

			return doctor;
		}

		public bool IsExists(int id)
		{
			return new MedicalCardDbContext().Doctors.Count(e => e.Id == id) > 0;
		}
	}
}