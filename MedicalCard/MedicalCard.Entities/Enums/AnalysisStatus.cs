namespace MedicalCard.Entities.Enums
{
	using System.ComponentModel;

	public enum AnalysisStatus
	{
		[Description("Зарегистрирован")] Pending = 0,
		[Description("Заполнение данных")] InProgress = 1,
		[Description("Закрыт")] Closed = 2,
	}
}