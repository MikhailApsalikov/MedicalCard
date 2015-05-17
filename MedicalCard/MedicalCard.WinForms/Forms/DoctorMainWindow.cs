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

	public partial class DoctorMainWindow : BaseForm
	{
		private Doctor doctor;
		private readonly LoginWindow loginWindow;
		private DoctorRepository repository = new DoctorRepository(new MedicalCardDbContext());

		public DoctorMainWindow(LoginWindow loginWindow, Doctor doctor)
		{
			this.doctor = doctor;
			this.loginWindow = loginWindow;
			InitializeComponent();
			SetName(String.Format("Врач " + doctor.FullName));
			UpdateExaminationList(checkBox1.Checked);
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
			SetName(String.Format("Врач " + doctor.FullName));
		}

		private void выходИзСистемыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			loginWindow.Show();
			Hide();
		}

		private void workTimeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var workTimeWindow = new WorkTimeWindow(doctor.Account);
			workTimeWindow.ShowDialog();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			UpdateExaminationList(checkBox1.Checked);
		}

		private void UpdateExaminationList(bool isTodayOnly)
		{
			currentExaminationListView.Items.Clear();
			var examinations = GetExaminations(isTodayOnly);
			foreach (var examination in examinations)
			{
				var item = new ListViewItem
				{
					Text = examination.Id.ToString(),
					SubItems =
					{
						examination.Patient.FullName,
						isTodayOnly
							? examination.ExaminationDate.ToString("HH:mm")
							: examination.ExaminationDate.ToString("HH:mm (dd.MM.yyyy)"),
						examination.Status.GetString()
					}
				};
				currentExaminationListView.Items.Add(item);
			}
		}

		private List<Examination> GetExaminations(bool isTodayOnly)
		{
			repository = new DoctorRepository(new MedicalCardDbContext());
			IEnumerable<Examination> examinations = repository.GetById(doctor.Id).Examinations.Where(e=>e.Status != ExaminationStatus.Closed);
			var now = DateTime.Now;

			if (isTodayOnly)
			{
				examinations =
					examinations.Where(
						d =>
							d.ExaminationDate.Year == now.Year && d.ExaminationDate.Month == now.Month && d.ExaminationDate.Day == now.Day);
			}

			return examinations.OrderByDescending(e => e.ExaminationDate).ToList();
		}

		private void currentExaminationListView_DoubleClick(object sender, EventArgs e)
		{
			if (currentExaminationListView.SelectedItems.Count != 1)
			{
				return;
			}
			int selectedId = Int32.Parse(currentExaminationListView.SelectedItems[0].Text);
			var examinationForm = new ExaminationForm(doctor.Account, selectedId);
			examinationForm.ShowDialog();

			UpdateExaminationList(checkBox1.Checked);
		}
	}
}