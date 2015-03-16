namespace MedicalCard.BLL
{
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
	using System.Linq;
	using Entities;
	using Entities.Enums;

	public class TestDataInitializer : DropCreateDatabaseIfModelChanges<MedicalCardDbContext>
	{
		protected override void Seed(MedicalCardDbContext context)
		{
			try
			{
				Initialize(context);
			}
			catch
			{
			}
		}

		private void Initialize(MedicalCardDbContext context)
		{
			if (context.Accounts.Any())
			{
				return;
			}

			var accounts = new List<Account>
			{
				new Account
				{
					Username = "Anton",
					Password = "Anton",
					Role = Role.Patient,
					Patient = new Patient
					{
						Address = "г.Саратов ул.Антонова д.25. кв.31",
						BirthDate = new DateTime(1992, 12, 31),
						Email = "dh@as.com",
						FirstName = "Антон",
						Gender = Gender.Male,
						LastName = "Зеленцов",
						MiddleName = "Петрович",
						Phone = "+7915468741",
						Disability = Disability.None,
						InsurancePolicy = "4897693246237940",
						Snils = "434836472683"
					}
				},
				new Account
				{
					Username = "Boris",
					Password = "Boris",
					Role = Role.Doctor,
					Doctor = new Doctor
					{
						Address = "г.Саратов ул.Антонова д.25. кв.32",
						BirthDate = new DateTime(1990, 1, 1),
						Email = "a@b.com",
						FirstName = "Борис",
						Gender = Gender.Male,
						LastName = "Иванов",
						MiddleName = "Романович",
						Phone = "123546678",
						Position = Position.Surgeon
					}
				},
				new Account
				{
					Username = "Doctor",
					Password = "Doctor",
					Role = Role.Doctor,
					Doctor = new Doctor
					{
						Address = "улица Пушкина, д.24 кв.5",
						BirthDate = new DateTime(1990, 6, 8),
						Email = "doctor@bk.ru",
						FirstName = "Петров",
						Gender = Gender.Male,
						LastName = "Петр",
						MiddleName = "Петрович",
						Phone = "+79177894561",
						Position = Position.Therapist
					}
				},
				new Account
				{
					Username = "Patient",
					Password = "Patient",
					Role = Role.Patient,
					Patient = new Patient
					{
						Address = "г.Саратов ул.Соколовая д.52. кв.11",
						BirthDate = new DateTime(1987, 1, 2),
						Email = "patient@bk.ru",
						FirstName = "Иванова",
						Gender = Gender.Female,
						LastName = "Елена",
						MiddleName = "Николаевна",
						Phone = "+7915464321",
						Disability = Disability.Third,
						InsurancePolicy = "4897693246237940",
						Snils = "434836472683"
					}
				}
			};

			context.Accounts.AddRange(accounts);
			context.SaveChanges();
		}
	}
}