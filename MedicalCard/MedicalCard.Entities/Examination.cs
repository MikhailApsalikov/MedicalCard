namespace MedicalCard.Entities
{
	using System;
	using System.ComponentModel;
	using Enums;
	using Enums.ExaminationRelated;
	using Interfaces;

	public class Examination : IEntityWithId<int>
	{
		public const int Interval = 15;
		public DateTime ExaminationDate { get; set; }
		public int PatientId { get; set; }
		public virtual Patient Patient { get; set; }
		public int DoctorId { get; set; }
		public virtual Doctor Doctor { get; set; }
		public ExaminationStatus Status { get; set; }
		public string Text { get; set; }
		public string Drugs { get; set; }
		public string Recommendations { get; set; }
		public string TraumaComment { get; set; }
		// Additional fields:
		[Description("Боли")]
		public bool Pain { get; set; }

		[Description("Локализация")]
		public Localizations Localication { get; set; }

		[Description("Визуальные жалобы")]
		public bool VisualComplaints { get; set; }

		[Description("Особенности образа жизни")]
		public LifeStyleFeatures LifeStyleFeature { get; set; }

		[Description("Особенности развития заболевания")]
		public DiseaseFeatures DiseaseFeature { get; set; }

		[Description("Особенности развития пациента")]
		public PatientFeatures PatientFeature { get; set; }

		[Description("Дата возникновения заболевания")]
		public DateTime? DiseaseOccurenceDate { get; set; }

		[Description("Причины возникновения")]
		public Causes Cause { get; set; }

		[Description("Возраст диагностирования")]
		public Ages Age { get; set; }

		[Description("Форма искривления")]
		public DiseaseForms DiseaseForm { get; set; }

		[Description("Рентген-классификация")]
		public Xrays Xray { get; set; }

		[Description("Локализация искривления")]
		public DiseaseLocalications DiseaseLocalication { get; set; }

		[Description("Деформация")]
		public Deformations Deformation { get; set; }

		[Description("Телосложение")]
		public Physiques Physiques { get; set; }

		[Description("Нарушение осанки")]
		public bool PostureViolation { get; set; }

		[Description("Положение головы")]
		public BodyPartDeviations HeadPosition { get; set; }

		[Description("Синдром плоской стопы")]
		public bool IsFlatFoot { get; set; }

		[Description("Стопы")]
		public Deviations Feet { get; set; }

		[Description("Мышечный валик")]
		public DeviationsWithDirection MuscleRoller { get; set; }

		[Description("Реберный горб")]
		public DeviationsWithDirection RibHump { get; set; }

		[Description("Пальпация")]
		public PainGrades Palpation { get; set; }

		[Description("Положение таза")]
		public BodyPartDeviations PelvisPosition { get; set; }

		[Description("Соотношение длины НК")]
		public Nks Nk { get; set; }

		[Description("Разница НК")]
		public int NkDifference { get; set; }

		[Description("Соотношение длины НК")]
		public NkFunctions NkFunction { get; set; }

		[Description("Травмы")]
		public bool Traumas { get; set; }

		[Description("ПП шейный отдел")]
		public PpPositions PpNeckPosition { get; set; }

		[Description("ПП грудной отдел")]
		public PpPositions PpChestPosition { get; set; }

		[Description("ПП поясничный отдел")]
		public PpPositions PpWaistPosition { get; set; }

		[Description("Область надплечий")]
		public Symmetries ShouldersPosition { get; set; }

		[Description("Область лопаток")]
		public Symmetries BladesPosition { get; set; }

		[Description("Область ключиц")]
		public Symmetries СollarbonePosition { get; set; }

		[Description("Треугольник талии")]
		public Symmetries WaistPosition { get; set; }

		[Description("Мышцы шеи")]
		public NeckMusculeStates NeckMuscule { get; set; }

		[Description("Соотношение длины ВК")]
		public Nks Vk { get; set; }

		[Description("Разница ВК")]
		public int VkDifference { get; set; }

		[Description("Соотношение длины ВК")]
		public NkFunctions VkFunction { get; set; }

		[Description("ДДПСМ")]
		public int Ddpsm { get; set; }

		[Description("Дата рентген-обследования")]
		public DateTime? XrayDate { get; set; }

		public int Id { get; set; }
	}
}