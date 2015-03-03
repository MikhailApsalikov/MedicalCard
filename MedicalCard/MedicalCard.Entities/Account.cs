namespace MedicalCard.Entities
{
	using System;
	using MedicalCard.Entities.Enums;
	using MedicalCard.Entities.Interfaces;

	public class Account : IEntityWithId<int>
	{
		public int Id { get; set; }

		public Role Role { get; set; }

		public String Username { get; set; }

		public String Password { get; set; }

		public int? PatientId { get; set; }

		public Patient Patient { get; set; }

		public int? DoctorId { get; set; }

		public Doctor Doctor { get; set; }
	}
}