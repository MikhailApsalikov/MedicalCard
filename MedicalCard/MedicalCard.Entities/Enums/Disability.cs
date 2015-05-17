namespace MedicalCard.Entities.Enums
{
	using System.ComponentModel;

	public enum Disability
	{
		[Description("Нет")] None = 0,
		[Description("Инвалидность 3-ей группы")] Third = 1,
		[Description("Инвалидность 2-ой группы")] Second = 2,
		[Description("Инвалидность 1-ой группы")] First = 3
	}
}