namespace MedicalCard.BLL.Repositories
{
	using Entities;

	public class NoteRepository : BaseRepository<Note, int>
	{
		public NoteRepository(MedicalCardDbContext dbContext)
			: base(dbContext)
		{
		}

		protected override System.Data.Entity.DbSet<Note> GetDbSet(MedicalCardDbContext dbContext)
		{
			return dbContext.Notes;
		}
	}
}