namespace MedicalCard.Entities.Enums.ExaminationRelated
{
	using System.ComponentModel;

	public enum DiseaseLocalications
	{
		[Description("Шейный")] Шейный = 0,
		[Description("Грудной")] Грудной = 1,
		[Description("Поясничный")] Поясничный = 2,
		[Description("Комбинированный")] Комбинированный = 3
	}
}