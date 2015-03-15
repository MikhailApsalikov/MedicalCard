namespace MedicalCard.BLL.Repositories
{
	using System.Data.Entity;
	using Entities;

	public class DoctorRepository : BaseRepository<Doctor, int>
	{
		public DoctorRepository(MedicalCardDbContext dbContext)
			: base(dbContext)
		{
		}

		protected override DbSet<Doctor> GetDbSet(MedicalCardDbContext dbContext)
		{
			return dbContext.Doctors;
		}
	}
}