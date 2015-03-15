namespace MedicalCard.Models
{
	using Entities.Enums;
	using Entities.Interfaces;

	public class AccountModel : IEntityWithId<int>
	{
		public int Id { get; set; }

		public string Username { get; set; }

		public string Password { get; set; }

		public Role Role { get; set; }
	}
}