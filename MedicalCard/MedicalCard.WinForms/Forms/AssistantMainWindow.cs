namespace MedicalCard.WinForms.Forms
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Windows.Forms;
	using BLL;
	using BLL.Repositories;
	using Entities;
	using Entities.Enums;

	public partial class AssistantMainWindow : BaseForm
	{
		private Assistant assistant;
		private readonly LoginWindow loginWindow;
		private AssistantRepository repository = new AssistantRepository(new MedicalCardDbContext());

		public AssistantMainWindow(LoginWindow loginWindow, Assistant assistant)
		{
			this.assistant = assistant;
			this.loginWindow = loginWindow;
			InitializeComponent();
			SetName(String.Format("Лаборант " + assistant.FullName));
			UpdateAnalysisList(checkBox1.Checked);
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
			var accountDataEdit = new AssistantEditWindow(assistant);
			accountDataEdit.ShowDialog();
			assistant = new AssistantRepository(new MedicalCardDbContext()).GetById(assistant.Id);
			SetName(String.Format("Лаборант " + assistant.FullName));
		}

		private void выходИзСистемыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			loginWindow.Show();
			Hide();
		}

		private void workTimeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var workTimeWindow = new WorkTimeWindow(assistant.Account);
			workTimeWindow.ShowDialog();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			UpdateAnalysisList(checkBox1.Checked);
		}

		private void UpdateAnalysisList(bool isTodayOnly)
		{
			currentAnalysisListView.Items.Clear();
			var analysis = GetAnalysis(isTodayOnly);
			foreach (var a in analysis)
			{
				var item = new ListViewItem
				{
					Text = a.Id.ToString(),
					SubItems =
					{
						a.Patient.FullName,
						isTodayOnly
							? a.Date.ToString("HH:mm")
							: a.Date.ToString("HH:mm (dd.MM.yyyy)"),
						a.Status.GetString()
					}
				};
				currentAnalysisListView.Items.Add(item);
			}
		}

		private List<Analysis> GetAnalysis(bool isTodayOnly)
		{
			repository = new AssistantRepository(new MedicalCardDbContext());
			IEnumerable<Analysis> analyses = repository.GetById(assistant.Id).Analyses.Where(e => e.Status != AnalysisStatus.Closed);
			var now = DateTime.Now;

			if (isTodayOnly)
			{
				analyses =
					analyses.Where(
						d =>
							d.Date.Year == now.Year && d.Date.Month == now.Month && d.Date.Day == now.Day);
			}

			return analyses.OrderByDescending(e => e.Date).ToList();
		}

		private void currentDoubleClick(object sender, EventArgs e)
		{
			if (currentAnalysisListView.SelectedItems.Count != 1)
			{
				return;
			}
			int selectedId = Int32.Parse(currentAnalysisListView.SelectedItems[0].Text);

			throw new NotImplementedException();
			var examinationForm = new ExaminationForm(assistant.Account, selectedId);
			examinationForm.ShowDialog();

			UpdateAnalysisList(checkBox1.Checked);
		}
	}
}