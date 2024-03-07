
using Assignment.Extensions;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System.Text.RegularExpressions;
using System.Text;

namespace Assignment.Classes
{
    public class TextFilterType1 : TextFilter
    {
        public TextFilterType1(string pattern, string description = "") : base(pattern, description)
        {
        }
        public override string Apply(string strIn)
        {

            StringBuilder sb = new StringBuilder(strIn.Length);
            if (strIn?.Length > 0)
            {
                foreach (var item in strIn.SplitToWords())
                {
                    if (!item.IsWord() || !Regex.IsMatch(item.GetCentre(), Pattern,RegexOptions.IgnoreCase))
                    {
                        sb.Append(item);
                    }
                }

            }

            return sb.ToString();
        }
    }
}
