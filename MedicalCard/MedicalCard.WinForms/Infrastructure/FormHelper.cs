namespace System
{
	using Windows.Forms;

	public static class FormHelper
	{
		public static void SetParameters(this Form form, string caption)
		{
			form.Text = caption;
		}
	}
}