using Assignment.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment.Classes
{
    public abstract class TextFilter : ITextFilter
    {
        private readonly string _pattern;
        private readonly string _description;
        protected TextFilter( string pattern, string description = "") {
            _pattern = pattern;
            _description = description;
        }
        
        public string Pattern { get { return _pattern;} }
        public string Description { get { return _description;} }
        public override string ToString()
        {
            return $"{this.GetType().Name}  {_pattern} {_description}.";
        }
        public virtual string Apply(string strIn) {
            
            StringBuilder sb = new StringBuilder(strIn.Length);
            if (strIn?.Length > 0 ) 
            {
                foreach (var item in strIn.SplitToWords())
                {
                    if (!item.IsWord() || !Regex.IsMatch(item,Pattern))
                    {
                        sb.Append(item);
                    }
                }

            }

            return sb.ToString();
        }
    }
}
