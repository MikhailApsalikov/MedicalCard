namespace MedicalCard.Entities
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using Interfaces;

	public class Position : IEntityWithId<int>
	{
		[Required]
		[Index(IsUnique = true)]
		[StringLength(50)]
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