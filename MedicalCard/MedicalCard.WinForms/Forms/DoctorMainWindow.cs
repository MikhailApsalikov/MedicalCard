namespace MedicalCard.WinForms.Forms
{
	using System;
	using System.Windows.Forms;
	using Entities;
	using MedicalCard.BLL;
	using MedicalCard.BLL.Repositories;

	public partial class DoctorMainWindow : BaseForm
	{
		private Doctor doctor;
		private readonly LoginWindow loginWindow;

		public DoctorMainWindow(LoginWindow loginWindow, Doctor doctor)
		{
			this.doctor = doctor;
			this.loginWindow = loginWindow;
			InitializeComponent();
			SetParameters(String.Format("Врач " + doctor.FullName));
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
			var accountDataEdit = new DoctorEditWindow(doctor);
			accountDataEdit.ShowDialog();
			doctor = new DoctorRepository(new MedicalCardDbContext()).GetById(doctor.Id);
			SetParameters(String.Format("Врач " + doctor.FullName));
		}

		private void выходИзСистемыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			loginWindow.Show();
			Hide();
		}
	}
}