namespace MedicalCard.Entities.Enums.ExaminationRelated
{
	using System.ComponentModel;

	public enum DeviationsWithDirection
	{
		[Description("Нет")] Нет = 0,
		[Description("Справа")] Справа = 1,
		[Description("Слева")] Слева = 2
	}
}