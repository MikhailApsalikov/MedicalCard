namespace MedicalCard.Entities
{
	using MedicalCard.Entities.Interfaces;
	using System;
	using System.Linq;

	public class Examination : IEntityWithId<int>
	{
		public int Id { get; set; }
	}
}