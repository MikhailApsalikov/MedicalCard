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
		private const int ReadOnlyWidth = 539;

		private readonly Account currentAccount;
		private readonly Role currentRole;
		private readonly Examination examination;
		private readonly ExaminationRepository repository = new ExaminationRepository(new MedicalCardDbContext());
		private bool isReadOnly;

		public ExaminationForm(Account currentAccount, int examinationId)
		{
			examination = repository.GetById(examinationId);
			this.currentAccount = currentAccount;
			currentRole = currentAccount.Role;
			InitializeComponent();
			SetName(String.Format("Осмотр пациента " + examination.Patient.FullName));
			InitReadOnlyMode();
			InitGroupBoxes();
			InitFields();
			SetInprogressStatusIfItIsDoctor();
		}

		private void InitReadOnlyMode()
		{
			isReadOnly = currentAccount.Role == Role.Patient || examination.Status == ExaminationStatus.Closed;
			if (!isReadOnly)
			{
				return;
			}

			textBox1.ReadOnly = true; 
			Width = ReadOnlyWidth;
		}

		private void InitFields()
		{
			textBox1.Text = examination.Text;
			label3.Text = examination.Status.GetString();
			label5.Text = examination.Doctor.FullName;
		}

		private void InitGroupBoxes()
		{
			doctorActionsGroupBox.Visible = !isReadOnly;
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
			Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			examination.Text = textBox1.Text;
			repository.SaveChanges();
			Message("Изменения сохранены");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			var window = new NoteEditWindow(examination.Patient, examination.Doctor);
			window.ShowDialog();
		}
	}
}