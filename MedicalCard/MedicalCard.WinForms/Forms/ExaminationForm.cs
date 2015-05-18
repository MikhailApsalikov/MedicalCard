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

	//TODO: анализы
	//TODO: экспорт
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
		}

		private void InitFields()
		{
			textBox1.Text = examination.Text;
			label3.Text = examination.Status.GetString();
			label5.Text = examination.Doctor.FullName;

			drugs.Text = examination.Drugs;
			recommendations.Text = examination.Recommendations;
			diseaseOccurenceDate.Value = examination.DiseaseOccurenceDate ?? DateTime.Now;

			painComboBox.SelectedIndex = examination.Pain?1:0;
			localizaionComboBox.SelectedIndex = (int)examination.Localication;
			visualComplaintsComboBox.SelectedIndex = examination.VisualComplaints ? 1 : 0;

			lifeStyleFeature.SelectedIndex = (int)examination.LifeStyleFeature;
			diseaseFeature.SelectedIndex = (int)examination.DiseaseFeature;
			patientFeature.SelectedIndex = (int)examination.PatientFeature;

			cause.SelectedIndex = (int)examination.Cause;
			age.SelectedIndex = (int)examination.Age;
			diseaseForm.SelectedIndex = (int)examination.DiseaseForm;
			xray.SelectedIndex = (int)examination.Xray;
			diseaseLocalication.SelectedIndex = (int)examination.DiseaseLocalication;
			deformation.SelectedIndex = (int)examination.Deformation;
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
			SaveExamination();
			SetExaminationStatus(ExaminationStatus.Closed);
			Message("Осмотр успешно завершен. Теперь вы не можете его редактировать", "Осмотр завершен");
			Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			SaveExamination();
			Message("Изменения сохранены");
		}

		private void SaveExamination()
		{
			examination.Text = textBox1.Text;

			examination.Drugs = drugs.Text;
			examination.Recommendations = recommendations.Text;
			examination.DiseaseOccurenceDate = diseaseOccurenceDate.Value;

			examination.Pain = painComboBox.SelectedIndex == 1;
			examination.Localication = (Localizations)localizaionComboBox.SelectedIndex;
			examination.VisualComplaints = visualComplaintsComboBox.SelectedIndex == 1;

			examination.LifeStyleFeature = (LifeStyleFeatures)lifeStyleFeature.SelectedIndex;
			examination.DiseaseFeature = (DiseaseFeatures)diseaseFeature.SelectedIndex;
			examination.PatientFeature = (PatientFeatures)patientFeature.SelectedIndex;

			examination.Cause = (Causes)cause.SelectedIndex;
			examination.Age = (Ages)age.SelectedIndex;
			examination.DiseaseForm = (DiseaseForms)diseaseForm.SelectedIndex;
			examination.Xray = (Xrays)xray.SelectedIndex;
			examination.DiseaseLocalication = (DiseaseLocalications)diseaseLocalication.SelectedIndex;
			examination.Deformation = (Deformations)deformation.SelectedIndex;
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