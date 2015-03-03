namespace MedicalCard.Entities
{
	using MedicalCard.Entities.Interfaces;

	public class MedCard : IEntityWithId<int>
	{
		public int Id { get; set; }
	}
}