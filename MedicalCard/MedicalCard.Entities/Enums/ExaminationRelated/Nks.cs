namespace MedicalCard.Entities.Enums.ExaminationRelated
{
	using System.ComponentModel;

	public enum Nks
	{
		[Description("Равны")]
		Равны = 0,
		[Description("Укорочение справа")]
		Справа = 1,
		[Description("Укорочение слева")]
		Слева = 2,
	}
}