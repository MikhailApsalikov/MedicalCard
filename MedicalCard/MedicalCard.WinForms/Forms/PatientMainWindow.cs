namespace MedicalCard.WinForms.Forms
{
	using System;
	using System.Windows.Forms;
	using Entities;

	public partial class PatientMainWindow : BaseForm
	{
		private Patient patient;

		public PatientMainWindow(Patient patient)
		{
			this.patient = patient;
			InitializeComponent();
			SetParameters(String.Format("Пациент " + patient.FullName));
		}

		protected override void OnClosed(EventArgs e)
		{
			base.OnClosed(e);
			Application.Exit();
		}
	}
}