namespace MedicalCard.WinForms.Forms
{
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
		}
	}
}