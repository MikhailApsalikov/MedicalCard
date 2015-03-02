using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCard.Entities
{
	public class Patient:User
	{
		public String Snils { get; set; }

		public String InsurancePolicy { get; set; }
	}
}
