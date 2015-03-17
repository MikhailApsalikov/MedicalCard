namespace MedicalCard.Entities
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using Enums;
	using Interfaces;

	public class Doctor : IEntityWithId<int>
	{
		public Doctor()
		{
			PositionId = 1;
		}

		public virtual Account Account { get; set; }
		public String LastName { get; set; }
		public String FirstName { get; set; }
		public String MiddleName { get; set; }
		public DateTime? BirthDate { get; set; }
		public Gender Gender { get; set; }
		public int PositionId { get; set; }
		public virtual Position Position { get; set; }
		public String Address { get; set; }
		public String Phone { get; set; }
		public String Email { get; set; }
		public int? PhotoId { get; set; }
		public virtual Photo Photo { get; set; }

		[Key, ForeignKey("Account")]
		public int Id { get; set; }
	}
}