namespace MedicalCard.Entities.Interfaces
{
	using System;
	using System.Linq;

	public interface IEntityWithId<TKey>
	{
		TKey Id { get; set; }
	}
}