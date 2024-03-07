using Assignment.Classes;
using System.Text.RegularExpressions;

namespace Assignment.Extensions
{
    public static class StringExtensions
    {
        public static string ApplyTextFilter(this string textIn, ITextFilter textFilter) {
            return textFilter.Apply(textIn);
        }

        public static IList<string> SplitToWords(this string textIn)
        {
            var lReturn = new List<string>();
            var mcMatched = Regex.Matches(textIn, "\\w+|\\W");
            if (mcMatched?.Count > 0)
            { 
                foreach (Match m in mcMatched) { 
                    lReturn.Add(m.Value);
                }
            }

            return lReturn;
        }

        public static string GetCentre(this string textIn)
        {
            return (textIn == null || textIn.Length == 0) ? string.Empty :
            (textIn.Length == 1) ? textIn :
            textIn.Substring((int)(textIn.Length - 1) / 2, 2 - (int)textIn.Length % 2);
        }

        public static bool IsWord(this string strIn) 
        {
            return Regex.IsMatch(strIn, "\\w");
        }
    }
}
