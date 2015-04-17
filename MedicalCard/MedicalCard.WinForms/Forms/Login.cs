namespace MedicalCard.WinForms.Forms
{
	using System;
	using System.Linq;
	using System.Windows.Forms;
	using MedicalCard.BLL;
	using MedicalCard.BLL.Repositories;

	public partial class Login : BaseForm
	{
		private readonly AccountRepository repository;

		public Login()
		{
			InitializeComponent();
			SetParameters("Авторизация");
			repository = new AccountRepository(new MedicalCardDbContext());
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var login = loginTextBox.Text;
			var password = passwordTextBox.Text;
			if (login == String.Empty)
			{
				MessageBox.Show("Введите логин", "Введите логин", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}

			if (password == String.Empty)
			{
				MessageBox.Show("Введите пароль", "Введите пароль", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}

			var account = repository.GetAll().FirstOrDefault(d => d.Username == login);
			if (account == null)
			{
				MessageBox.Show("Пользователя с таким логином не существует", "Пользователь не найден", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}

			if (account.Password != password)
			{
				MessageBox.Show("Неверный пароль", "Неверный пароль", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}

			//OpenMainWindowForm();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var registration = new Registration();
			registration.ShowDialog();
		}
	}
}