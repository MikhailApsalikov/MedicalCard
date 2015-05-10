namespace MedicalCard.WinForms.Forms
{
	using System;
	using System.Windows.Forms;
	using Entities;
	using MedicalCard.BLL;
	using MedicalCard.BLL.Repositories;

	public partial class PatientMainWindow : BaseForm
	{
		private Patient patient;
		private readonly LoginWindow loginWindow;

		public PatientMainWindow(LoginWindow loginWindow, Patient patient)
		{
			this.patient = patient;
			this.loginWindow = loginWindow;
			InitializeComponent();
			SetParameters(String.Format("Пациент " + patient.FullName));
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
			patient = new PatientRepository(new MedicalCardDbContext()).GetById(patient.Id);
			SetParameters(String.Format("Пациент " + patient.FullName));
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
		}
	}
}