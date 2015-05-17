namespace MedicalCard.Entities
{
	using System;
	using Enums;
	using Interfaces;

	public class Examination : IEntityWithId<int>
	{
		public const int Interval = 15;
		public DateTime ExaminationDate { get; set; }
		public int PatientId { get; set; }
		public virtual Patient Patient { get; set; }
		public int DoctorId { get; set; }
		public virtual Doctor Doctor { get; set; }
		public ExaminationStatus Status { get; set; }
		public string Text { get; set; }
		public int Id { get; set; }
	}
}