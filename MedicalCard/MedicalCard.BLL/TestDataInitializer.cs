namespace MedicalCard.BLL
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using MedicalCard.Entities;
	using MedicalCard.Entities.Enums;

	public class TestDataInitializer
	{
		public Boolean Initialize()
		{
			var db = new MedicalCardDbContext();
			if (db.Accounts.Any())
			{
				return false;
			}

			var accounts = new List<Account>
			{
				new Account
				{
					Username = "Deejay",
					Password = "Deejay",
					Role = Role.Patient
				},
				new Account
				{
					Username = "Enhame",
					Password = "Enhame",
					Role = Role.Doctor
				},
				new Account
				{
					Username = "Doctor",
					Password = "Doctor",
					Role = Role.Patient
				},
				new Account
				{
					Username = "Patient",
					Password = "Patient",
					Role = Role.Doctor
				}
			};

			db.Accounts.AddRange(accounts);
			db.SaveChanges();
			return true;
		}
	}
}