namespace MedicalCard.Entities.Enums
{
	using System.ComponentModel;

	public enum Role
	{
		[Description("Пациент")]
		Patient = 1,
		[Description("Врач")]
		Doctor = 2,
	}
}