namespace MedicalCard.Entities
{
	using MedicalCard.Entities.Interfaces;

	public class Examination : IEntityWithId<int>
	{
		public int Id { get; set; }
	}
}