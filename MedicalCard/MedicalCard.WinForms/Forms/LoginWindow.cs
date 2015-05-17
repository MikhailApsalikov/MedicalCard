namespace MedicalCard.WinForms.Forms
{
	using System;
	using System.Linq;
	using System.Windows.Forms;
	using BLL;
	using BLL.Repositories;
	using Entities;
	using Entities.Enums;

	public partial class LoginWindow : BaseForm
	{
		private AccountRepository repository;

		public LoginWindow()
		{
			InitializeComponent();
			SetName("Авторизация");
			repository = new AccountRepository(new MedicalCardDbContext());
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var login = loginTextBox.Text;
			var password = passwordTextBox.Text;
			if (login == String.Empty)
			{
				Error("Введите логин");
				return;
			}

			if (password == String.Empty)
			{
				Error("Введите пароль");
				return;
			}

			repository = new AccountRepository(new MedicalCardDbContext());
			var account = repository.GetAll().FirstOrDefault(d => d.Username == login);
			if (account == null)
			{
				Error("Пользователя с таким логином не существует", "Пользователь не найден");
				return;
			}

			if (account.Password != password)
			{
				Error("Неверный пароль");
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
					form = new PatientMainWindow(this, account.Patient);
					break;
				}
				case Role.Doctor:
				{
					form = new DoctorMainWindow(this, account.Doctor);
					break;
				}
				case Role.Assistant:
				{
					form = new AssistantMainWindow(this, account.Assistant);
					break;
				}
			}
			form.Show();
			Hide();
			ClearTextFields();
		}

		private void ClearTextFields()
		{
			loginTextBox.Text = String.Empty;
			passwordTextBox.Text = String.Empty;
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var registration = new RegistrationWindow();
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