namespace MedicalCard.Entities
{
	using Interfaces;

	public class Photo : IEntityWithId<int>
	{
		public byte[] Content { get; set; }
		public int Id { get; set; }
	}
}