namespace MedicalCard.Entities.Enums.ExaminationRelated
{
	using System.ComponentModel;

	public enum LifeStyleFeatures
	{
		[Description("Без особенностей")] БезОсобенностей = 0,
		[Description("Занимается танцами")] ЗанимаетсяТанцами = 1,
		[Description("Занимается плаванием")] ЗанимаетсяПлаванием = 2,
		[Description("Занимается спортом")] ЗанимаетсяСпортом = 3,
		[Description("Играет на музыкальных инструментах")] МузыкальныеИнструменты = 4
	}
}