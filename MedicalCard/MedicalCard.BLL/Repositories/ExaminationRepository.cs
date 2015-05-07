namespace MedicalCard.BLL.Repositories
{
	using System.Data.Entity;
	using Entities;

	public class ExaminationRepository : BaseRepository<Examination, int>
	{
		public ExaminationRepository(MedicalCardDbContext dbContext)
			: base(dbContext)
		{
		}

		protected override DbSet<Examination> GetDbSet(MedicalCardDbContext dbContext)
		{
			return dbContext.Examinations;
		}
	}
}