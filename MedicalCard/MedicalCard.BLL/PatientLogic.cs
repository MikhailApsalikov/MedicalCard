namespace MedicalCard.BLL
{
	using MedicalCard.Entities;
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
	using System.Linq;
	using System.Threading.Tasks;

	public class PatientLogic
	{
		public List<Patient> Get()
		{
			using (var db = new MedicalCardDbContext())
			{
				return db.Patients.ToList();
			}
		}

		public async Task<Patient> Get(int id)
		{
			return await new MedicalCardDbContext().Patients.FindAsync(id);
		}

		public async Task Update(int id, Patient patient)
		{
			var db = new MedicalCardDbContext();
			db.Entry(patient).State = EntityState.Modified;
			await db.SaveChangesAsync();
		}

		public Task<int> Create(Patient patient)
		{
			throw new NotImplementedException("Пациента можно создать только при создании учетной записи");
		}

		public async Task<Patient> Delete(int id)
		{
			var db = new MedicalCardDbContext();
			var patient = await db.Patients.FindAsync(id);
			if (patient == null)
			{
				return null;
			}

			db.Patients.Remove(patient);
			await db.SaveChangesAsync();

			return patient;
		}

		public bool IsExists(int id)
		{
			return new MedicalCardDbContext().Patients.Count(e => e.Id == id) > 0;
		}
	}
}