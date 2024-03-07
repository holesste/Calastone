using Assignment.Classes;
namespace Assignment.Tests
{
    public class TextFilterType1Tests
    {
        ITextFilter tft;

        [SetUp]
        public void Setup()
        {
            tft = TextFilterFactory.CreateFilter(TextFilterType.Filter1);
        }

        [TestCase("Hello World", "Hello World")]
        [TestCase("Hello Tom", "Hello ")]
        [TestCase("Here I am", "  ")]
        [TestCase("1 2 3","1 2 3")]
        [TestCase("I am 22 years old.", "  22  old.")]

        public void ApplyTest(string strIn, string strExp) 
        {
            Assert.AreEqual(strExp, tft.Apply(strIn), $"Filter 1 applied to '{strIn}' expected '{strExp}'.");
        }
        
        
    }
}