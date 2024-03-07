using Assignment.Classes;
using Assignment.Extensions;

namespace Assignment.Services
{
    public class TextFilterService : ITextFilterService
    {
        
        public TextFilterService() 
        {
            ;
        }

        /// <summary>
        /// Service method for applying the text filter onto the text
        /// </summary>
        /// <param name="text">Text to be filtered</param>
        /// <returns>filtered text</returns>
        public string ApplyTextFilter(string text)
        {
            var tf1 = TextFilterFactory.CreateFilter(TextFilterType.Filter1); 
            var tf2 = TextFilterFactory.CreateFilter(TextFilterType.Filter2); 
            var tf3 = TextFilterFactory.CreateFilter(TextFilterType.Filter3); 
            return text.ApplyTextFilter(tf1).ApplyTextFilter(tf2).ApplyTextFilter(tf3);
        }
    }
}
