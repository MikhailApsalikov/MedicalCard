namespace MedicalCard.BLL.Repositories
{
	using System.Data.Entity;
	using Entities;

	public class PatientRepository : BaseRepository<Patient, int>
	{
		public PatientRepository(MedicalCardDbContext dbContext)
			: base(dbContext)
		{
		}

		protected override DbSet<Patient> GetDbSet(MedicalCardDbContext dbContext)
		{
			return dbContext.Patients;
		}
	}
}