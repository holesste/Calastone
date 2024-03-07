
namespace Assignment.Classes
{
    public class UnsupportedTextFilter : TextFilter
    {
        public UnsupportedTextFilter(string pattern, string description = "") : base(pattern, description)
        {
        }

        public override string Apply(string strIn) 
        {
            return strIn;
        }
    }
}
