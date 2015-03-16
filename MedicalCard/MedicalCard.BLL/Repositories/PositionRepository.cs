namespace MedicalCard.BLL.Repositories
{
	using Entities;

	public class PositionRepository : BaseRepository<Position, int>
	{
		public PositionRepository(MedicalCardDbContext dbContext)
			: base(dbContext)
		{
		}

		protected override System.Data.Entity.DbSet<Position> GetDbSet(MedicalCardDbContext dbContext)
		{
			return dbContext.Positions;
		}
	}
}