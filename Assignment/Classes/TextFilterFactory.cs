using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Classes
{
    public static class TextFilterFactory
    {
        /// <summary>
        /// Creates a TextFilter based on passed in Enum type
        /// </summary>
        /// <param name="textFilterType">TextFilterType value</param>
        /// <returns>A child of TextFilter class</returns>
        public static ITextFilter CreateFilter(TextFilterType textFilterType)
        {
            switch (textFilterType)
            {
                case TextFilterType.Filter1:
                    return new TextFilterType1(pattern: "[aeiou]+", description: "filter out all the words that contain a vowel in the middle of the word - centre 1 or 2 letters");
                    
                case TextFilterType.Filter2:
                    return new TextFilterType2(pattern: "^\\w{1,2}$", description: "filter out words that have length less than 3.");
                    
                case TextFilterType.Filter3:
                    return new TextFilterType3(pattern: ".*t.*", description: "filter out words that contain the letter 't'.");
                    
                default:
                    return new UnsupportedTextFilter(pattern: string.Empty, description: "This type of filter is not supported.");
                    
            }
        }
    }
}
