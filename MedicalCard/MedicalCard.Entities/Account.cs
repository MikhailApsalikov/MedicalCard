namespace MedicalCard.Entities
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using Enums;
	using Interfaces;

	public class Account : IEntityWithId<int>
	{
		public Role Role { get; set; }

		[DisplayName("Логин")]
		[Required(ErrorMessage = "Логин не может быть пустым")]
		[StringLength(255, ErrorMessage = "Логин должен иметь длину от {2} до {1} символов", MinimumLength = 3)]
		[Index(IsUnique = true)]
		public String Username { get; set; }

		[DisplayName("Пароль")]
		[Required(ErrorMessage = "Пароль не может быть пустым")]
		[StringLength(255, ErrorMessage = "Пароль должен иметь длину от {2} до {1} символов", MinimumLength = 3)]
		public String Password { get; set; }

		[ForeignKey("Patient")]
		public int? PatientId { get; set; }

		public virtual Patient Patient { get; set; }

		[ForeignKey("Doctor")]
		public int? DoctorId { get; set; }

		public virtual Doctor Doctor { get; set; }

		public virtual List<WorkTime> WorkTimes { get; set; }

		[Key]
		public int Id { get; set; }
	}
}