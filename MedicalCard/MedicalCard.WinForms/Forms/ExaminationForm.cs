namespace MedicalCard.WinForms.Forms
{
	using System;
	using BLL;
	using BLL.Repositories;
	using Entities;
	using Entities.Enums;

	//TODO: анализы
	//TODO: предыдущие осмотры
	//TODO: справки
	//TODO: экспорт
	public partial class ExaminationForm : BaseForm
	{
		private Account currentAccount;
		private readonly Role currentRole;
		private readonly Examination examination;
		private readonly ExaminationRepository repository = new ExaminationRepository(new MedicalCardDbContext());

		public ExaminationForm(Account currentAccount, int examinationId)
		{
			examination = repository.GetById(examinationId);
			this.currentAccount = currentAccount;
			currentRole = currentAccount.Role;
			InitializeComponent();
			SetParameters(String.Format("Осмотр пациента " + examination.Patient.FullName));
			label3.Text = examination.Status.GetString();
			InitGroupBoxes();
			InitFields();
			SetInprogressStatusIfItIsDoctor();
		}

		private void InitFields()
		{
			textBox1.Text = examination.Text;
		}

		private void InitGroupBoxes()
		{
			doctorActionsGroupBox.Visible = currentRole == Role.Doctor;
		}

		private void SetInprogressStatusIfItIsDoctor()
		{
			if (currentRole == Role.Doctor && examination.Status == ExaminationStatus.Pending)
			{
				SetExaminationStatus(ExaminationStatus.InProgress);
			}
		}

		public void SetExaminationStatus(ExaminationStatus newStatus)
		{
			examination.Status = newStatus;
			repository.SaveChanges();
			label3.Text = examination.Status.GetString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			examination.Text = textBox1.Text;
			SetExaminationStatus(ExaminationStatus.Closed);
			Message("Осмотр успешно завершен. Теперь вы не можете его редактировать", "Осмотр завершен");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			examination.Text = textBox1.Text;
			repository.SaveChanges();
			Message("Изменения сохранены");
		}
	}
}