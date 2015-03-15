﻿namespace MedicalCard.Models
{
	using System;
	using Entities.Interfaces;

	public class AccountModel : IEntityWithId<int>
	{
		public int Id { get; set; }

		public string Username { get; set; }

		public string Password { get; set; }

		public int Role { get; set; }
	}
}