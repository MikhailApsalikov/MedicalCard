using MedicalCard.BLL;
using MedicalCard.Entities;
using MedicalCard.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCard.Console
{
	class Program
	{
		static void Main(string[] args)
		{
			TestDataInitializer tdi = new TestDataInitializer();
			tdi.Initialize();

			AccountLogic al = new AccountLogic();
			DoctorLogic dl = new DoctorLogic();
		}
	}
}
