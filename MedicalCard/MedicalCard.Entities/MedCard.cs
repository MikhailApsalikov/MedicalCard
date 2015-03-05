namespace MedicalCard.Entities
{
	using MedicalCard.Entities.Interfaces;

	public class MedCard : IEntityWithId<int>
	{
		public int Id { get; set; }

		public int PatientId { get; set; }

		public Patient Patient { get; set; }

		public int DoctorId { get; set; }

		public Doctor Doctor { get; set; }
	}
}