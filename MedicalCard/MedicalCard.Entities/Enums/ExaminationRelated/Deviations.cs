namespace MedicalCard.Entities.Enums.ExaminationRelated
{
	using System.ComponentModel;

	public enum Deviations
	{
		[Description("Норма")]
		Норма = 0,
		[Description("Отклонения в развитии")]
		Отклонения = 1
	}
}