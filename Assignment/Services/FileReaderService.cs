namespace Assignment.Services
{
    public class FileReaderService : IFileReaderService
    {
        public FileReaderService() 
        {
            ;
        }
        /// <summary>
        /// Method for reading content of text file
        /// </summary>
        /// <param name="filePath">path to the text file to load</param>
        /// <returns></returns>
        public string GetText(string filePath)
        {
            try
            {
                return File.ReadAllText(filePath);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return string.Empty;
            }
        }
        /// <summary>
        /// Async method for reading content of text file 
        /// </summary>
        /// <param name="filePath">path to the text file to load</param>
        /// <returns></returns>
        public async Task<string> GetTextAsync(string filePath) {

            return await File.ReadAllTextAsync(filePath);
        }
    }
}
