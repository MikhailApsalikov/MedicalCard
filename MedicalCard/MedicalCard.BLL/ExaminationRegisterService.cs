namespace MedicalCard.BLL
{
	using System;
	using System.Collections.Generic;
	using Entities;

	public class ExaminationRegisterService
	{
		private const int WorkDayStart = 9;
		private const int WorkDayEnd = 17;
		private const int Interval = 15;

		public static IEnumerable<DateTime> GetAvailableTimes(Doctor doctor, DateTime date)
		{
			var dt = new DateTime(date.Year, date.Month, date.Day, WorkDayStart, 0, 0, 0);

			while (dt.Hour < WorkDayEnd)
			{
				yield return dt;
				dt = dt.AddMinutes(Interval);
			}
		}
	}
}