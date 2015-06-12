namespace MedicalCard.Exporter
{
	using System;
	using System.IO;
	using System.Reflection;
	using Entities;
	using Microsoft.Office.Interop.Excel;
	using Microsoft.Office.Interop.Word;
	using Application = Microsoft.Office.Interop.Excel.Application;

	public static class ExportHelper
	{
		public static void ExportNote(Note note, string destination)
		{
			var data = String.Format(File.ReadAllText(Path.Combine("Templates", "NoteTemplate.html")), note.Title,
				note.Patient.FullName, note.Text, note.CreateDate.ToString("dd.MM.yyyy"), note.Doctor.Initials,
				note.ExpirationDate.ToString("dd.MM.yyyy"));
			var tempName = Path.Combine(Environment.CurrentDirectory, Guid.NewGuid() + ".html");
			File.WriteAllText(tempName, data);
			ConvertHtmlToDoc(tempName, destination);
			File.Delete(tempName);
		}

		public static void ExportExamination(Examination examination, string destination)
		{
			File.Copy(Path.Combine("Templates", "ExaminationTemplate.xlsx"), destination, true);
			var app = new Application
			{
				Visible = false
			};
			var book = app.Workbooks.Open(destination, Missing.Value, false, Missing.Value,
				Missing.Value, Missing.Value, Missing.Value, Missing.Value,
				Missing.Value, Missing.Value, Missing.Value, Missing.Value,
				Missing.Value, Missing.Value, Missing.Value);
			var sheet = (Worksheet) book.Sheets[1];

			FillExcelFile(examination, sheet);
			book.Save();
			book.Close();
			app.Quit();
		}

		public static Examination ImportExamination(string destination)
		{
			return null;
		}

		private static void ConvertHtmlToDoc(string source, string result)
		{
			var word = new Microsoft.Office.Interop.Word.Application();
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
			word.Quit();
		}

		private static void FillExcelFile(Examination examination, Worksheet mySheet)
		{
			mySheet.Cells[2, 3] = examination.Patient.FullName;
			mySheet.Cells[3, 3] = examination.Doctor.Initials;
			mySheet.Cells[4, 3] = examination.ExaminationDate;

			mySheet.Cells[7, 3] = examination.Pain ? "Да" : "Нет";
			mySheet.Cells[8, 3] = examination.Localication.GetString();
			mySheet.Cells[9, 3] = examination.VisualComplaints ? "Да" : "Нет";

			mySheet.Cells[7, 6] = examination.LifeStyleFeature.GetString();
			mySheet.Cells[8, 6] = examination.DiseaseFeature.GetString();
			mySheet.Cells[9, 6] = examination.PatientFeature.GetString();
			mySheet.Cells[10, 6] = examination.DiseaseOccurenceDate;

			mySheet.Cells[12, 3] = examination.Cause.GetString();
			mySheet.Cells[13, 3] = examination.DiseaseForm.GetString();
			mySheet.Cells[14, 3] = examination.DiseaseLocalication.GetString();
			mySheet.Cells[15, 3] = examination.Age.GetString();
			mySheet.Cells[16, 3] = examination.Xray.GetString();
			mySheet.Cells[17, 3] = examination.Deformation.GetString();

			mySheet.Cells[20, 3] = examination.Physiques.GetString();
			mySheet.Cells[21, 3] = examination.PostureViolation ? "Да" : "Нет";
			mySheet.Cells[22, 3] = examination.HeadPosition.GetString();
			mySheet.Cells[23, 3] = examination.IsFlatFoot ? "Да" : "Нет";
			mySheet.Cells[24, 3] = examination.Feet.GetString();
			mySheet.Cells[25, 3] = examination.MuscleRoller.GetString();
			mySheet.Cells[26, 3] = examination.RibHump.GetString();
			mySheet.Cells[27, 3] = examination.Palpation.GetString();
			mySheet.Cells[28, 3] = examination.PelvisPosition.GetString();
			mySheet.Cells[29, 3] = examination.Nk.GetString();
			mySheet.Cells[30, 3] = examination.NkDifference;
			mySheet.Cells[31, 3] = examination.NkFunction.GetString();
			mySheet.Cells[32, 3] = examination.Traumas ? "Да" : "Нет";
			mySheet.Cells[33, 3] = examination.TraumaComment;
			mySheet.Cells[34, 3] = examination.PpNeckPosition.GetString();
			mySheet.Cells[35, 3] = examination.PpChestPosition.GetString();
			mySheet.Cells[36, 3] = examination.PpWaistPosition.GetString();
			mySheet.Cells[37, 3] = examination.ShouldersPosition.GetString();
			mySheet.Cells[38, 3] = examination.BladesPosition.GetString();
			mySheet.Cells[39, 3] = examination.СollarbonePosition.GetString();
			mySheet.Cells[40, 3] = examination.WaistPosition.GetString();
			mySheet.Cells[41, 3] = examination.NeckMuscule.GetString();
			mySheet.Cells[42, 3] = examination.Vk.GetString();
			mySheet.Cells[43, 3] = examination.VkDifference;
			mySheet.Cells[44, 3] = examination.VkFunction.GetString();
			mySheet.Cells[45, 3] = examination.Ddpsm;
			mySheet.Cells[46, 3] = examination.XrayDate;

			mySheet.Cells[20, 6] = examination.Drugs;
			mySheet.Cells[38, 6] = examination.Recommendations;
		}
	}
}