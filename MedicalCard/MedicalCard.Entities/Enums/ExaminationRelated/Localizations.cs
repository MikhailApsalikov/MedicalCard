namespace MedicalCard.Entities.Enums.ExaminationRelated
{
	using System.ComponentModel;

	public enum Localizations
	{
		[Description("Шейный отдел")] ШейныйОтдел = 0,
		[Description("Грудной отдел")] ГруднойОтдел = 1,
		[Description("Грудопоясничный отдел")] ГрудопоясничныйОтдел = 2,
		[Description("Поясничный отдел")] ПоясничныйОтдел = 3,
		[Description("Позвоночник")] Позвоночник = 4,
		[Description("Другие части тела")] ДругиеЧастиТела = 5
	}
}