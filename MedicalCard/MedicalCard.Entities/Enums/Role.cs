namespace MedicalCard.Entities.Enums
{
	using System.ComponentModel;

	public enum Role
	{
		[Description("Пациент")]
		Patient = 0,
		[Description("Врач")]
		Doctor = 1,
		[Description("Лаборант")]
		Assistant = 2,
	}
}