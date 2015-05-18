namespace MedicalCard.Entities.Enums.ExaminationRelated
{
	using System.ComponentModel;

	public enum PpPositions
	{
		[Description("Норма")]
		Норма = 0,
		[Description("Отклонен вправо")]
		Вправо = 1,
		[Description("Отклонен влево")]
		Влево = 2
	}
}