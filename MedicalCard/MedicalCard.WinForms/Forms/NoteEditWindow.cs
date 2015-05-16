namespace MedicalCard.WinForms.Forms
{
	using System;
	using System.Data.Entity.Validation;
	using BLL;
	using BLL.Repositories;
	using Common.Extensions;
	using Entities;

	public partial class NoteEditWindow : BaseForm
	{
		private readonly Doctor doctor;
		private readonly Patient patient;
		private NoteRepository repository = new NoteRepository(new MedicalCardDbContext());

		public NoteEditWindow(Patient patient, Doctor doctor)
		{
			this.patient = patient;
			this.doctor = doctor;
			InitializeComponent();
			SetName("Выписать справку");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				repository = new NoteRepository(new MedicalCardDbContext());
				var note = new Note
				{
					CreateDate = DateTime.Now,
					PatientId = patient.Id,
					DoctorId = doctor.Id,
					ExpirationDate = CalculateExpirationTime(comboBox1.Text),
					Text = textBox2.Text,
					Title = textBox1.Text
				};
				repository.Add(note);
				Message("Справка выписана. Теперь пациент сможет распечатать её.", "Справка");
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

		private DateTime CalculateExpirationTime(string text)
		{
			int days;
			if (!Int32.TryParse(text, out days))
			{
				throw new ArgumentException("Длительность должна быть числом");
			}

			if (days < 1)
			{
				throw new ArgumentException("Длительность должна быть положительным числом");
			}

			return DateTime.Now.AddDays(days);
		}
	}
}