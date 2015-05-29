namespace MedicalCard.WinForms.Forms
{
	using System;
	using System.Linq;
	using System.Windows.Forms;
	using BLL;
	using BLL.Repositories;
	using Entities;
	using Exporter;

	public partial class NoteListForm : BaseForm
	{
		private Note currentNote;
		private readonly Patient patient;
		private readonly NoteRepository repository = new NoteRepository(new MedicalCardDbContext());

		public NoteListForm(Patient patient)
		{
			this.patient = patient;
			InitializeComponent();
			SetName("Мои справки");
			UpdateNoteList();
			SelectedIndexChanged(null, null);
		}

		private void UpdateNoteList()
		{
			noteListView.Items.Clear();
			var notes = patient.Notes.Where(e => e.ExpirationDate > DateTime.Now).ToList();

			foreach (var note in notes)
			{
				var item = new ListViewItem
				{
					Text = note.Id.ToString(),
					SubItems =
					{
						note.Title,
						note.Doctor.FullName,
						note.Doctor.Position.Name,
						note.ExpirationDate.ToString("dd.MM.yyyy")
					}
				};
				noteListView.Items.Add(item);
			}
		}

		private void SelectedIndexChanged(object sender, EventArgs e)
		{
			if (noteListView.SelectedItems.Count != 1)
			{
				groupBox1.Visible = false;
				currentNote = null;
				return;
			}

			currentNote = repository.GetById(Int32.Parse(noteListView.SelectedItems[0].Text));

			titleLabel.Text = currentNote.Title;
			textLabel.Text = currentNote.Text;
			patientLabel.Text = currentNote.Patient.FullName;
			dateLabel.Text = "Дата " + currentNote.CreateDate.ToString("dd.MM.yyyy");
			expirationLabel.Text = "Действительна до: " + currentNote.ExpirationDate.ToString("dd.MM.yyyy");
			doctorLabel.Text = "Врач " + currentNote.Doctor.Initials;

			groupBox1.Visible = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				var sfd = new SaveFileDialog
				{
					AddExtension = true,
					Filter = "Microsoft Word (.docx)|.docx",
					DefaultExt = ".docx"
				};
				if (sfd.ShowDialog() != DialogResult.OK)
				{
					return;
				}

				ExportHelper.ExportNote(currentNote, sfd.FileName);
				Message("Справка экпортирована успешно. Теперь вы можете ее распечатать", "Справка экпортирована успешно");
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