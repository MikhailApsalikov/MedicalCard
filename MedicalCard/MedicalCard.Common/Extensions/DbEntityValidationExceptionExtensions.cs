using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCard.Common.Extensions
{
	using System.Data.Entity.Validation;

	public static class DbEntityValidationExceptionExtensions
	{
		public static string GetErrorMessage(this DbEntityValidationException exception)
		{
			var errorMessages = exception.EntityValidationErrors
					.SelectMany(x => x.ValidationErrors)
					.Select(x => x.ErrorMessage);

			// Join the list to a single string.
			return string.Join(Environment.NewLine, errorMessages);
		}
	}
}
