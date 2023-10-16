using System.Globalization;
using System.Text.RegularExpressions;

namespace Landscaper
{
	public static class StringUtil
	{
		private static readonly Regex WhitespaceRegex = new Regex(@"\s+");
		private static readonly Regex CamelcaseToSpacesRegex = new Regex(@"(\B[A-Z]+?(?=[A-Z][^A-Z])|\B[A-Z]+?(?=[^A-Z]))");


		/// <summary>
		/// Makes a string easier to read. Removes tabs, replaces underscores with spaces, adds spaces between camel-cased words, and converts to title case
		/// </summary>
		/// <param name="input">The input string to make readable</param>
		/// <returns>The readable string</returns>
		public static string ToFriendlyString(this string input)
		{
			if (input.IsNullOrWhitespace())
				return string.Empty;

			TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

			input = input.Replace("_", " ");
			input = CamelcaseToSpacesRegex.Replace(input, " $1");
			input = textInfo.ToTitleCase(input);
			input = input.RemoveWhitespace();
			input = CamelcaseToSpacesRegex.Replace(input, " $1");

			return input;
		}

		public static bool IsNullOrWhitespace(this string input)
		{
			input = input.RemoveWhitespace();
			return string.IsNullOrEmpty(input);
		}

		public static string RemoveWhitespace(this string input)
		{
			return WhitespaceRegex.Replace(input, "");
		}
	}
}
