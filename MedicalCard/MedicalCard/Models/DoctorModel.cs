﻿namespace MedicalCard.Models
{
	using System;
	using Entities.Enums;
	using Entities.Interfaces;

	public class DoctorModel : IEntityWithId<int>
	{
		public String LastName { get; set; }
		public String FirstName { get; set; }
		public String MiddleName { get; set; }
		public DateTime? BirthDate { get; set; }
		public Gender Gender { get; set; }
		public int PositionId { get; set; }
		public String PositionName { get; set; }
		public String Address { get; set; }
		public String Phone { get; set; }
		public String Email { get; set; }
		public int Id { get; set; }
	}
}