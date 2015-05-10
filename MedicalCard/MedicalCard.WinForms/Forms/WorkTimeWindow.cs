namespace MedicalCard.WinForms.Forms
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Windows.Forms;
	using BLL;
	using BLL.Repositories;
	using Entities;

	public partial class WorkTimeWindow : BaseForm
	{
		private const int MinBegin = 7;
		private const int MaxEnd = 21;
		private const string Format = "{0}:00";
		private Dictionary<DayOfWeek, ComboBox> beginComboBoxes;
		private Dictionary<DayOfWeek, CheckBox> checkBoxes;
		private Dictionary<DayOfWeek, ComboBox> endComboBoxes;
		private readonly Doctor doctor;
		private readonly DoctorRepository repository = new DoctorRepository(new MedicalCardDbContext());

		public WorkTimeWindow(Doctor doctor)
		{
			this.doctor = repository.GetById(doctor.Id);
			InitializeComponent();
			SetParameters("Изменить часы приема");
			InitializeForm();
			SetValues(doctor.WorkTimes);
			UpdateDependencies();
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
				if (workTime == null)
				{
					checkBoxes[workDay].Checked = true;
					beginComboBoxes[workDay].Enabled = false;
					endComboBoxes[workDay].Enabled = false;
				}
				else
				{
					checkBoxes[workDay].Checked = false;
					beginComboBoxes[workDay].Enabled = true;
					endComboBoxes[workDay].Enabled = true;
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
			beginComboBox.Items.AddRange(AddRange(MinBegin, end - 1).ToArray());
			endComboBox.Items.Clear();
			endComboBox.Items.AddRange(AddRange(begin + 1, MaxEnd).ToArray());
			beginComboBox.SelectedIndex = beginComboBox.Items.IndexOf(String.Format(Format, begin));
			endComboBox.SelectedIndex = endComboBox.Items.IndexOf(String.Format(Format, end));
		}

		private void UpdateDependencies()
		{
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private IEnumerable<String> AddRange(int from, int to)
		{
			for (var i = from; i <= to; i++)
			{
				yield return String.Format(Format, i);
			}
		}
	}
}