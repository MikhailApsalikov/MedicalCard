namespace MedicalCard.WinForms.Forms
{
	using System;
	using System.Collections.Generic;
	using System.Data.Entity.Validation;
	using System.Linq;
	using System.Windows.Forms;
	using BLL;
	using BLL.Repositories;
	using Common.Extensions;
	using Entities;
	using Entities.Enums;

	public partial class Registration : BaseForm
	{
		private PositionRepository positionRepository;
		private List<Position> positions;

		public Registration()
		{
			InitializeComponent();
			SetParameters("Регистрация");
			InitRepositories();
			InitComboBoxes();
		}

		private void InitComboBoxes()
		{
			roleComboBox.SelectedIndex = 0;
			disabilityComboBox.SelectedIndex = 0;
			GenderComboBox.SelectedIndex = 0;
		}

		private void InitRepositories()
		{
			positionRepository = new PositionRepository(new MedicalCardDbContext());
			positions = positionRepository.GetAll().ToList();
		}

		private void roleComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedIndex = roleComboBox.SelectedIndex;
			patientPanel.Visible = (selectedIndex == 0);
			doctorPanel.Visible = (selectedIndex == 1);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var account = new Account
			{
				Username = loginTextBox.Text,
				Password = passwordTextBox.Text,
				Role = (Role) roleComboBox.SelectedIndex
			};
			var accountRepository = new AccountRepository(new MedicalCardDbContext());
			if (accountRepository.GetAll().FirstOrDefault(d => d.Username == account.Username) != null)
			{
				MessageBox.Show("Пользователь с таким логином уже существует", "Ошибка", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}

			try
			{
				if ((Role) roleComboBox.SelectedIndex == Role.Patient)
				{
					account.Patient = new Patient
					{
						Id = account.Id,
						Address = addressTextBox.Text,
						BirthDate = birthDateTimePicker.Value,
						Disability = (Disability) disabilityComboBox.SelectedIndex,
						DisabilityDocument = disabliltyDocumentTextBox.Text,
						Email = emailTextBox.Text,
						FirstName = firstNameTextBox.Text,
						Gender = (Gender) GenderComboBox.SelectedIndex,
						InsurancePolicy = insurancePolicyTextBox.Text,
						JobStudyPosition = positionTextBox.Text,
						LastName = lastNameTextBox.Text,
						MiddleName = middleNameTextBox.Text,
						Phone = phoneTextBox.Text,
						Snils = snilsTextBox.Text
					};

					accountRepository.Add(account);
				}

				MessageBox.Show(
					String.Format("Регистрация прошла успешно. Теперь вы можете зайти под своей учетной записью."),
					"Регистрация", MessageBoxButtons.OK,
					MessageBoxIcon.None);

				Close();
			}
			catch (DbEntityValidationException exception)
			{
				MessageBox.Show(
					String.Format("Обнаружены ошибки при заполнении:{0}{1}", Environment.NewLine, exception.GetErrorMessage()),
					"Некорректные данные", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
			catch (Exception exception)
			{
				while (exception.InnerException != null)
				{
					exception = exception.InnerException;
				}
				MessageBox.Show(exception.Message, "Ошибка",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		}
	}
}