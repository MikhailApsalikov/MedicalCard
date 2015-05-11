namespace MedicalCard.BLL
{
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
	using System.Linq;
	using Entities;
	using Entities.Enums;
	using Properties;

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
						BirthDate = new DateTime(1970, 1, 1),
						Email = "a@b.com",
						FirstName = "Борис",
						Gender = Gender.Male,
						LastName = "Иванов",
						MiddleName = "Романович",
						Phone = "+7123546678",
						PositionId = 3,
						WorkTimes = WorkTime.Default.ToList(),
						Photo = new Photo()
						{
							Content = Resources.test1.ImageToByteArray()
						}
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
						WorkTimes = WorkTime.Default.ToList(),
						Photo = new Photo()
						{
							Content = Resources.test2.ImageToByteArray()
						}
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
				},
				new Account
				{
					Username = "Oculist",
					Password = "Oculist",
					Role = Role.Doctor,
					Doctor = new Doctor
					{
						Address = "ул. Батинская, дом 91, квартира 222",
						BirthDate = new DateTime(1986, 6, 8),
						Email = "oculist@bk.ru",
						FirstName = "Зинаида",
						Gender = Gender.Female,
						LastName = "Пономарёва",
						MiddleName = "Григорьевна",
						Phone = "8 (908) 205-31-12",
						PositionId = 4,
						WorkTimes = WorkTime.Default.ToList(),
						Photo = new Photo()
						{
							Content = Resources.test10.ImageToByteArray()
						}
					}
				},
				new Account
				{
					Username = "Isabella",
					Password = "Isabella",
					Role = Role.Doctor,
					Doctor = new Doctor
					{
						Address = "г. Камешково, ул. Голландская, дом 18, квартира 182",
						BirthDate = new DateTime(1981, 10, 19),
						Email = "isabella@bk.ru",
						FirstName = "Изабелла",
						Gender = Gender.Female,
						LastName = "Наумова",
						MiddleName = "Кирилловна",
						Phone = "8 (908) 205-31-13",
						PositionId = 12,
						WorkTimes = WorkTime.Default.ToList(),
						Photo = new Photo()
						{
							Content = Resources.test9.ImageToByteArray()
						}
					}
				},
				new Account
				{
					Username = "gorodnov",
					Password = "gorodnov",
					Role = Role.Doctor,
					Doctor = new Doctor
					{
						Address = "г. Седельниково, ул. Декабристов, дом 49, квартира 283",
						BirthDate = new DateTime(1976, 12, 3),
						Email = "gorodnov@bk.ru",
						FirstName = "Агафон",
						Gender = Gender.Male,
						LastName = "Городнов",
						MiddleName = "Владимирович",
						Phone = "8 (928) 287-74-96",
						PositionId = 19,
						WorkTimes = WorkTime.Default.ToList(),
						Photo = new Photo()
						{
							Content = Resources.test3.ImageToByteArray()
						}
					}
				},
				new Account
				{
					Username = "alexandrov",
					Password = "alexandrov",
					Role = Role.Doctor,
					Doctor = new Doctor
					{
						Address = "г. Пижанка, ул. Беговая 3-я, дом 63, квартира 64",
						BirthDate = new DateTime(1969, 7, 13),
						Email = "alexandrov@bk.ru",
						FirstName = "Исай",
						Gender = Gender.Male,
						LastName = "Александров",
						MiddleName = "Максимович",
						Phone = "8 (978) 843-87-66",
						PositionId = 26,
						WorkTimes = WorkTime.Default.ToList(),
						Photo = new Photo()
						{
							Content = Resources.test4.ImageToByteArray()
						}
					}
				},
				new Account
				{
					Username = "yog",
					Password = "yog",
					Role = Role.Doctor,
					Doctor = new Doctor
					{
						Address = "г. Усть-Омчуг, ул. Адмирала Лазарева, дом 71, квартира 129",
						BirthDate = new DateTime(1991, 12, 25),
						Email = "yog@bk.ru",
						FirstName = "Вячеслав",
						Gender = Gender.Male,
						LastName = "Баландин",
						MiddleName = "Сергеевич",
						Phone = "8 (905) 936-16-48",
						PositionId = 32,
						WorkTimes = WorkTime.Default.ToList(),
						Photo = new Photo()
						{
							Content = Resources.test5.ImageToByteArray()
						}
					}
				},
				new Account
				{
					Username = "oxana",
					Password = "oxana",
					Role = Role.Doctor,
					Doctor = new Doctor
					{
						Address = "г. Каракулино, ул. Веселова, дом 57, квартира 55",
						BirthDate = new DateTime(1992, 8, 20),
						Email = "oxana@bk.ru",
						FirstName = "Оксана",
						Gender = Gender.Female,
						LastName = "Ичёткина",
						MiddleName = "Матвеевна",
						Phone = "8 (905) 459-26-71",
						PositionId = 32,
						WorkTimes = WorkTime.Default.ToList(),
						Photo = new Photo()
						{
							Content = Resources.test8.ImageToByteArray()
						}
					}
				},
				new Account
				{
					Username = "luda",
					Password = "luda",
					Role = Role.Doctor,
					Doctor = new Doctor
					{
						Address = "г. Каракулино, ул. Веселова, дом 57, квартира 55",
						BirthDate = new DateTime(1992, 9, 6),
						Email = "luda@bk.ru",
						FirstName = "Людмила",
						Gender = Gender.Female,
						LastName = "Соболева",
						MiddleName = "Антоновна",
						Phone = "8 (900) 685-31-46",
						PositionId = 36,
						WorkTimes = WorkTime.Default.ToList(),
						Photo = new Photo()
						{
							Content = Resources.test7.ImageToByteArray()
						}
					}
				},
				new Account
				{
					Username = "katya",
					Password = "katya",
					Role = Role.Doctor,
					Doctor = new Doctor
					{
						Address = "г. Усть-Донецкий, ул. Базовская, дом 7, квартира 31",
						BirthDate = new DateTime(1969, 7, 3),
						Email = "katya@bk.ru",
						FirstName = "Катерина",
						Gender = Gender.Female,
						LastName = "Трифонова",
						MiddleName = "Владиславовна",
						Phone = "8 (900) 387-44-52",
						PositionId = 41,
						WorkTimes = WorkTime.Default.ToList(),
						Photo = new Photo()
						{
							Content = Resources.test6.ImageToByteArray()
						}
					}
				},
			};

			context.Accounts.AddRange(accounts);
			context.SaveChanges();
		}
	}
}