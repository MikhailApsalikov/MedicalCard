namespace MedicalCard.Exporter
{
	using System;
	using System.IO;
	using System.Reflection;
	using Entities;
	using Microsoft.Office.Interop.Word;

	public static class ExportHelper
	{
		public static void ExportNote(Note note, string destination)
		{
			var data = String.Format(File.ReadAllText(Path.Combine("Templates", "NoteTemplate.html")), note.Title, note.Text);
			var tempName = Path.Combine(Environment.CurrentDirectory, Guid.NewGuid() + ".html");
			File.WriteAllText(tempName, data);
			ConvertHtmlToDoc(tempName, destination);
			File.Delete(tempName);
		}

		private static void ConvertHtmlToDoc(string source, string result)
		{
			var word = new Application();
			Object oMissing = Missing.Value;
			word.Documents.Add(ref oMissing, ref oMissing, ref oMissing, ref oMissing);
			word.Visible = false;
			Object filepath = source;
			Object confirmconversion = Missing.Value;
			Object readOnly = false;
			Object saveto = result;
			Object oallowsubstitution = Missing.Value;

			var wordDoc = word.Documents.Open(ref filepath, ref confirmconversion, ref readOnly, ref oMissing,
				ref oMissing, ref oMissing, ref oMissing, ref oMissing,
				ref oMissing, ref oMissing, ref oMissing, ref oMissing,
				ref oMissing, ref oMissing, ref oMissing, ref oMissing);
			object fileFormat = WdSaveFormat.wdFormatDocumentDefault;
			wordDoc.SaveAs(ref saveto, ref fileFormat, ref oMissing, ref oMissing, ref oMissing,
				ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
				ref oMissing, ref oMissing, ref oMissing, ref oallowsubstitution, ref oMissing,
				ref oMissing);
			wordDoc.Close();
		}
	}
}