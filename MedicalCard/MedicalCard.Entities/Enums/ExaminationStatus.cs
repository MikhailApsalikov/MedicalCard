namespace MedicalCard.Entities.Enums
{
	using System.ComponentModel;

	public enum ExaminationStatus
	{
		[Description("Ожидание врача")] Pending = 0,
		[Description("Заполнение данных осмотра")] InProgress = 1,
		[Description("Закрыт")] Closed = 2
	}
}