namespace MedicalCard.WinForms.Forms
{
	using System;
	using BLL;
	using BLL.Repositories;
	using Entities;
	using Entities.Enums;

	public partial class AnalysisForm : BaseForm
	{
		private const int ReadOnlyWidth = 539;
		private bool isReadOnly;
		private readonly Analysis analysis;
		private readonly Account currentAccount;
		private readonly Role currentRole;
		private readonly AnalysesRepository repository = new AnalysesRepository(new MedicalCardDbContext());

		public AnalysisForm(Account currentAccount, int analysisId)
		{
			analysis = repository.GetById(analysisId);
			this.currentAccount = currentAccount;
			currentRole = currentAccount.Role;
			InitializeComponent();
			SetName("Направление на анализ: " + analysis.Name);
			InitReadOnlyMode();
			InitGroupBoxes();
			InitFields();
			SetInprogressStatusIfItIsAssistant();
		}

		private void InitReadOnlyMode()
		{
			isReadOnly = currentAccount.Role != Role.Assistant || analysis.Status == AnalysisStatus.Closed;
			if (!isReadOnly)
			{
				return;
			}

			textBox1.ReadOnly = true;
			Width = ReadOnlyWidth;
		}

		private void InitFields()
		{
			textBox1.Text = analysis.Text;
			label3.Text = analysis.Status.GetString();
			doctorLabel.Text = String.Format("{0} ({1})", analysis.Doctor.FullName, analysis.Doctor.Position.Name);
			patientLabel.Text = analysis.Patient.FullName;
		}

		private void InitGroupBoxes()
		{
			manageButtons.Visible = !isReadOnly;
		}

		private void SetInprogressStatusIfItIsAssistant()
		{
			if (currentRole == Role.Assistant && analysis.Status == AnalysisStatus.Pending)
			{
				SetExaminationStatus(AnalysisStatus.InProgress);
			}
		}

		public void SetExaminationStatus(AnalysisStatus newStatus)
		{
			analysis.Status = newStatus;
			repository.SaveChanges();
			label3.Text = analysis.Status.GetString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			analysis.Text = textBox1.Text;
			SetExaminationStatus(AnalysisStatus.Closed);
			Message("Результаты анализа отправлены лечащему врачу.", "Анализ завершен");
			Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			analysis.Text = textBox1.Text;
			repository.SaveChanges();
			Message("Изменения сохранены");
		}
	}
}