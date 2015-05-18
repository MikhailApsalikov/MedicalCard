namespace MedicalCard.Entities.Enums.ExaminationRelated
{
	using System.ComponentModel;

	public enum NkFunctions
	{
		[Description("Норма")]
		Норма = 0,
		[Description("Ограниченна")]
		Ограничена = 1,
		[Description("Чрезмерна")]
		Чрезмерна = 2,
	}
}