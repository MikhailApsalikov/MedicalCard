namespace MedicalCard.Entities
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class WorkTime
	{
		[Key]
		[Column(Order = 1)] 
		public int DoctorId { get; set; }

		[Key]
		[Column(Order = 2)] 
		public DayOfWeek DayOfWeek { get; set; }

		public int Begin { get; set; }
		public int End { get; set; }
	}
}