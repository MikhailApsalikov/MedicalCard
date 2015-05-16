namespace MedicalCard.Entities
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public class WorkTime
	{
		public const int BeginDefaultTime = 9;
		public const int EndDefaultTime = 17;
		public const int MinBeginTime = 7;
		public const int MaxEndTime = 21;

		public WorkTime()
		{
		}

		public WorkTime(DayOfWeek dayOfWeek, int begin, int end)
		{
			DayOfWeek = dayOfWeek;
			Begin = begin;
			End = end;
		}

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
				return WorkDays.Select(item => new WorkTime
				{
					DayOfWeek = item,
					Begin = BeginDefaultTime,
					End = EndDefaultTime
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