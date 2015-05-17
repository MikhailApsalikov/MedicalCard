namespace MedicalCard.Entities
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Text;
	using Enums;
	using Interfaces;

	public class Assistant : IEntityWithId<int>
	{
		public virtual Account Account { get; set; }

		[DisplayName("Фамилия")]
		[StringLength(255, ErrorMessage = "Фамилия должна иметь длину от {2} до {1} символов", MinimumLength = 3)]
		[DefaultValue("Фамилия")]
		public String LastName { get; set; }

		[DisplayName("Имя")]
		[StringLength(255, ErrorMessage = "Имя должно иметь длину от {2} до {1} символов", MinimumLength = 3)]
		[DefaultValue("Имя")]
		public String FirstName { get; set; }

		[DisplayName("Отчество")]
		public String MiddleName { get; set; }

		public DateTime? BirthDate { get; set; }
		public Gender Gender { get; set; }
		
		public String Address { get; set; }
		public String Phone { get; set; }
		public String Email { get; set; }

		[NotMapped]
		public string FullName
		{
			get { return String.Format("{0} {1} {2}", LastName, FirstName, MiddleName); }
		}

		[NotMapped]
		public string Initials
		{
			get
			{
				var sb = new StringBuilder(LastName);
				if (FirstName != null)
				{
					sb.AppendFormat(" {0}.", FirstName[0]);
				}

				if (MiddleName != null)
				{
					sb.AppendFormat(" {0}.", MiddleName[0]);
				}
				return sb.ToString();
			}
		}

		[Key, ForeignKey("Account")]
		public int Id { get; set; }
	}
}