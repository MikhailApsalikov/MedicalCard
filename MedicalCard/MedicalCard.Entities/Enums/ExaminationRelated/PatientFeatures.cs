namespace MedicalCard.Entities.Enums.ExaminationRelated
{
	using System.ComponentModel;

	public enum PatientFeatures
	{
		[Description("Без особенностей")] БезОсобенностей = 0,
		[Description("Другие ортопедические заболевания")] Ортопедические = 1,
		[Description("Другие не ортопедические заболевания")] Неортопедические = 2,
		[Description("Другие различные заболевания")] Другие = 3
	}
}