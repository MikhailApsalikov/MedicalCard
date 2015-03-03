namespace MedicalCard.Entities
{
	using MedicalCard.Entities.Interfaces;

	public class Analysis : IEntityWithId<int>
	{
		public int Id { get; set; }
	}
}