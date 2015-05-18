namespace MedicalCard.Entities.Enums.ExaminationRelated
{
	using System.ComponentModel;

	public enum Xrays
	{
		[Description("1 степень")] First = 0,
		[Description("2 степень")] Second = 1,
		[Description("3 степень")] Third = 2,
		[Description("4 степень")] Fourth = 3
	}
}