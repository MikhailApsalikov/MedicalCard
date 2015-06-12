namespace MedicalCard.Entities
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using Enums;
	using Interfaces;

	public class Analysis : IEntityWithId<int>
	{
		public const int Interval = 5;

		[StringLength(200, ErrorMessage = "Тип анализа должен иметь длину от {2} до {1} символов", MinimumLength = 3)]
		public string Name { get; set; }

		public string Text { get; set; }
		public DateTime Date { get; set; }
		public int PatientId { get; set; }
		public virtual Patient Patient { get; set; }
		public int DoctorId { get; set; }
		public virtual Doctor Doctor { get; set; }
		public int AssistantId { get; set; }
		public virtual Assistant Assistant { get; set; }
		public AnalysisStatus Status { get; set; }
		public Side ChestSide { get; set; }
		public int ChestDegrees { get; set; }
		public Side NeckSide { get; set; }
		public int NeckDegrees { get; set; }
		public Side WaistSide { get; set; }
		public int WaistDegrees { get; set; }
		public int? PhotoId { get; set; }
		public virtual Photo Photo { get; set; }
		public int Id { get; set; }
	}
}