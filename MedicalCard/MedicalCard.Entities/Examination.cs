namespace MedicalCard.Entities
{
	using System;
	using System.Collections.Generic;
	using MedicalCard.Entities.Enums;
	using MedicalCard.Entities.Interfaces;

	public class Examination : IEntityWithId<int>
	{
		public DateTime ExaminationDate { get; set; }
		public int PatientId { get; set; }
		public virtual Patient Patient { get; set; }
		public int DoctorId { get; set; }
		public virtual Doctor Doctor { get; set; }
		public int Id { get; set; }
		public ExaminationStatus Status { get; set; }
		public string Text { get; set; }
		public virtual List<Analysis> Analyses { get; set; }
	}
}