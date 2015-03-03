namespace MedicalCard.Entities
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using MedicalCard.Entities.Enums;
	using MedicalCard.Entities.Interfaces;

	public class Doctor : IEntityWithId<int>
	{
		[Key, ForeignKey("Account")]
		public int Id { get; set; }

		public virtual Account Account { get; set; }
		public String LastName { get; set; }
		public String FirstName { get; set; }
		public String MiddleName { get; set; }
		public DateTime BirthDate { get; set; }
		public Gender Gender { get; set; }
		public String Position { get; set; }
		public String Address { get; set; }
		public String Phone { get; set; }
		public String Email { get; set; }
		public int PhotoId { get; set; }
		public virtual Photo Photo { get; set; }

		
	}
}