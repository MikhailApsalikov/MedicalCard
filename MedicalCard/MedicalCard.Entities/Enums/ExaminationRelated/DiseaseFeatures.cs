namespace MedicalCard.Entities.Enums.ExaminationRelated
{
	using System.ComponentModel;

	public enum DiseaseFeatures
	{
		[Description("Без особенностей")] БезОсобенностей = 0,
		[Description("Сколиоз у матери")] СколиозМатери = 1,
		[Description("Стремительный рост")] СтремительныйРост = 2
	}
}