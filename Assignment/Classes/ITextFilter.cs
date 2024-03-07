namespace Assignment.Classes
{
    public interface ITextFilter
    {
        public string Apply(string strIn);
        public string Pattern { get; }
        public string Description { get; }
    }
}