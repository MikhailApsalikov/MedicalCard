namespace MedicalCard.WinForms.Forms
{
	using System;
	using System.Data.Entity.Validation;
	using BLL;
	using BLL.Repositories;
	using Common.Extensions;
	using Entities;
	using Entities.Enums;

	public partial class PatientEditForm : BaseForm
	{
		private readonly Patient patient;
		private readonly PatientRepository repository = new PatientRepository(new MedicalCardDbContext());

		public PatientEditForm(Patient patient)
		{
			this.patient = repository.GetById(patient.Id);
			InitializeComponent();
			SetName("Редактирование данных пациента");
			SetValues();
		}

		private void SetValues()
		{
			addressTextBox.Text = patient.Address;
			birthDateTimePicker.Value = patient.BirthDate ?? DateTime.Now;
			disabilityComboBox.SelectedIndex = (int) patient.Disability;
			disabliltyDocumentTextBox.Text = patient.DisabilityDocument;
			emailTextBox.Text = patient.Email;
			firstNameTextBox.Text = patient.FirstName;
			GenderComboBox.SelectedIndex = (int) patient.Gender;
			insurancePolicyTextBox.Text = patient.InsurancePolicy;
			positionTextBox.Text = patient.JobStudyPosition;
			lastNameTextBox.Text = patient.LastName;
			middleNameTextBox.Text = patient.MiddleName;
			phoneTextBox.Text = patient.Phone;
			snilsTextBox.Text = patient.Snils;
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
				patient.Account.Password = passwordTextBox.Text;
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
				patient.Address = addressTextBox.Text;
				patient.BirthDate = birthDateTimePicker.Value;
				patient.Disability = (Disability) disabilityComboBox.SelectedIndex;
				patient.DisabilityDocument = disabliltyDocumentTextBox.Text;
				patient.Email = emailTextBox.Text;
				patient.FirstName = firstNameTextBox.Text;
				patient.Gender = (Gender) GenderComboBox.SelectedIndex;
				patient.InsurancePolicy = insurancePolicyTextBox.Text;
				patient.JobStudyPosition = positionTextBox.Text;
				patient.LastName = lastNameTextBox.Text;
				patient.MiddleName = middleNameTextBox.Text;
				patient.Phone = phoneTextBox.Text;
				patient.Snils = snilsTextBox.Text;
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