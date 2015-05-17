namespace MedicalCard.Entities
{
	using System;
	using Enums;
	using Interfaces;

	public class Analysis : IEntityWithId<int>
	{
		public const int Interval = 5;
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
		public int Id { get; set; }
	}
}