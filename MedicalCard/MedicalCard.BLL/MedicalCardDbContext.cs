﻿namespace MedicalCard.BLL
{
	using System.Data.Entity;
	using MedicalCard.Entities;

	public class MedicalCardDbContext : DbContext
	{
		public DbSet<Account> Accounts { get; set; }
		public DbSet<Doctor> Doctors { get; set; }
		public DbSet<Patient> Patients { get; set; }
	}
}