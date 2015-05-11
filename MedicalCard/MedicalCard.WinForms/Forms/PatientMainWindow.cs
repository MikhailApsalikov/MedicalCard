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

	public partial class PatientMainWindow : BaseForm
	{
		private Patient patient;
		private readonly LoginWindow loginWindow;

		public PatientMainWindow(LoginWindow loginWindow, Patient patient)
		{
			this.patient = patient;
			this.loginWindow = loginWindow;
			InitializeComponent();
			RefreshAllData();
		}

		protected override void OnClosed(EventArgs e)
		{
			base.OnClosed(e);
			Application.Exit();
		}

		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void редактироватьЛичныеДанныеToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var accountDataEdit = new PatientEditWindow(patient);
			accountDataEdit.ShowDialog();
			RefreshAllData();
		}

		private void выходИзСистемыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			loginWindow.Show();
			Hide();
		}

		private void записьКВрачуToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var initiateExaminationWindow = new InitiateExaminationWindow(patient);
			initiateExaminationWindow.ShowDialog();
			RefreshAllData();
		}

		private void RefreshAllData()
		{
			patient = new PatientRepository(new MedicalCardDbContext()).GetById(patient.Id);
			SetParameters(String.Format("Пациент " + patient.FullName));
			RefreshExaminationLists();
		}

		private void RefreshExaminationLists()
		{
			var examinations = patient.Examinations;
			RefreshCurrentExaminationList(examinations);
		}

		private void RefreshCurrentExaminationList(List<Examination> examinations)
		{
			var current = patient.Examinations.Where(e => e.Status != ExaminationStatus.Closed).ToList();
			if (!current.Any())
			{
				currentExaminationListView.Visible = false;
				initiateExaminationButton.Visible = true;
				initiateExaminationLabel.Visible = true;
				return;
			}

			currentExaminationListView.Visible = true;
			initiateExaminationButton.Visible = false;
			initiateExaminationLabel.Visible = false;

			foreach (var examination in current)
			{
				var item = new ListViewItem
				{
					Text = examination.Id.ToString(),
					SubItems =
					{
						examination.Doctor.Position.Name,
						examination.Doctor.FullName,
						examination.ExaminationDate.ToString("dd.MM.yyyy HH:mm"),
						examination.Status.GetString()
					}
				};
				currentExaminationListView.Items.Add(item);
			}
		}
	}
}