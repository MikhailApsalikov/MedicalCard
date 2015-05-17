namespace MedicalCard.WinForms.Forms
{
	using System;
	using System.Linq;
	using System.Windows.Forms;
	using BLL;
	using BLL.Repositories;
	using Entities;

	public partial class AnalysisListForm : BaseForm
	{
		private Patient patient;
		private readonly Account currentAccount;

		public AnalysisListForm(Account currentAccount, Patient patient)
		{
			this.currentAccount = currentAccount;
			this.patient = patient;
			InitializeComponent();
			SetName("Анализы");
			UpdateList();
		}

		private void UpdateList()
		{
			patient = new PatientRepository(new MedicalCardDbContext()).GetById(patient.Id);
			var history =
				patient.Analyses
					.OrderByDescending(x => x.Date)
					.ToList();

			historyListView.Items.Clear();

			foreach (var a in history)
			{
				var item = new ListViewItem
				{
					Text = a.Id.ToString(),
					SubItems =
					{
						a.Name,
						a.Assistant.FullName,
						a.Date.ToString("dd.MM.yyyy HH:mm"),
						a.Status.GetString()
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
			var analysisForm = new AnalysisForm(currentAccount, selectedId);
			analysisForm.ShowDialog();
			UpdateList();
		}
	}
}