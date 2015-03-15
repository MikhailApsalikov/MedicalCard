using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicalCard.Helpers
{
	internal static class CamelCasePropertyNamesConverter
	{
		private const string Seperator = ".";

		private static readonly char[] Seperators = Seperator.ToCharArray();

		internal static string ToCamelCase(string propertyName)
		{
			var tokens = GetTokens(propertyName);
			return String.Join(Seperator, tokens.Select(t => Char.IsLower(t[0]) ? t : Char.ToLower(t[0]).ToString() + t.Substring(1)));
		}

		internal static string FromCamelCase(string propertyName)
		{
			var tokens = GetTokens(propertyName);
			return String.Join(Seperator, tokens.Select(t => Char.IsLower(t[0]) ? Char.ToUpper(t[0]).ToString() + t.Substring(1) : t));
		}

		private static string[] GetTokens(string propertyName)
		{
			return propertyName.Split(Seperators);
		}
	}
}