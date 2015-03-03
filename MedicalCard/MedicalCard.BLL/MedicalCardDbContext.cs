namespace MedicalCard.BLL
{
	using System.Data.Entity;
	using MedicalCard.Entities;

	public class MedicalCardDbContext : DbContext
	{
		public DbSet<Account> Accounts { get; set; }

		public System.Data.Entity.DbSet<MedicalCard.Entities.Doctor> Doctors { get; set; }

		public System.Data.Entity.DbSet<MedicalCard.Entities.Patient> Patients { get; set; }
	}
}