namespace MedicalCard.BLL
{
	using System.Data;
	using System.Data.Entity;
	using System.Data.Entity.Infrastructure;
	using System.Data.Entity.ModelConfiguration.Conventions;
	using Entities;
	using Interfaces;

	public class MedicalCardDbContext : DbContext
	{
		public DbSet<Account> Accounts { get; set; }
		public DbSet<Doctor> Doctors { get; set; }
		public DbSet<Patient> Patients { get; set; }
		public DbSet<Photo> Photos { get; set; }
		public DbSet<Position> Positions { get; set; }
		public DbSet<Examination> Examinations { get; set; }
		public DbSet<Note> Notes { get; set; }

		public void Update<TEntity>(TEntity entity) where TEntity : class
		{
			Entry(entity).State = EntityState.Modified;
		}

		public ITransaction BeginTransaction()
		{
			return new DbTransactionWrapper(Database.BeginTransaction());
		}

		public ITransaction BeginTransaction(IsolationLevel level)
		{
			return new DbTransactionWrapper(Database.BeginTransaction(level));
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
			modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
			modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
		}
	}
}