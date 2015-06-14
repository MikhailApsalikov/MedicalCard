namespace MedicalCard.Exporter
{
	using System;
	using System.IO;
	using System.Linq;
	using System.Reflection;
	using Entities;
	using Entities.Enums.ExaminationRelated;
	using Microsoft.Office.Interop.Excel;
	using Microsoft.Office.Interop.Word;
	using WordApplication = Microsoft.Office.Interop.Word.Application;
	using ExcelApplication = Microsoft.Office.Interop.Excel.Application;
	using ExcelRange = Microsoft.Office.Interop.Excel.Range;

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
			var app = new ExcelApplication
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

		public static Examination ImportExamination(Examination examination, string destination)
		{
			var app = new ExcelApplication
			{
				Visible = false
			};
			var book = app.Workbooks.Open(destination, Missing.Value, false, Missing.Value,
				Missing.Value, Missing.Value, Missing.Value, Missing.Value,
				Missing.Value, Missing.Value, Missing.Value, Missing.Value,
				Missing.Value, Missing.Value, Missing.Value);
			var sheet = (Worksheet) book.Sheets[1];

			LoadExaminationFromExcelFile(examination, sheet);
			book.Close();
			app.Quit();
			return examination;
		}

		private static void LoadExaminationFromExcelFile(Examination examination, Worksheet sheet)
		{
			examination.Pain = ReadBoolean(sheet, 7, 3, "Да");
			examination.Localication = (Localizations) ReadEnum<Localizations>(sheet, 8, 3);
			examination.VisualComplaints = ReadBoolean(sheet, 9, 3, "Да");

			examination.LifeStyleFeature = (LifeStyleFeatures) ReadEnum<LifeStyleFeatures>(sheet, 7, 6);
			examination.DiseaseFeature = (DiseaseFeatures) ReadEnum<DiseaseFeatures>(sheet, 8, 6);
			examination.PatientFeature = (PatientFeatures) ReadEnum<PatientFeatures>(sheet, 9, 6);
			examination.DiseaseOccurenceDate = ReadDate(sheet, 10, 6);

			examination.Cause = (Causes) ReadEnum<Causes>(sheet, 12, 3);
			examination.DiseaseForm = (DiseaseForms) ReadEnum<DiseaseForms>(sheet, 13, 3);
			examination.DiseaseLocalication = (DiseaseLocalications) ReadEnum<DiseaseLocalications>(sheet, 14, 3);
			examination.Age = (Ages) ReadEnum<Ages>(sheet, 15, 3);
			examination.Xray = (Xrays) ReadEnum<Xrays>(sheet, 16, 3);
			examination.Deformation = (Deformations) ReadEnum<Deformations>(sheet, 17, 3);

			examination.Physiques = (Physiques) ReadEnum<Physiques>(sheet, 20, 3);
			examination.PostureViolation = ReadBoolean(sheet, 21, 3, "Да");
			examination.HeadPosition = (BodyPartDeviations)ReadEnum<BodyPartDeviations>(sheet, 22, 3);
			examination.IsFlatFoot = ReadBoolean(sheet, 23, 3, "Да");
			examination.Feet = (Deviations)ReadEnum<Deviations>(sheet, 24, 3);
			examination.MuscleRoller = (DeviationsWithDirection)ReadEnum<DeviationsWithDirection>(sheet, 25, 3);
			examination.RibHump = (DeviationsWithDirection)ReadEnum<DeviationsWithDirection>(sheet, 26, 3);
			examination.Palpation = (PainGrades)ReadEnum<PainGrades>(sheet, 27, 3);
			examination.PelvisPosition = (BodyPartDeviations)ReadEnum<BodyPartDeviations>(sheet, 28, 3);
			examination.Nk = (Nks)ReadEnum<Nks>(sheet, 29, 3);
			examination.NkDifference = ReadInt(sheet, 30, 3);
			examination.NkFunction = (NkFunctions)ReadEnum<NkFunctions>(sheet, 31, 3);
			examination.Traumas = ReadBoolean(sheet, 32, 3, "Да");
			examination.TraumaComment = ReadString(sheet, 33, 3);
			examination.PpNeckPosition = (PpPositions)ReadEnum<PpPositions>(sheet, 34, 3);
			examination.PpChestPosition = (PpPositions)ReadEnum<PpPositions>(sheet, 35, 3);
			examination.PpWaistPosition = (PpPositions)ReadEnum<PpPositions>(sheet, 36, 3);
			examination.ShouldersPosition = (Symmetries)ReadEnum<Symmetries>(sheet, 37, 3);
			examination.BladesPosition = (Symmetries)ReadEnum<Symmetries>(sheet, 38, 3);
			examination.СollarbonePosition = (Symmetries)ReadEnum<Symmetries>(sheet, 39, 3);
			examination.WaistPosition = (Symmetries)ReadEnum<Symmetries>(sheet, 40, 3);
			examination.NeckMuscule = (NeckMusculeStates)ReadEnum<NeckMusculeStates>(sheet, 41, 3);
			examination.Vk = (Nks)ReadEnum<Nks>(sheet, 42, 3);
			examination.VkDifference = ReadInt(sheet, 43, 3);
			examination.VkFunction = (NkFunctions)ReadEnum<NkFunctions>(sheet, 44, 3);
			examination.Ddpsm = ReadInt(sheet, 45, 3);
			examination.XrayDate = ReadDate(sheet, 46, 3);

			examination.Drugs = ReadString(sheet, 20, 6);
			examination.Recommendations = ReadString(sheet, 38, 6);
		}

		private static int ReadInt(Worksheet sheet, int row, int column)
		{
			return (int)((ExcelRange)sheet.Cells[row, column]).Value;
		}

		private static DateTime? ReadDate(Worksheet sheet, int row, int column)
		{
			return ((ExcelRange) sheet.Cells[row, column]).Value as DateTime?;
		}

		private static bool ReadBoolean(Worksheet sheet, int row, int column, string trueValue)
		{
			return ((string) ((ExcelRange) sheet.Cells[row, column]).Value == trueValue);
		}

		private static string ReadString(Worksheet sheet, int row, int column)
		{
			return (string) ((ExcelRange) sheet.Cells[row, column]).Value;
		}

		private static Enum ReadEnum<T>(Worksheet sheet, int row, int column) where T : new()
		{
			var description = ReadString(sheet, row, column);
			var e = new T() as Enum;
			if (e == null)
			{
				throw new ArgumentException();
			}

			var result = Enum.GetValues(e.GetType()).Cast<Enum>().First(v => v.GetString() == description);

			return result;
		}

		private static void ConvertHtmlToDoc(string source, string result)
		{
			var word = new WordApplication();
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

		private static void FillExcelFile(Examination examination, Worksheet sheet)
		{
			sheet.Cells[2, 3] = examination.Patient.FullName;
			sheet.Cells[3, 3] = examination.Doctor.Initials;
			sheet.Cells[4, 3] = examination.ExaminationDate;

			sheet.Cells[7, 3] = examination.Pain ? "Да" : "Нет";
			sheet.Cells[8, 3] = examination.Localication.GetString();
			sheet.Cells[9, 3] = examination.VisualComplaints ? "Да" : "Нет";

			sheet.Cells[7, 6] = examination.LifeStyleFeature.GetString();
			sheet.Cells[8, 6] = examination.DiseaseFeature.GetString();
			sheet.Cells[9, 6] = examination.PatientFeature.GetString();
			sheet.Cells[10, 6] = examination.DiseaseOccurenceDate;

			sheet.Cells[12, 3] = examination.Cause.GetString();
			sheet.Cells[13, 3] = examination.DiseaseForm.GetString();
			sheet.Cells[14, 3] = examination.DiseaseLocalication.GetString();
			sheet.Cells[15, 3] = examination.Age.GetString();
			sheet.Cells[16, 3] = examination.Xray.GetString();
			sheet.Cells[17, 3] = examination.Deformation.GetString();

			sheet.Cells[20, 3] = examination.Physiques.GetString();
			sheet.Cells[21, 3] = examination.PostureViolation ? "Да" : "Нет";
			sheet.Cells[22, 3] = examination.HeadPosition.GetString();
			sheet.Cells[23, 3] = examination.IsFlatFoot ? "Да" : "Нет";
			sheet.Cells[24, 3] = examination.Feet.GetString();
			sheet.Cells[25, 3] = examination.MuscleRoller.GetString();
			sheet.Cells[26, 3] = examination.RibHump.GetString();
			sheet.Cells[27, 3] = examination.Palpation.GetString();
			sheet.Cells[28, 3] = examination.PelvisPosition.GetString();
			sheet.Cells[29, 3] = examination.Nk.GetString();
			sheet.Cells[30, 3] = examination.NkDifference;
			sheet.Cells[31, 3] = examination.NkFunction.GetString();
			sheet.Cells[32, 3] = examination.Traumas ? "Да" : "Нет";
			sheet.Cells[33, 3] = examination.TraumaComment;
			sheet.Cells[34, 3] = examination.PpNeckPosition.GetString();
			sheet.Cells[35, 3] = examination.PpChestPosition.GetString();
			sheet.Cells[36, 3] = examination.PpWaistPosition.GetString();
			sheet.Cells[37, 3] = examination.ShouldersPosition.GetString();
			sheet.Cells[38, 3] = examination.BladesPosition.GetString();
			sheet.Cells[39, 3] = examination.СollarbonePosition.GetString();
			sheet.Cells[40, 3] = examination.WaistPosition.GetString();
			sheet.Cells[41, 3] = examination.NeckMuscule.GetString();
			sheet.Cells[42, 3] = examination.Vk.GetString();
			sheet.Cells[43, 3] = examination.VkDifference;
			sheet.Cells[44, 3] = examination.VkFunction.GetString();
			sheet.Cells[45, 3] = examination.Ddpsm;
			sheet.Cells[46, 3] = examination.XrayDate;

			sheet.Cells[20, 6] = examination.Drugs;
			sheet.Cells[38, 6] = examination.Recommendations;
		}
	}
}