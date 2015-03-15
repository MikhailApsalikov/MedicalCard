namespace MedicalCard.Entities.Interfaces
{
	public interface IEntityWithId<TKey>
	{
		TKey Id { get; set; }
	}
}