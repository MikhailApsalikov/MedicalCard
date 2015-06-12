namespace MedicalCard.WinForms.Forms
{
	using System;
	using System.ComponentModel;
	using System.Windows.Forms;
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