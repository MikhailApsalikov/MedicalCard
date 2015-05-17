namespace MedicalCard.Entities
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using Interfaces;

	public class Note : IEntityWithId<int>
	{
		public int PatientId { get; set; }
		public virtual Patient Patient { get; set; }
		public int DoctorId { get; set; }
		public virtual Doctor Doctor { get; set; }
		public DateTime CreateDate { get; set; }
		public DateTime ExpirationDate { get; set; }

		[StringLength(50, ErrorMessage = "Заголовок должен иметь длину от {2} до {1} символов", MinimumLength = 3)]
		public String Title { get; set; }

		[StringLength(1000, ErrorMessage = "Текст справки должен иметь длину от {2} до {1} символов", MinimumLength = 25)]
		public String Text { get; set; }

		public int Id { get; set; }
	}
}