namespace MedicalCard.Entities
{
	using MedicalCard.Entities.Interfaces;

	public class Photo : IEntityWithId<int>
	{
		public byte[] Content { get; set; }
		public int Id { get; set; }
	}
}