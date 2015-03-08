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
					Role = Role.Doctor,
					Doctor = new Doctor(){
						Address = "Somewhere",
						BirthDate = new DateTime(1990, 1,1),
						Email = "1@1.com",
						FirstName = "FirstName",
						Gender = Gender.Male,
						LastName = "LastName",
						MiddleName = "MiddleName",
						Phone = "123546678",
						Position = "Хирург",
					}
				},
				new Account
				{
					Username = "Doctor",
					Password = "Doctor",
					Role = Role.Doctor,
					Doctor = new Doctor(){
						Address = "улица Пушкина, д.24 кв.5",
						BirthDate = new DateTime(1990, 6, 8),
						Email = "patient@bk.ru",
						FirstName = "Врач",
						Gender = Gender.Male,
						LastName = "Враченко",
						MiddleName = "Врачевич",
						Phone = "+79177894561",
						Position = "Терапевт",
					}
				},
				new Account
				{
					Username = "Patient",
					Password = "Patient",
					Role = Role.Patient,
				}
			};

			db.Accounts.AddRange(accounts);
			db.SaveChanges();
			return true;
		}
	}
}