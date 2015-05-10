namespace MedicalCard.WinForms.Forms
{
	using System;
	using System.Windows.Forms;

	public class BaseForm : Form
	{
		public BaseForm()
		{
			StartPosition = FormStartPosition.CenterScreen;
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
		}

		protected void SetParameters(string caption)
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
	}
}