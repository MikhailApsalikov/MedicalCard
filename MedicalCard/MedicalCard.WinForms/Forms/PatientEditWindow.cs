namespace MedicalCard.WinForms.Forms
{
	using System;
	using System.Data.Entity.Validation;
	using System.Linq;
	using MedicalCard.BLL;
	using MedicalCard.BLL.Repositories;
	using MedicalCard.Common.Extensions;
	using MedicalCard.Entities;

	public partial class PatientEditWindow : BaseForm
	{
		private readonly Patient patient;

		public PatientEditWindow(Patient patient)
		{
			this.patient = patient;
			InitializeComponent();
			SetParameters("Редактирование данных пациента");
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
				var repository =
					new AccountRepository(new MedicalCardDbContext());
				var account = repository.GetAll().FirstOrDefault(a => a.Username == patient.Account.Username);
				if (account == null)
				{
					Error("Учетной записи не существует");
					return;
				}
				account.Password = passwordTextBox.Text;
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
	}
}