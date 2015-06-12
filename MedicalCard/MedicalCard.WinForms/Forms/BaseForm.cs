namespace MedicalCard.WinForms.Forms
{
	using System;
	using System.ComponentModel;
	using System.Windows.Forms;
	using Entities;
	using Exporter;
	using Properties;

	public class BaseForm : Form
	{
		public BaseForm()
		{
			StartPosition = FormStartPosition.CenterScreen;
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Icon = Resources.Icon;
		}

		protected void SetName(string caption)
		{
			Text = caption;
		}

		protected void Error(string message, string title = null)
		{
			if (String.IsNullOrWhiteSpace(title))
			{
				title = message;
			}

			MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		protected void Message(string message, string title = null)
		{
			if (String.IsNullOrWhiteSpace(title))
			{
				title = message;
			}

			MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		protected void OnClickCancelButton(object sender, EventArgs e)
		{
			Close();
		}

		protected void PrintNote(Note note)
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

				ExportHelper.ExportNote(note, sfd.FileName);
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

		private void InitializeComponent()
		{
			var resources = new ComponentResourceManager(typeof (BaseForm));
			SuspendLayout();
			// 
			// BaseForm
			// 
			resources.ApplyResources(this, "$this");
			Name = "BaseForm";
			ResumeLayout(false);
		}
	}
}