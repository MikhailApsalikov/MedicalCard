namespace MedicalCard.WinForms.Forms
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Windows.Forms;
	using BLL;
	using BLL.Repositories;
	using Entities;

	public partial class InitiateExaminationWindow : BaseForm
	{
		private DoctorRepository doctorRepository = new DoctorRepository(new MedicalCardDbContext());
		private Patient patient;

		public InitiateExaminationWindow(Patient patient)
		{
			this.patient = patient;
			InitializeComponent();
			SetParameters("Запись к врачу");
			UpdateDoctorList();
		}

		private void UpdateDoctorList()
		{
			doctorListView.Items.Clear();
			List<Doctor> doctors = GetDoctorsByFilter();
			foreach (var doctor in doctors)
			{
				ListViewItem item = new ListViewItem()
				{
					Text = doctor.Id.ToString(),
					SubItems =
					{
						doctor.FullName,
						doctor.Position.Name,
						doctor.Phone,
					}
				};
				doctorListView.Items.Add(item);
			}
		}

		private List<Doctor> GetDoctorsByFilter(String firstName = null, String lastName = null, String midName = null, String position = null)
		{
			IQueryable<Doctor> doctors = doctorRepository.GetAll();
			if (!String.IsNullOrWhiteSpace(firstName))
			{
				doctors = doctors.Where(d => d.FirstName.Contains(firstName));
			}

			if (!String.IsNullOrWhiteSpace(lastName))
			{
				doctors = doctors.Where(d => d.LastName.Contains(lastName));
			}

			if (!String.IsNullOrWhiteSpace(midName))
			{
				doctors = doctors.Where(d => d.MiddleName.Contains(midName));
			}

			if (!String.IsNullOrWhiteSpace(position))
			{
				doctors = doctors.Where(d => d.Position.Name.Contains(position));
			}

			return doctors.ToList();
		}
	}
}