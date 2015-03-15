using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicalCard.Models
{
	public class EntitiesListContainer<T>
	{
		public IEnumerable<T> Items { get; set; }

		public int Page { get; set; }

		public int PageSize { get; set; }

		public int TotalItems { get; set; }
	}
}