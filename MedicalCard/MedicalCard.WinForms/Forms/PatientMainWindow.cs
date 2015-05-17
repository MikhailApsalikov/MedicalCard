﻿namespace MedicalCard.WinForms.Forms
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Windows.Forms;
	using BLL;
	using BLL.Repositories;
	using Entities;
	using Entities.Enums;

	public partial class PatientMainWindow : BaseForm
	{
		private Patient patient;
		private readonly LoginWindow loginWindow;

		public PatientMainWindow(LoginWindow loginWindow, Patient patient)
		{
			this.patient = patient;
			this.loginWindow = loginWindow;
			InitializeComponent();
			RefreshAllData();
		}

		protected override void OnClosed(EventArgs e)
		{
			base.OnClosed(e);
			Application.Exit();
		}

		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void редактироватьЛичныеДанныеToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var accountDataEdit = new PatientEditWindow(patient);
			accountDataEdit.ShowDialog();
			RefreshAllData();
		}

		private void выходИзСистемыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			loginWindow.Show();
			Hide();
		}

		private void записьКВрачуToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var initiateExaminationWindow = new InitiateExaminationWindow(patient);
			initiateExaminationWindow.ShowDialog();
			RefreshAllData();
		}

		private void RefreshAllData()
		{
			patient = new PatientRepository(new MedicalCardDbContext()).GetById(patient.Id);
			SetName(String.Format("Пациент " + patient.FullName));
			RefreshExaminationLists();
		}

		private void RefreshExaminationLists()
		{
			var examinations = patient.Examinations;
			RefreshCurrentExaminationList(examinations);
			RefreshHistoryList(examinations);
		}

		private void RefreshHistoryList(List<Examination> examinations)
		{
			var history = patient.Examinations.Where(e => e.Status == ExaminationStatus.Closed).OrderByDescending(x => x.ExaminationDate).ToList();

			if (!history.Any())
			{
				historyListView.Visible = false;
				historyIsEmptyLabel.Visible = true;
				return;
			}

			historyListView.Visible = true;
			historyIsEmptyLabel.Visible = false;
			historyListView.Items.Clear();

			foreach (var examination in history)
			{
				var item = new ListViewItem
				{
					Text = examination.Id.ToString(),
					SubItems =
					{
						examination.Doctor.Position.Name,
						examination.Doctor.FullName,
						examination.ExaminationDate.ToString("dd.MM.yyyy HH:mm")
					}
				};
				historyListView.Items.Add(item);
			}
		}

		private void RefreshCurrentExaminationList(List<Examination> examinations)
		{
			var current = patient.Examinations.Where(e => e.Status != ExaminationStatus.Closed).OrderByDescending(x => x.ExaminationDate).ToList();
			if (!current.Any())
			{
				currentExaminationListView.Visible = false;
				initiateExaminationButton.Visible = true;
				initiateExaminationLabel.Visible = true;
				return;
			}

			currentExaminationListView.Visible = true;
			initiateExaminationButton.Visible = false;
			initiateExaminationLabel.Visible = false;
			currentExaminationListView.Items.Clear();

			foreach (var examination in current)
			{
				var item = new ListViewItem
				{
					Text = examination.Id.ToString(),
					SubItems =
					{
						examination.Doctor.Position.Name,
						examination.Doctor.FullName,
						examination.ExaminationDate.ToString("dd.MM.yyyy HH:mm"),
						examination.Status.GetString()
					}
				};
				currentExaminationListView.Items.Add(item);
			}
		}

		private void historyListView_DoubleClick(object sender, EventArgs e)
		{
			if (historyListView.SelectedItems.Count != 1)
			{
				return;
			}
			int selectedId = Int32.Parse(historyListView.SelectedItems[0].Text);
			var examinationForm = new ExaminationForm(patient.Account, selectedId);
			examinationForm.ShowDialog();
		}

		private void моиСправкиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var window = new NoteListWindow(patient);
			window.ShowDialog();
		}
	}
}