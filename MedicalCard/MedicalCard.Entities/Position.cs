namespace MedicalCard.Entities
{
	using System;
	using Interfaces;

	public class Position : IEntityWithId<int>
	{
		public String Name { get; set; }
		public int Id { get; set; }

		public Position()
		{
		}

		public Position(String name)
		{
			this.Name = name;
		}
	}
}