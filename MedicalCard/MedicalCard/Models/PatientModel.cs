namespace MedicalCard.Models
{
	using System;
	using Entities.Enums;
	using Entities.Interfaces;

	public class PatientModel : IEntityWithId<int>
	{
		public String LastName { get; set; }
		public String FirstName { get; set; }
		public String MiddleName { get; set; }
		public DateTime? BirthDate { get; set; }
		public Gender Gender { get; set; }
		public String Address { get; set; }
		public String Phone { get; set; }
		public String Email { get; set; }
		public String Snils { get; set; }
		public String InsurancePolicy { get; set; }
		public Disability Disability { get; set; }
		public int Id { get; set; }
		public String DisabilityDocument { get; set; }
		public String JobStudyPosition { get; set; }
	}
}