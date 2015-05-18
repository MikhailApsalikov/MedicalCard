namespace MedicalCard.Entities.Enums.ExaminationRelated
{
	using System.ComponentModel;

	public enum Causes
	{
		[Description("Врожденный")] Врожденный = 0,
		[Description("Морфологический")] Морфологический = 1,
		[Description("Идеопатический")] Идеопатический = 2
	}
}