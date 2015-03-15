namespace MedicalCard.BLL.Repositories
{
	using System.Data.Entity;
	using Entities;

	public class DoctorsRepository : BaseRepository<Doctor, int>
	{
		public DoctorsRepository(MedicalCardDbContext dbContext)
			: base(dbContext)
		{
		}

		protected override DbSet<Doctor> GetDbSet(MedicalCardDbContext dbContext)
		{
			return dbContext.Doctors;
		}
	}
}