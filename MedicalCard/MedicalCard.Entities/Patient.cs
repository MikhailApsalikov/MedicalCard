namespace MedicalCard.Entities
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using Enums;
	using Interfaces;

	public class Patient : IEntityWithId<int>
	{
		public virtual Account Account { get; set; }

		[DisplayName("Фамилия")]
		[StringLength(255, ErrorMessage = "Фамилия должна иметь длину от {2} до {1} символов", MinimumLength = 3)]
		[DefaultValue("Фамилия")]
		public String LastName { get; set; }

		[DisplayName("Имя")]
		[StringLength(255, ErrorMessage = "Имя должно иметь длину от {2} до {1} символов", MinimumLength = 3)]
		[DefaultValue("Имя")]
		public String FirstName { get; set; }

		[DisplayName("Отчество")]
		public String MiddleName { get; set; }

		public DateTime? BirthDate { get; set; }
		public Gender Gender { get; set; }
		public String Address { get; set; }
		public String Phone { get; set; }
		public String Email { get; set; }
		public String Snils { get; set; }
		public String InsurancePolicy { get; set; }
		public Disability Disability { get; set; }
		public String DisabilityDocument { get; set; }
		public String JobStudyPosition { get; set; }

		[NotMapped]
		public string FullName
		{
			get { return String.Format("{0} {1} {2}", LastName, FirstName, MiddleName); }
		}

		public virtual List<Examination> Examinations { get; set; }
		public virtual List<Note> Notes { get; set; }
		public virtual List<Analysis> Analyses { get; set; }

		[Key, ForeignKey("Account")]
		public int Id { get; set; }
	}
}