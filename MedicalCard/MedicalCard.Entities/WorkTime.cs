namespace MedicalCard.Entities
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public class WorkTime
	{
		private const int BeginDefaultTime = 9;
		private const int EndDefaultTime = 17;

		[Key]
		[Column(Order = 1)]
		public int DoctorId { get; set; }

		[Key]
		[Column(Order = 2)]
		public DayOfWeek DayOfWeek { get; set; }

		public int Begin { get; set; }
		public int End { get; set; }

		[NotMapped]
		public static IEnumerable<WorkTime> Default
		{
			get
			{
				return WorkDays.Select(item => new WorkTime()
				{
					DayOfWeek = item,
					Begin = BeginDefaultTime,
					End = EndDefaultTime,
				});
			}
		}

		[NotMapped]
		public static IEnumerable<DayOfWeek> WorkDays
		{
			get
			{
				return new List<DayOfWeek>
				{
					DayOfWeek.Monday,
					DayOfWeek.Tuesday,
					DayOfWeek.Wednesday,
					DayOfWeek.Thursday,
					DayOfWeek.Friday
				};
			}
		}
	}
}