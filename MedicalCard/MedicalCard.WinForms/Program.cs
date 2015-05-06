namespace MedicalCard.WinForms
{
	using System;
	using System.Data.Entity;
	using System.Windows.Forms;
	using BLL;
	using Forms;

	internal static class Program
	{
		/// <summary>
		///     The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Database.SetInitializer(new TestDataInitializer());
			Application.Run(new LoginWindow());
		}
	}
}