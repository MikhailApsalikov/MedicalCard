namespace MedicalCard.WinForms.Forms
{
	using System;
	using System.Linq;
	using System.Windows.Forms;
	using BLL;
	using BLL.Repositories;
	using Entities;
	using Entities.Enums;

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
				return;
			}

			OpenMainWindowForm(account);
		}

		private void OpenMainWindowForm(Account account)
		{
			Form form = null;
			switch (account.Role)
			{
				case Role.Patient:
				{
					form = new PatientMainWindow(account.Patient);
					break;
				}
			}
			form.Show();
			Hide();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var registration = new Registration();
			registration.ShowDialog();
		}

		private void passwordTextBox_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				button1_Click(sender, null);
			}
		}
	}
}