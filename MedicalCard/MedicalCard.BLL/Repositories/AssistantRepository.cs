namespace MedicalCard.BLL.Repositories
{
	using System.Data.Entity;
	using Entities;

	public class AssistantRepository : BaseRepository<Assistant, int>
	{
		public AssistantRepository(MedicalCardDbContext dbContext)
			: base(dbContext)
		{
		}

		protected override DbSet<Assistant> GetDbSet(MedicalCardDbContext dbContext)
		{
			return dbContext.Assistants;
		}
	}
}