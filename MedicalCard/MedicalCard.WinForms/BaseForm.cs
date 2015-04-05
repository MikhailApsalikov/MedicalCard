namespace MedicalCard.WinForms
{
	using System.Windows.Forms;

	public class BaseForm : Form
	{
		protected void SetParameters(string caption)
		{
			Text = caption;
		}
	}
}