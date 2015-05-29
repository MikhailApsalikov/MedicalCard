namespace MedicalCard.WinForms.Forms
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Windows.Forms;
	using BLL;
	using BLL.Repositories;
	using Entities;
	using Entities.Enums;
	using Entities.Enums.ExaminationRelated;

	public partial class ExaminationForm : BaseForm
	{
		private bool isReadOnly;
		private readonly Account currentAccount;
		private readonly Role currentRole;
		private readonly Examination examination;
		private readonly ExaminationRepository repository = new ExaminationRepository(new MedicalCardDbContext());

		public ExaminationForm(Account currentAccount, int examinationId)
		{
			examination = repository.GetById(examinationId);
			this.currentAccount = currentAccount;
			currentRole = currentAccount.Role;
			InitializeComponent();
			SetName(String.Format("Осмотр пациента " + examination.Patient.FullName));
			InitializeEnumComboBoxes();
			InitReadOnlyMode();
			InitManageButtons();
			InitFields();
			SetInprogressStatusIfItIsDoctor();
			RefreshHistoryList(
				examination.Patient.Examinations.Where(
					e => e.ExaminationDate < examination.ExaminationDate).OrderByDescending(e => e.ExaminationDate).ToList());
		}

		private void InitializeEnumComboBoxes()
		{
			painComboBox.Items.AddRange(new[] {"Нет", "Да"});
			localizaionComboBox.Items.AddRange(Localizations.ГруднойОтдел.GetValues().ToArray());
			visualComplaintsComboBox.Items.AddRange(new[] {"Нет", "Да"});

			lifeStyleFeature.Items.AddRange(LifeStyleFeatures.БезОсобенностей.GetValues().ToArray());
			diseaseFeature.Items.AddRange(DiseaseFeatures.БезОсобенностей.GetValues().ToArray());
			patientFeature.Items.AddRange(PatientFeatures.БезОсобенностей.GetValues().ToArray());

			cause.Items.AddRange(Causes.Врожденный.GetValues().ToArray());
			age.Items.AddRange(Ages.Аделосцентный.GetValues().ToArray());
			diseaseForm.Items.AddRange(DiseaseForms.C.GetValues().ToArray());
			xray.Items.AddRange(Xrays.First.GetValues().ToArray());
			diseaseLocalication.Items.AddRange(DiseaseLocalications.Грудной.GetValues().ToArray());
			deformation.Items.AddRange(Deformations.Диспластическая.GetValues().ToArray());

			physiques.Items.AddRange(Physiques.Астеник.GetValues().ToArray());
			postureViolation.Items.AddRange(new[] {"Нет", "Да"});
			headPosition.Items.AddRange(BodyPartDeviations.Отклонения.GetValues().ToArray());
			isFlatFoot.Items.AddRange(new[] {"Нет", "Да"});
			feet.Items.AddRange(Deviations.Норма.GetValues().ToArray());
			muscleRoller.Items.AddRange(DeviationsWithDirection.Нет.GetValues().ToArray());
			ribHump.Items.AddRange(DeviationsWithDirection.Нет.GetValues().ToArray());
			palpation.Items.AddRange(PainGrades.Безболезнена.GetValues().ToArray());
			pelvisPosition.Items.AddRange(BodyPartDeviations.Отклонения.GetValues().ToArray());
			nk.Items.AddRange(Nks.Равны.GetValues().ToArray());
			nkFunction.Items.AddRange(NkFunctions.Норма.GetValues().ToArray());
			traumas.Items.AddRange(new[] {"Нет", "Да"});
			ppNeckPosition.Items.AddRange(PpPositions.Норма.GetValues().ToArray());
			ppChestPosition.Items.AddRange(PpPositions.Норма.GetValues().ToArray());
			ppWaistPosition.Items.AddRange(PpPositions.Норма.GetValues().ToArray());
			shouldersPosition.Items.AddRange(Symmetries.Симметричная.GetValues().ToArray());
			bladesPosition.Items.AddRange(Symmetries.Симметричная.GetValues().ToArray());
			collarbonePosition.Items.AddRange(Symmetries.Симметричная.GetValues().ToArray());
			waistPosition.Items.AddRange(Symmetries.Симметричная.GetValues().ToArray());
			neckMuscule.Items.AddRange(NeckMusculeStates.Норма.GetValues().ToArray());
			vk.Items.AddRange(Nks.Равны.GetValues().ToArray());
			vkFunction.Items.AddRange(NkFunctions.Норма.GetValues().ToArray());
		}

		private void InitReadOnlyMode()
		{
			isReadOnly = currentAccount.Role != Role.Doctor || examination.Status == ExaminationStatus.Closed;
			if (!isReadOnly)
			{
				return;
			}

			textBox1.ReadOnly = true;
			drugs.ReadOnly = true;
			recommendations.ReadOnly = true;
			diseaseOccurenceDate.Enabled = false;

			painComboBox.Enabled = false;
			localizaionComboBox.Enabled = false;
			visualComplaintsComboBox.Enabled = false;

			lifeStyleFeature.Enabled = false;
			diseaseFeature.Enabled = false;
			patientFeature.Enabled = false;

			cause.Enabled = false;
			age.Enabled = false;
			diseaseForm.Enabled = false;
			xray.Enabled = false;
			diseaseLocalication.Enabled = false;
			deformation.Enabled = false;

			physiques.Enabled = false;
			postureViolation.Enabled = false;
			headPosition.Enabled = false;
			isFlatFoot.Enabled = false;
			feet.Enabled = false;
			muscleRoller.Enabled = false;
			ribHump.Enabled = false;
			palpation.Enabled = false;
			pelvisPosition.Enabled = false;
			nk.Enabled = false;
			nkDifference.Enabled = false;
			nkFunction.Enabled = false;
			traumas.Enabled = false;
			traumaComment.Enabled = false;
			ppNeckPosition.Enabled = false;
			ppChestPosition.Enabled = false;
			ppWaistPosition.Enabled = false;
			shouldersPosition.Enabled = false;
			bladesPosition.Enabled = false;
			collarbonePosition.Enabled = false;
			waistPosition.Enabled = false;
			neckMuscule.Enabled = false;
			vk.Enabled = false;
			vkDifference.Enabled = false;
			vkFunction.Enabled = false;
			ddpsm.Enabled = false;
			xrayDate.Enabled = false;
		}

		private void InitFields()
		{
			textBox1.Text = examination.Text;
			label3.Text = examination.Status.GetString();
			label5.Text = examination.Doctor.FullName;

			drugs.Text = examination.Drugs;
			recommendations.Text = examination.Recommendations;
			diseaseOccurenceDate.Value = examination.DiseaseOccurenceDate ?? DateTime.Now;

			painComboBox.SelectedIndex = examination.Pain ? 1 : 0;
			localizaionComboBox.SelectedIndex = (int) examination.Localication;
			visualComplaintsComboBox.SelectedIndex = examination.VisualComplaints ? 1 : 0;

			lifeStyleFeature.SelectedIndex = (int) examination.LifeStyleFeature;
			diseaseFeature.SelectedIndex = (int) examination.DiseaseFeature;
			patientFeature.SelectedIndex = (int) examination.PatientFeature;

			cause.SelectedIndex = (int) examination.Cause;
			age.SelectedIndex = (int) examination.Age;
			diseaseForm.SelectedIndex = (int) examination.DiseaseForm;
			xray.SelectedIndex = (int) examination.Xray;
			diseaseLocalication.SelectedIndex = (int) examination.DiseaseLocalication;
			deformation.SelectedIndex = (int) examination.Deformation;

			physiques.SelectedIndex = (int) examination.Physiques;
			postureViolation.SelectedIndex = examination.PostureViolation ? 1 : 0;
			headPosition.SelectedIndex = (int) examination.HeadPosition;
			isFlatFoot.SelectedIndex = examination.IsFlatFoot ? 1 : 0;
			feet.SelectedIndex = (int) examination.Feet;
			muscleRoller.SelectedIndex = (int) examination.MuscleRoller;
			ribHump.SelectedIndex = (int) examination.RibHump;
			palpation.SelectedIndex = (int) examination.Palpation;
			pelvisPosition.SelectedIndex = (int) examination.PelvisPosition;
			nk.SelectedIndex = (int) examination.Nk;
			nkDifference.Text = examination.NkDifference.ToString();
			nkFunction.SelectedIndex = (int) examination.NkFunction;
			traumas.SelectedIndex = examination.Traumas ? 1 : 0;
			traumaComment.Text = examination.TraumaComment;
			ppNeckPosition.SelectedIndex = (int) examination.PpNeckPosition;
			ppChestPosition.SelectedIndex = (int) examination.PpChestPosition;
			ppWaistPosition.SelectedIndex = (int) examination.PpWaistPosition;
			shouldersPosition.SelectedIndex = (int) examination.ShouldersPosition;
			bladesPosition.SelectedIndex = (int) examination.BladesPosition;
			collarbonePosition.SelectedIndex = (int) examination.СollarbonePosition;
			waistPosition.SelectedIndex = (int) examination.WaistPosition;
			neckMuscule.SelectedIndex = (int) examination.NeckMuscule;
			vk.SelectedIndex = (int) examination.Vk;
			vkDifference.Text = examination.VkDifference.ToString();
			vkFunction.SelectedIndex = (int) examination.VkFunction;
			ddpsm.Text = examination.Ddpsm.ToString();
			xrayDate.Value = examination.XrayDate ?? DateTime.Now;
		}

		private void InitManageButtons()
		{
			manageButtons.Visible = !isReadOnly;
		}

		private void SetInprogressStatusIfItIsDoctor()
		{
			if (currentRole == Role.Doctor && examination.Status == ExaminationStatus.Pending)
			{
				SetExaminationStatus(ExaminationStatus.InProgress);
			}
		}

		public void SetExaminationStatus(ExaminationStatus newStatus)
		{
			examination.Status = newStatus;
			repository.SaveChanges();
			label3.Text = examination.Status.GetString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				SaveExamination();
				SetExaminationStatus(ExaminationStatus.Closed);
				Message("Осмотр успешно завершен. Теперь вы не можете его редактировать", "Осмотр завершен");
				Close();
			}
			catch (Exception exception)
			{
				while (exception.InnerException != null)
				{
					exception = exception.InnerException;
				}
				Error(exception.Message, "Ошибка");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				SaveExamination();
				Message("Изменения сохранены");
			}
			catch (Exception exception)
			{
				while (exception.InnerException != null)
				{
					exception = exception.InnerException;
				}
				Error(exception.Message, "Ошибка");
			}
		}

		private void SaveExamination()
		{
			examination.Text = textBox1.Text;

			examination.Drugs = drugs.Text;
			examination.Recommendations = recommendations.Text;
			examination.DiseaseOccurenceDate = diseaseOccurenceDate.Value;

			examination.Pain = painComboBox.SelectedIndex == 1;
			examination.Localication = (Localizations) localizaionComboBox.SelectedIndex;
			examination.VisualComplaints = visualComplaintsComboBox.SelectedIndex == 1;

			examination.LifeStyleFeature = (LifeStyleFeatures) lifeStyleFeature.SelectedIndex;
			examination.DiseaseFeature = (DiseaseFeatures) diseaseFeature.SelectedIndex;
			examination.PatientFeature = (PatientFeatures) patientFeature.SelectedIndex;

			examination.Cause = (Causes) cause.SelectedIndex;
			examination.Age = (Ages) age.SelectedIndex;
			examination.DiseaseForm = (DiseaseForms) diseaseForm.SelectedIndex;
			examination.Xray = (Xrays) xray.SelectedIndex;
			examination.DiseaseLocalication = (DiseaseLocalications) diseaseLocalication.SelectedIndex;
			examination.Deformation = (Deformations) deformation.SelectedIndex;

			examination.Physiques = (Physiques) physiques.SelectedIndex;
			examination.PostureViolation = postureViolation.SelectedIndex == 1;
			examination.HeadPosition = (BodyPartDeviations) headPosition.SelectedIndex;
			examination.IsFlatFoot = isFlatFoot.SelectedIndex == 1;
			examination.Feet = (Deviations) feet.SelectedIndex;
			examination.MuscleRoller = (DeviationsWithDirection) muscleRoller.SelectedIndex;
			examination.RibHump = (DeviationsWithDirection) ribHump.SelectedIndex;
			examination.Palpation = (PainGrades) palpation.SelectedIndex;
			examination.PelvisPosition = (BodyPartDeviations) pelvisPosition.SelectedIndex;
			examination.Nk = (Nks) nk.SelectedIndex;
			examination.NkDifference = Int32.Parse(nkDifference.Text);
			examination.NkFunction = (NkFunctions) nkFunction.SelectedIndex;
			examination.Traumas = traumas.SelectedIndex == 1;
			examination.TraumaComment = traumaComment.Text;
			examination.PpNeckPosition = (PpPositions) ppNeckPosition.SelectedIndex;
			examination.PpChestPosition = (PpPositions) ppChestPosition.SelectedIndex;
			examination.PpWaistPosition = (PpPositions) ppWaistPosition.SelectedIndex;
			examination.ShouldersPosition = (Symmetries) shouldersPosition.SelectedIndex;
			examination.BladesPosition = (Symmetries) bladesPosition.SelectedIndex;
			examination.СollarbonePosition = (Symmetries) collarbonePosition.SelectedIndex;
			examination.WaistPosition = (Symmetries) waistPosition.SelectedIndex;
			examination.NeckMuscule = (NeckMusculeStates) neckMuscule.SelectedIndex;
			examination.Vk = (Nks) vk.SelectedIndex;
			examination.VkDifference = Int32.Parse(vkDifference.Text);
			examination.VkFunction = (NkFunctions) vkFunction.SelectedIndex;
			examination.Ddpsm = Int32.Parse(ddpsm.Text);
			examination.XrayDate = xrayDate.Value;

			repository.SaveChanges();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			var window = new NoteEditForm(examination.Patient, examination.Doctor);
			window.ShowDialog();
		}

		private void RefreshHistoryList(List<Examination> history)
		{
			if (!history.Any())
			{
				historyListView.Visible = false;
				historyIsEmptyLabel.Visible = true;
				return;
			}

			historyListView.Visible = true;
			historyIsEmptyLabel.Visible = false;
			historyListView.Items.Clear();

			foreach (var ex in history)
			{
				var item = new ListViewItem
				{
					Text = ex.Id.ToString(),
					SubItems =
					{
						ex.Doctor.Position.Name,
						ex.Doctor.FullName,
						ex.ExaminationDate.ToString("dd.MM.yyyy HH:mm")
					}
				};
				historyListView.Items.Add(item);
			}
		}

		private void historyListView_DoubleClick(object sender, EventArgs e)
		{
			if (historyListView.SelectedItems.Count != 1)
			{
				return;
			}
			var selectedId = Int32.Parse(historyListView.SelectedItems[0].Text);
			var examinationForm = new ExaminationForm(currentAccount, selectedId);
			examinationForm.ShowDialog();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			var window = new InitiateAnalysisForm(examination.Patient, examination.Doctor);
			window.ShowDialog();
			// TODO: refresh analyses list
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (!examination.Patient.Analyses.Any())
			{
				Error("У пациента нет назначенных анализов. Вы можете назначить ему анализ.",
					"Анализов нет.");
				return;
			}

			var window = new AnalysisListForm(currentAccount, examination.Patient);
			window.ShowDialog();
		}
	}
}