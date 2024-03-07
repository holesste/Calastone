using Assignment.Classes;
namespace Assignment.Tests
{
    public class TextFilterType2Tests
    {
        ITextFilter tft;

        [SetUp]
        public void Setup()
        {
            tft = TextFilterFactory.CreateFilter(TextFilterType.Filter2);
        }

        [TestCase("Hello World", "Hello World")]
        [TestCase("Hello Tom", "Hello Tom")]
        [TestCase("Here I am", "Here  ")]
        [TestCase("1 2 3","  ")]
        [TestCase("I am 22 years old.", "   years old.")]

        public void ApplyTest(string strIn, string strExp) 
        {
            Assert.AreEqual(strExp, tft.Apply(strIn), $"Filter 2 applied to '{strIn}' expected '{strExp}'.");
        }
        
        
    }
}