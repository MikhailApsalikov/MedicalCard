namespace MedicalCard.BLL.Repositories
{
	using System.Data.Entity;
	using Entities;

	public class PositionRepository : BaseRepository<Position, int>
	{
		public PositionRepository(MedicalCardDbContext dbContext)
			: base(dbContext)
		{
		}

		protected override DbSet<Position> GetDbSet(MedicalCardDbContext dbContext)
		{
			return dbContext.Positions;
		}
	}
}