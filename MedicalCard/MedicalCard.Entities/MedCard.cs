namespace MedicalCard.Entities
{
	using MedicalCard.Entities.Interfaces;
	using System;
	using System.Linq;

	public class MedCard : IEntityWithId<int>
	{
		public int Id { get; set; }
	}
}