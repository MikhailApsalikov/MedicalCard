namespace MedicalCard.BLL.Repositories
{
	using System.Data.Entity;
	using Entities;

	public class AnalysesRepository : BaseRepository<Analysis, int>
	{
		public AnalysesRepository(MedicalCardDbContext dbContext)
			: base(dbContext)
		{
		}

		protected override DbSet<Analysis> GetDbSet(MedicalCardDbContext dbContext)
		{
			return dbContext.Analyses;
		}
	}
}