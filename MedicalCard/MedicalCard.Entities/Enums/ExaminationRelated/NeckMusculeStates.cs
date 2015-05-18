namespace MedicalCard.Entities.Enums.ExaminationRelated
{
	using System.ComponentModel;

	public enum NeckMusculeStates
	{
		[Description("Норма")] Норма = 0,
		[Description("Напряжение")] Напряжение = 1,
		[Description("Вялые")] Вялые = 2
	}
}