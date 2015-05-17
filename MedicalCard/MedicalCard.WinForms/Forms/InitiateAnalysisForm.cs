namespace MedicalCard.WinForms.Forms
{
	using System;
	using System.Collections.Generic;
	using System.Data.Entity.Validation;
	using System.Linq;
	using System.Text.RegularExpressions;
	using System.Windows.Forms;
	using BLL;
	using BLL.Repositories;
	using Common.Extensions;
	using Entities;
	using Entities.Enums;

	public partial class InitiateAnalysisForm : BaseForm
	{
		private Assistant selectedAssistant;
		private Dictionary<DayOfWeek, Label> workTimeLabels;
		private readonly AssistantRepository assistantRepository = new AssistantRepository(new MedicalCardDbContext());
		private readonly Doctor doctor;
		private readonly Patient patient;

		public InitiateAnalysisForm(Patient patient, Doctor doctor)
		{
			this.patient = patient;
			this.doctor = doctor;
			InitializeComponent();
			InitializeWorkTimeLabels();
			SetName("Направление на анализ");
			UpdateAssistantList();
			SelectedIndexChanged(null, null);
		}

		private void UpdateAssistantList(String filter = null)
		{
			assistantListView.Items.Clear();
			var assistants = GetAssistantsByFilter(filter);
			foreach (var assistant in assistants)
			{
				var item = new ListViewItem
				{
					Text = assistant.Id.ToString(),
					SubItems =
					{
						assistant.FullName,
						assistant.Phone
					}
				};
				assistantListView.Items.Add(item);
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

		private List<Assistant> GetAssistantsByFilter(String filter = null)
		{
			var assistants = assistantRepository.GetAll();

			if (!String.IsNullOrWhiteSpace(filter))
			{
				assistants = assistants.Where(d => d.FirstName.Contains(filter) ||
				                                   d.LastName.Contains(filter) ||
				                                   d.MiddleName.Contains(filter));
			}

			return assistants.ToList();
		}

		private void SelectedIndexChanged(object sender, EventArgs e)
		{
			if (assistantListView.SelectedItems.Count != 1)
			{
				assistantInfoGroupBox.Visible = false;
				timePickerGroupBox.Visible = false;
				selectedAssistant = null;
				return;
			}

			selectedAssistant = assistantRepository.GetById(Int32.Parse(assistantListView.SelectedItems[0].Text));
			assistantFullNameLabel.Text = selectedAssistant.FullName;
			foreach (var dayOfWeek in WorkTime.WorkDays)
			{
				var workTime = selectedAssistant.Account.WorkTimes.FirstOrDefault(wt => wt.DayOfWeek == dayOfWeek);

				workTimeLabels[dayOfWeek].Text = workTime != null
					? String.Format("{0}:00-{1}:00", workTime.Begin, workTime.End)
					: "Выходной";
			}

			assistantInfoGroupBox.Visible = true;
			timePickerGroupBox.Visible = true;
			dateTimePicker1.Value = DateTime.Now.AddDays(1);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (selectedAssistant == null)
			{
				Error("Лаборант не выбран");
				return;
			}

			if (String.IsNullOrWhiteSpace(timeComboBox.Text))
			{
				Error("Дата не выбрана");
				return;
			}

			try
			{
				var repository = new AnalysesRepository(new MedicalCardDbContext());
				var analysis = new Analysis
				{
					PatientId = patient.Id,
					AssistantId = selectedAssistant.Id,
					DoctorId = doctor.Id,
					Date = GetDate(),
					Status = AnalysisStatus.Pending,
					Name = analysisTypeTextBox.Text
				};
				repository.Add(analysis);
				repository.SaveChanges();
				Message("Вы направили пациента на анализ в " + timeComboBox.Text, "Направление на анализ");
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

		private DateTime GetDate()
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
			if (selectedAssistant == null)
			{
				SetTimeError("Лаборант не выбран");
				return;
			}

			var date = dateTimePicker1.Value;
			if (date < DateTime.Now)
			{
				SetTimeError("Запись на эту дату уже закрыта");
				return;
			}

			var workTime = selectedAssistant.Account.WorkTimes.FirstOrDefault(w => w.DayOfWeek == date.DayOfWeek);
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
			var interval = TimeSpan.FromMinutes(Analysis.Interval);
			var alreadyExist =
				selectedAssistant.Analyses.Where(e => e.Date.Year == dateTimePicker1.Value.Year &&
				                                      e.Date.Month == dateTimePicker1.Value.Month &&
				                                      e.Date.Day == dateTimePicker1.Value.Day)
					.Select(e => e.Date).ToList();


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
			UpdateAssistantList(searchTextBox.Text);
		}
	}
}