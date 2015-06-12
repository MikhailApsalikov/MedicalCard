namespace MedicalCard.WinForms.Forms
{
	using System;
	using System.Linq;
	using System.Windows.Forms;
	using BLL;
	using BLL.Repositories;
	using Entities;

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
			var note = currentNote;
			PrintNote(note);
		}
	}
}