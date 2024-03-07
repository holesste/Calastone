using System.Text.RegularExpressions;

namespace Assignment.Services
{
    public class TextFilterApplication : ITextFilterApplication
    {
        private const string TEXTINPUT = "./Input/TextInput.txt";

        private readonly ITextFilterService _textFilterService;
        private readonly IFileReaderService _fileReaderService;

        public TextFilterApplication( ITextFilterService textFilterService, IFileReaderService fileReaderService)
        {
            _textFilterService = textFilterService;
            _fileReaderService = fileReaderService;
        }
        /// <summary>
        /// 
        /// Run method of the injected application
        /// 
        /// </summary>
        public void Run()
        {
            try
            {
                var text = _fileReaderService.GetText(TEXTINPUT);
                Console.WriteLine(_textFilterService.ApplyTextFilter(text));
            }
            catch (Exception e) // report any exception to the console
            { 
                Console.WriteLine(e);
            }
        }

    }
}
