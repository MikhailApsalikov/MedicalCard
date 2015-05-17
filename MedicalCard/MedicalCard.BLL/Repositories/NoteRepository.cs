namespace MedicalCard.BLL.Repositories
{
	using System.Data.Entity;
	using Entities;

	public class NoteRepository : BaseRepository<Note, int>
	{
		public NoteRepository(MedicalCardDbContext dbContext)
			: base(dbContext)
		{
		}

		protected override DbSet<Note> GetDbSet(MedicalCardDbContext dbContext)
		{
			return dbContext.Notes;
		}
	}
}