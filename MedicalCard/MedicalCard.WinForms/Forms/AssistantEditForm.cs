namespace MedicalCard.WinForms.Forms
{
	using System;
	using System.Data.Entity.Validation;
	using BLL;
	using BLL.Repositories;
	using Common.Extensions;
	using Entities;
	using Entities.Enums;

	public partial class AssistantEditForm : BaseForm
	{
		private readonly Assistant assistant;
		private readonly AssistantRepository repository = new AssistantRepository(new MedicalCardDbContext());

		public AssistantEditForm(Assistant assistant)
		{
			this.assistant = repository.GetById(assistant.Id);
			InitializeComponent();
			SetName("Редактирование данных лаборанта");
			InitComboBoxes();
			SetValues();
		}

		private void InitComboBoxes()
		{
			GenderComboBox.SelectedIndex = 0;
		}

		private void SetValues()
		{
			addressTextBox.Text = assistant.Address;
			birthDateTimePicker.Value = assistant.BirthDate ?? DateTime.Now;
			emailTextBox.Text = assistant.Email;
			firstNameTextBox.Text = assistant.FirstName;
			GenderComboBox.SelectedIndex = (int) assistant.Gender;
			lastNameTextBox.Text = assistant.LastName;
			middleNameTextBox.Text = assistant.MiddleName;
			phoneTextBox.Text = assistant.Phone;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (passwordTextBox.Text != passwordTextBox2.Text)
			{
				Error("Введенные пароли не совпадают");
				return;
			}

			try
			{
				assistant.Account.Password = passwordTextBox.Text;
				repository.SaveChanges();
				Message("Пароль успешно изменен");
			}
			catch (DbEntityValidationException exception)
			{
				Error(String.Format("Обнаружены ошибки:{0}{1}", Environment.NewLine, exception.GetErrorMessage()),
					"Некорректные данные");
			}
			catch (Exception exception)
			{
				while (exception.InnerException != null)
				{
					exception = exception.InnerException;
				}
				Error(exception.Message, "Ошибка");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				assistant.Address = addressTextBox.Text;
				assistant.BirthDate = birthDateTimePicker.Value;
				assistant.Email = emailTextBox.Text;
				assistant.FirstName = firstNameTextBox.Text;
				assistant.Gender = (Gender) GenderComboBox.SelectedIndex;
				assistant.LastName = lastNameTextBox.Text;
				assistant.MiddleName = middleNameTextBox.Text;
				assistant.Phone = phoneTextBox.Text;

				repository.SaveChanges();
				Message("Данные успешно обновлены");
				Close();
			}
			catch (DbEntityValidationException exception)
			{
				Error(String.Format("Обнаружены ошибки при заполнении:{0}{1}", Environment.NewLine, exception.GetErrorMessage()),
					"Некорректные данные");
			}
			catch (Exception exception)
			{
				while (exception.InnerException != null)
				{
					exception = exception.InnerException;
				}
				Error(exception.Message, "Ошибка");
			}
		}
	}
}