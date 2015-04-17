namespace MedicalCard.WinForms.Forms
{
	using System;
	using MedicalCard.BLL;
	using MedicalCard.BLL.Repositories;

	public partial class Registration : BaseForm
	{
		private readonly AccountRepository accountRepository;

		public Registration()
		{
			InitializeComponent();
			SetParameters("Регистрация");
			accountRepository = new AccountRepository(new MedicalCardDbContext());
			roleComboBox.SelectedIndex = 0;
		}

		private void roleComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			int selectedIndex = roleComboBox.SelectedIndex;
			patientPanel.Visible = (selectedIndex == 0);
			doctorPanel.Visible = (selectedIndex == 1);
		}
	}
}