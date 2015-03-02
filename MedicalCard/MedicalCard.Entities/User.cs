namespace MedicalCard.Entities
{
	using MedicalCard.Entities.Enums;
	using MedicalCard.Entities.Interfaces;
	using System;

	using System.Linq;

	public abstract class User : IEntityWithId<int>
	{
		public int Id { get; set; }

		public Role Role { get; set; }

		public String LastName { get; set; }

		public String FirstName { get; set; }

		public String MiddleName { get; set; }

		public DateTime BirthDate { get; set; }

		public Gender Gender { get; set; }

		public String Address { get; set; }

		public String Phone { get; set; }

		public String Email { get; set; }
	}
}