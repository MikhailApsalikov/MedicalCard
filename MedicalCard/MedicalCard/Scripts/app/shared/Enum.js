(function() {
	"use strict";

	angular.module("medicalCardApp").constant("Enums", {
		roleCodes: {
			patient: 1,
			doctor: 2
		},

		genderCodes: {
			male: 1,
			female: 2
		},

		disabilityCodes: {
			//("Нет")
			None: 0,
			//("Инвалидность 3-ей группы")
			Third: 3,
			//("Инвалидность 2-ой группы")
			Second: 2,
			//("Инвалидность 1-ой группы")
			First: 1
		},

		positionCodes: {
			//(Терапевт)
			Therapist: 1,
			//(Лаборант)
			Assistant: 2,
			//(Хирург)
			Surgeon: 3,
			//(Акушер-гинеколог)
			ObstetricianGynecologist: 4,
			//(Аллерголог)
			Allergist: 5,
			//(Аллерголог-иммунолог)
			AllergistImmunologist: 6,
			//(Ангиохирург)
			Angiosurgeon: 7,
			//(Андролог)
			Andrologist: 8,
			//(Анестезиолог)
			Anesthesiologist: 9,
			//(Венеролог)
			Venereologist: 10,
			//(Вирусолог)
			Virologist: 11,
			//(Врач лечебной физкультуры)
			DoctorOfPhysicalTherapy: 12,
			//(Врач общей практики)
			GeneralPractitioner: 13,
			//(Гастроэнтеролог)
			Gastroenterologist: 14,
			//(Гематолог)
			Hematologist: 15,
			//(Генетик)
			Geneticist: 16,
			//(Гинеколог)
			Gynecologist: 17,
			//(Дерматовенеролог)
			Dermatovenerologist: 18,
			//(Дерматолог)
			Dermatologist: 19,
			//(Диетолог)
			Nutritionist: 20,
			//(Иммунолог)
			Immunologist: 21,
			//(Кардиолог)
			Cardiologist: 22,
			//(Кардиохирург)
			Cardiac: 23,
			//(Косметолог)
			Beautician: 24,
			//(Маммолог)
			Mammolog: 25,
			//(Нарколог)
			ExpertInNarcology: 26,
			//(Невролог)
			Neurologist: 27,
			//(Нейрохирург)
			Neurosurgeon: 28,
			//(Окулист)
			Optometrist: 29,
			//(Ортопед)
			Orthopedist: 30,
			//(Остеопат)
			Osteopath: 31,
			//(Оториноларинголог)
			Otolaryngologist: 32,
			//(Педиатр)
			Pediatrician: 33,
			//(Проктолог)
			Proctologist: 34,
			//(Психиатр)
			Psychiatrist: 35,
			//(Пульмонолог)
			Pulmonologist: 36,
			//(Реаниматолог)
			Resuscitator: 37,
			//(Ревматолог)
			Rheumatologist: 38,
			//(Рентгенолог)
			Radiologist: 39,
			//(Сексопатолог)
			Sexologist: 40,
			//(Стоматолог)
			Stomatologist: 41,
			//(Сурдолог)
			Audiologist: 42,
			//(Токсиколог)
			Toxicologist: 43,
			//(Травматолог)
			Traumatologist: 44,
			//(Уролог)
			Urologist: 45,
			//(Фармаколог)
			Pharmacologist: 46,
			//(Физиотерапевт)
			Physiotherapist: 47,
			//(Эметолог)
			Emetolog: 48,
			//(Эндокринолог)
			Endocrinologist: 49,
			//(Эндоскопист)
			Endoscopist: 50,
			//(Эпидемиолог)
			Epidemiologist: 51
		}
	});


}());