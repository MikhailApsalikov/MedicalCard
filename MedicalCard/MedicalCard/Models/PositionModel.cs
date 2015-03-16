namespace MedicalCard.Models
{
	using System;
	using Entities.Interfaces;

	public class PositionModel : IEntityWithId<int>
	{
		public String Name { get; set; }
		public int Id { get; set; }
	}
}