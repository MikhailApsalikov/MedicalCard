using System.ComponentModel;

namespace MedicalCard.Models.Filters
{
	public class BaseFilterQuery
	{
		// TODO move this parameters in configure file
		public static readonly int DefaultPage = 1;
		public static readonly int DefaultPageSize = 10;

		/// <summary>
		///     Current page
		/// </summary>
		public int? Page { get; set; }

		/// <summary>
		///     Current page size
		/// </summary>
		public int? PageSize { get; set; }

		/// <summary>
		///     SortDirection
		/// </summary>
		public ListSortDirection? SortDirection { get; set; }

		/// <summary>
		///     Sort field
		/// </summary>
		public string SortField { get; set; }

		/// <summary>
		///     Check filter params, and if this one is incorrect set to default values;
		/// </summary>
		public void CheckAndFixFilterParams()
		{
			if (Page <= 0)
			{
				Page = DefaultPage;
			}
			if (PageSize <= 0)
			{
				PageSize = DefaultPageSize;
			}
		}

		public bool IsFilterSpecified()
		{
			return Page.HasValue;
		}
	}
}