namespace MedicalCard.Entities
{
	using System;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using Enums;
	using Interfaces;

	public class Account : IEntityWithId<int>
	{
		public Role Role { get; set; }

		[Required]
		[StringLength(255, ErrorMessage = "{0} должен иметь длину от {2} до {1} символов", MinimumLength = 3)]
		[DisplayName("Логин")]
		public String Username { get; set; }

		[Required]
		[StringLength(255, ErrorMessage = "{0} должен иметь длину от {2} до {1} символов", MinimumLength = 3)]
		[DisplayName("Пароль")]
		public String Password { get; set; }

		[ForeignKey("Patient")]
		public int? PatientId { get; set; }

		public virtual Patient Patient { get; set; }

		[ForeignKey("Doctor")]
		public int? DoctorId { get; set; }

		public virtual Doctor Doctor { get; set; }

		[Key]
		public int Id { get; set; }
	}
}