namespace MedicalCard.WinForms.Forms
{
	using System;
	using System.Collections.Generic;
	using System.Data.Entity.Validation;
	using System.Drawing;
	using System.IO;
	using System.Linq;
	using System.Text.RegularExpressions;
	using System.Windows.Forms;
	using BLL;
	using BLL.Repositories;
	using Common.Extensions;
	using Entities;
	using Entities.Enums;
	using Properties;

	public partial class InitiateExaminationForm : BaseForm
	{
		private Doctor selectedDoctor;
		private Dictionary<DayOfWeek, Label> workTimeLabels;
		private readonly DoctorRepository doctorRepository = new DoctorRepository(new MedicalCardDbContext());
		private readonly Patient patient;

		public InitiateExaminationForm(Patient patient)
		{
			this.patient = patient;
			InitializeComponent();
			InitializeWorkTimeLabels();
			SetName("Запись к врачу");
			UpdateDoctorList();
			SelectedIndexChanged(null, null);
		}

		private void UpdateDoctorList(String filter = null)
		{
			doctorListView.Items.Clear();
			var doctors = GetDoctorsByFilter(dateFilter.Value, filter);
			foreach (var doctor in doctors)
			{
				var item = new ListViewItem
				{
					Text = doctor.Id.ToString(),
					SubItems =
					{
						doctor.FullName,
						doctor.Position.Name,
						doctor.Phone
					}
				};
				doctorListView.Items.Add(item);
			}
		}

		private void InitializeWorkTimeLabels()
		{
			workTimeLabels = new Dictionary<DayOfWeek, Label>
			{
				{DayOfWeek.Monday, label3},
				{DayOfWeek.Tuesday, label5},
				{DayOfWeek.Wednesday, label7},
				{DayOfWeek.Thursday, label9},
				{DayOfWeek.Friday, label12}
			};
		}

		private List<Doctor> GetDoctorsByFilter(DateTime date, String filter = null)
		{
			List<Doctor> doctors = doctorRepository.GetAll().Where(d => d.Account.WorkTimes.Any(wt => wt.DayOfWeek == date.DayOfWeek)).ToList();

			if (!String.IsNullOrWhiteSpace(filter))
			{
				doctors = doctors.Where(d => d.FullName.Contains(filter) ||
											 d.Position.Name.Contains(filter)).ToList();
			}

			return doctors;
		}

		private void SelectedIndexChanged(object sender, EventArgs e)
		{
			if (doctorListView.SelectedItems.Count != 1)
			{
				doctorInfoGroupBox.Visible = false;
				timePickerGroupBox.Visible = false;
				selectedDoctor = null;
				return;
			}

			selectedDoctor = doctorRepository.GetById(Int32.Parse(doctorListView.SelectedItems[0].Text));
			doctorFullNameLabel.Text = selectedDoctor.FullName;
			positionLabel.Text = selectedDoctor.Position.Name;
			phoneLabel.Text = selectedDoctor.Phone;
			emailLabel.Text = selectedDoctor.Email;
			photoPictureBox.Image = selectedDoctor.Photo != null
				? Image.FromStream(new MemoryStream(selectedDoctor.Photo.Content))
				: Resources.DefaultPhoto;
			foreach (var dayOfWeek in WorkTime.WorkDays)
			{
				var workTime = selectedDoctor.Account.WorkTimes.FirstOrDefault(wt => wt.DayOfWeek == dayOfWeek);

				workTimeLabels[dayOfWeek].Text = workTime != null
					? String.Format("{0}:00-{1}:00", workTime.Begin, workTime.End)
					: "Выходной";
			}

			doctorInfoGroupBox.Visible = true;
			timePickerGroupBox.Visible = true;
			dateTimePicker1.Value = dateFilter.Value;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (selectedDoctor == null)
			{
				Error("Врач не выбран");
				return;
			}

			if (String.IsNullOrWhiteSpace(timeComboBox.Text))
			{
				Error("Дата не выбрана");
				return;
			}

			try
			{
				var repository = new ExaminationRepository(new MedicalCardDbContext());
				var previousExamination =
					repository.GetAll().OrderByDescending(ex => ex.ExaminationDate).FirstOrDefault(ex => ex.PatientId == patient.Id && ex.Status == ExaminationStatus.Closed);

				var examination = new Examination
				{
					PatientId = patient.Id,
					DoctorId = selectedDoctor.Id,
					ExaminationDate = GetExaminationDate(),
					Status = ExaminationStatus.Pending
				};

				if (previousExamination != null)
				{
					examination.SetValuesAs(previousExamination);
				}

				repository.Add(examination);
				repository.SaveChanges();
				Message("Вы записались к врачу на " + timeComboBox.Text, "Запись к врачу");
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

		private DateTime GetExaminationDate()
		{
			var dateTimePickerValue = dateTimePicker1.Value;
			var result = new DateTime(dateTimePickerValue.Year, dateTimePickerValue.Month, dateTimePickerValue.Day);
			var groups = Regex.Match(timeComboBox.Text, @"(\d+):(\d+)").Groups;
			var hours = Int32.Parse(groups[1].Value);
			var minutes = Int32.Parse(groups[2].Value);
			return result.AddHours(hours).AddMinutes(minutes);
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			if (selectedDoctor == null)
			{
				SetTimeError("Врач не выбран");
				return;
			}

			var date = dateTimePicker1.Value;
			if (date < DateTime.Now)
			{
				SetTimeError("Запись на эту дату уже закрыта");
				return;
			}

			var workTime = selectedDoctor.Account.WorkTimes.FirstOrDefault(w => w.DayOfWeek == date.DayOfWeek);
			if (workTime == null)
			{
				SetTimeError("Выходной");
				return;
			}

			SetAvailableTimes(workTime);
			if (timeComboBox.Items.Count == 0)
			{
				SetTimeError("Нет свободных мест");
				return;
			}

			RemoveTimeError();
		}

		private void SetAvailableTimes(WorkTime workTime)
		{
			var availableTime = new List<TimeSpan>();
			var end = TimeSpan.FromHours(workTime.End);
			var interval = TimeSpan.FromMinutes(Examination.Interval);
			var alreadyExist =
				selectedDoctor.Examinations.Where(e => e.ExaminationDate.Year == dateTimePicker1.Value.Year &&
				                                       e.ExaminationDate.Month == dateTimePicker1.Value.Month &&
				                                       e.ExaminationDate.Day == dateTimePicker1.Value.Day)
					.Select(e => e.ExaminationDate).ToList();


			for (var i = TimeSpan.FromHours(workTime.Begin); i < end; i = i.Add(interval))
			{
				if (!alreadyExist.Any(d => d.Hour == i.Hours && d.Minute == i.Minutes))
				{
					availableTime.Add(i);
				}
			}

			timeComboBox.Items.Clear();
			foreach (var time in availableTime)
			{
				timeComboBox.Items.Add(String.Format("{0}:{1}", time.Hours, time.Minutes.ToString("00")));
			}
		}

		private void SetTimeError(String text)
		{
			errorLabel.Visible = true;
			errorLabel.Text = text;
			timeComboBox.Enabled = false;
		}

		private void RemoveTimeError()
		{
			errorLabel.Visible = false;
			timeComboBox.Enabled = true;
		}

		private void FilterTextChanged(object sender, EventArgs e)
		{
			UpdateDoctorList(searchTextBox.Text);
		}

		private void dateFilter_ValueChanged(object sender, EventArgs e)
		{
			UpdateDoctorList(searchTextBox.Text);
			dateTimePicker1.Value = dateFilter.Value;
		}
	}
}