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

	public partial class WorkTimeWindow : BaseForm
	{
		private const string Format = "{0}:00";
		private Dictionary<DayOfWeek, ComboBox> beginComboBoxes;
		private Dictionary<DayOfWeek, CheckBox> checkBoxes;
		private Dictionary<DayOfWeek, ComboBox> endComboBoxes;
		private readonly Doctor doctor;
		private readonly DoctorRepository repository;

		public WorkTimeWindow(Doctor doctor)
		{
			repository = new DoctorRepository(new MedicalCardDbContext());
			this.doctor = repository.GetById(doctor.Id);
			InitializeComponent();
			SetName("Изменить часы приема");
			InitializeForm();
			SetValues(this.doctor.WorkTimes);
		}

		private void InitializeForm()
		{
			checkBoxes = new Dictionary<DayOfWeek, CheckBox>
			{
				{DayOfWeek.Monday, checkBox1},
				{DayOfWeek.Tuesday, checkBox2},
				{DayOfWeek.Wednesday, checkBox3},
				{DayOfWeek.Thursday, checkBox4},
				{DayOfWeek.Friday, checkBox5}
			};
			beginComboBoxes = new Dictionary<DayOfWeek, ComboBox>
			{
				{DayOfWeek.Monday, mondayBegin},
				{DayOfWeek.Tuesday, comboBox2},
				{DayOfWeek.Wednesday, comboBox4},
				{DayOfWeek.Thursday, comboBox6},
				{DayOfWeek.Friday, comboBox8}
			};
			endComboBoxes = new Dictionary<DayOfWeek, ComboBox>
			{
				{DayOfWeek.Monday, comboBox1},
				{DayOfWeek.Tuesday, comboBox3},
				{DayOfWeek.Wednesday, comboBox5},
				{DayOfWeek.Thursday, comboBox7},
				{DayOfWeek.Friday, comboBox9}
			};
		}

		private void SetValues(List<WorkTime> workTimes)
		{
			foreach (var workDay in WorkTime.WorkDays)
			{
				var workTime = workTimes.FirstOrDefault(w => w.DayOfWeek == workDay);
				checkBoxes[workDay].Checked = (workTime == null);
				if (workTime != null)
				{
					SetSelection(workTime.Begin, workTime.End, beginComboBoxes[workDay], endComboBoxes[workDay]);
				}
			}
		}

		private void SetSelection(int begin, int end, ComboBox beginComboBox, ComboBox endComboBox)
		{
			if (begin >= end)
			{
				throw new ArgumentException("Начало часов приема должно быть раньше, чем окончание");
			}

			beginComboBox.Items.Clear();
			beginComboBox.Items.AddRange(AddRange(WorkTime.MinBeginTime, end - 1).ToArray());
			endComboBox.Items.Clear();
			endComboBox.Items.AddRange(AddRange(begin + 1, WorkTime.MaxEndTime).ToArray());
			beginComboBox.SelectedIndex = beginComboBox.Items.IndexOf(String.Format(Format, begin));
			endComboBox.SelectedIndex = endComboBox.Items.IndexOf(String.Format(Format, end));
		}

		private IEnumerable<String> AddRange(int from, int to)
		{
			for (var i = from; i <= to; i++)
			{
				yield return String.Format(Format, i);
			}
		}

		private void CheckedChanged(object s, EventArgs e)
		{
			var sender = (CheckBox) s;
			var dayOfTheWeek = checkBoxes.First(c => c.Value == sender).Key;
			beginComboBoxes[dayOfTheWeek].Enabled = !sender.Checked;
			endComboBoxes[dayOfTheWeek].Enabled = !sender.Checked;
			if (!sender.Checked)
			{
				SetSelection(WorkTime.BeginDefaultTime, WorkTime.EndDefaultTime, beginComboBoxes[dayOfTheWeek],
					endComboBoxes[dayOfTheWeek]);
			}
		}

		private void ComboBoxChanged(object s, EventArgs e)
		{
			var sender = (ComboBox) s;
			var a = beginComboBoxes.FirstOrDefault(c => c.Value == sender);
			var b = endComboBoxes.FirstOrDefault(c => c.Value == sender);
			var dayOfTheWeek = a.Value != null ? a.Key : b.Key;
			var begin = GetValueFromComboBox(beginComboBoxes[dayOfTheWeek]);
			var end = !String.IsNullOrEmpty(endComboBoxes[dayOfTheWeek].Text)
				? GetValueFromComboBox(endComboBoxes[dayOfTheWeek])
				: WorkTime.MaxEndTime;
			SetSelection(begin, end, beginComboBoxes[dayOfTheWeek], endComboBoxes[dayOfTheWeek]);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				doctor.WorkTimes.Clear();
				foreach (var dayOfWeek in WorkTime.WorkDays)
				{
					if (!checkBoxes[dayOfWeek].Checked)
					{
						doctor.WorkTimes.Add(new WorkTime
						{
							DayOfWeek = dayOfWeek,
							Begin = GetValueFromComboBox(beginComboBoxes[dayOfWeek]),
							End = GetValueFromComboBox(endComboBoxes[dayOfWeek])
						});
					}
				}
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

		private int GetValueFromComboBox(ComboBox dayOfTheWeek)
		{
			return Int32.Parse(Regex.Match(dayOfTheWeek.Text, "(\\d+):00").Groups[1].Value);
		}
	}
}