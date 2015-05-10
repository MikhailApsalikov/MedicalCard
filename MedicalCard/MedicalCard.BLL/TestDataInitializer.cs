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
			InitializePositions(context);
			Initialize(context);
		}

		private void InitializePositions(MedicalCardDbContext context)
		{
			if (context.Positions.Any())
			{
				return;
			}

			var positions = new List<Position>
			{
				new Position("Терапевт"),
				new Position("Лаборант"),
				new Position("Хирург"),
				new Position("Окулист"),
				new Position("Нейрохирург"),
				new Position("Невролог"),
				new Position("Нарколог"),
				new Position("Маммолог"),
				new Position("Косметолог"),
				new Position("Кардиохирург"),
				new Position("Кардиолог"),
				new Position("Иммунолог"),
				new Position("Диетолог"),
				new Position("Дерматолог"),
				new Position("Дерматовенеролог"),
				new Position("Гинеколог"),
				new Position("Генетик"),
				new Position("Гематолог"),
				new Position("Гастроэнтеролог"),
				new Position("Врач общей практики"),
				new Position("Врач лечебной физкультуры"),
				new Position("Вирусолог"),
				new Position("Венеролог"),
				new Position("Анестезиолог"),
				new Position("Андролог"),
				new Position("Ангиохирург"),
				new Position("Аллерголог-иммунолог"),
				new Position("Аллерголог"),
				new Position("Акушер-гинеколог"),
				new Position("Физиотерапевт"),
				new Position("Эметолог"),
				new Position("Эндокринолог"),
				new Position("Эндоскопист"),
				new Position("Фармаколог"),
				new Position("Уролог"),
				new Position("Травматолог"),
				new Position("Токсиколог"),
				new Position("Сурдолог"),
				new Position("Стоматолог"),
				new Position("Сексопатолог"),
				new Position("Рентгенолог"),
				new Position("Ревматолог"),
				new Position("Реаниматолог"),
				new Position("Пульмонолог"),
				new Position("Психиатр"),
				new Position("Проктолог"),
				new Position("Педиатр"),
				new Position("Оториноларинголог"),
				new Position("Остеопат"),
				new Position("Ортопед"),
				new Position("Эпидемиолог")
			};

			context.Positions.AddRange(positions);
			context.SaveChanges();
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
						PositionId = 3,
						WorkTimes = WorkTime.Default.ToList()
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
						FirstName = "Петр",
						Gender = Gender.Male,
						LastName = "Петров",
						MiddleName = "Петрович",
						Phone = "+79177894561",
						PositionId = 1,
						WorkTimes = WorkTime.Default.ToList()
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
						FirstName = "Елена",
						Gender = Gender.Female,
						LastName = "Иванова",
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