namespace MedicalCard.WinForms.Forms
{
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

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
			this.SuspendLayout();
			// 
			// BaseForm
			// 
			resources.ApplyResources(this, "$this");
			this.Name = "BaseForm";
			this.ResumeLayout(false);

		}
	}
}