namespace MedicalCard.WinForms.Forms
{
	using System.Linq;
	using System.Windows.Forms;
	using Entities;

	public partial class AnalysisListForm : BaseForm
	{
		private readonly Patient patient;

		public AnalysisListForm(Patient patient)
		{
			this.patient = patient;
			InitializeComponent();
			SetName("Анализы");
			UpdateList();
		}

		private void UpdateList()
		{
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
						a.Date.ToString("dd.MM.yyyy HH:mm")
					}
				};
				historyListView.Items.Add(item);
			}
		}
	}
}