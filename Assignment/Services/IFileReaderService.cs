namespace Assignment.Services
{
    public interface IFileReaderService
    {
       public string GetText(string filePath);

        public Task<string> GetTextAsync(string filePath);
    }
}