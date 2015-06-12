namespace MedicalCard.WinForms.Forms
{
	using System;
	using System.Drawing;
	using System.IO;
	using System.Windows.Forms;
	using BLL;
	using BLL.Repositories;
	using Entities;
	using Entities.Enums;

	public partial class AnalysisForm : BaseForm
	{
		private byte[] image;
		private bool isReadOnly;
		private readonly Analysis analysis;
		private readonly Account currentAccount;
		private readonly Role currentRole;
		private readonly AnalysesRepository repository = new AnalysesRepository(new MedicalCardDbContext());

		public AnalysisForm(Account currentAccount, int analysisId)
		{
			analysis = repository.GetById(analysisId);
			this.currentAccount = currentAccount;
			currentRole = currentAccount.Role;
			InitializeComponent();
			SetName("Направление на анализ: " + analysis.Name);
			InitReadOnlyMode();
			InitGroupBoxes();
			InitFields();
			SetInprogressStatusIfItIsAssistant();
		}

		private void InitReadOnlyMode()
		{
			isReadOnly = currentAccount.Role != Role.Assistant || analysis.Status == AnalysisStatus.Closed;
			if (!isReadOnly)
			{
				return;
			}

			textBox1.ReadOnly = true;
			chestDegreesTextBox.ReadOnly = true;
			neckDegreesTextBox.ReadOnly = true;
			waistDegreesTextBox.ReadOnly = true;

			chestSideComboBox.Enabled = false;
			neckSideComboBox.Enabled = false;
			waistSideComboBox.Enabled = false;
		}

		private void InitFields()
		{
			textBox1.Text = analysis.Text;
			label3.Text = analysis.Status.GetString();
			doctorLabel.Text = String.Format("{0} ({1})", analysis.Doctor.FullName, analysis.Doctor.Position.Name);
			patientLabel.Text = analysis.Patient.FullName;

			chestDegreesTextBox.Text = analysis.ChestDegrees.ToString();
			neckDegreesTextBox.Text = analysis.NeckDegrees.ToString();
			waistDegreesTextBox.Text = analysis.WaistDegrees.ToString();

			chestSideComboBox.SelectedIndex = (int) analysis.ChestSide;
			neckSideComboBox.SelectedIndex = (int) analysis.NeckSide;
			waistSideComboBox.SelectedIndex = (int) analysis.WaistSide;

			if (analysis.Photo != null)
			{
				image = analysis.Photo.Content;
				photoPictureBox.Image = Image.FromStream(new MemoryStream(image));
			}
		}

		private void InitGroupBoxes()
		{
			manageButtons.Visible = !isReadOnly;
		}

		private void SetInprogressStatusIfItIsAssistant()
		{
			if (currentRole == Role.Assistant && analysis.Status == AnalysisStatus.Pending)
			{
				SetExaminationStatus(AnalysisStatus.InProgress);
			}
		}

		public void SetExaminationStatus(AnalysisStatus newStatus)
		{
			analysis.Status = newStatus;
			repository.SaveChanges();
			label3.Text = analysis.Status.GetString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SaveAnalysis();
			SetExaminationStatus(AnalysisStatus.Closed);
			Message("Результаты анализа отправлены лечащему врачу.", "Анализ завершен");
			Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			repository.SaveChanges();
			Message("Изменения сохранены");
		}

		private void SaveAnalysis()
		{
			analysis.Text = textBox1.Text;

			try
			{
				analysis.ChestDegrees = Int32.Parse(chestDegreesTextBox.Text);
				analysis.NeckDegrees = Int32.Parse(neckDegreesTextBox.Text);
				analysis.WaistDegrees = Int32.Parse(waistDegreesTextBox.Text);

				analysis.ChestSide = (Side) chestSideComboBox.SelectedIndex;
				analysis.NeckSide = (Side) neckSideComboBox.SelectedIndex;
				analysis.WaistSide = (Side) waistSideComboBox.SelectedIndex;

				if (image != null)
				{
					analysis.Photo = new Photo
					{
						Content = image
					};
				}
			}
			catch (FormatException)
			{
				Error("Градусы должны быть целыми числами");
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			var odf = new OpenFileDialog
			{
				CheckFileExists = true,
				Filter = "Картинки|*.bmp;*.jpg;*.png;*.gif",
				Multiselect = false
			};
			if (odf.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			try
			{
				photoPictureBox.Image = Image.FromFile(odf.FileName);
				image = File.ReadAllBytes(odf.FileName);
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