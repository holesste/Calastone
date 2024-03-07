using Assignment.Classes;
using System.Globalization;
namespace Assignment.Tests
{
    public class TextFilterType3Tests
    {
        ITextFilter tft;

        [SetUp]
        public void Setup()
        {
            tft = TextFilterFactory.CreateFilter(TextFilterType.Filter3);
        }

        [TestCase("Hello World", "Hello World")]
        [TestCase("Hello Tom", "Hello Tom")]
        [TestCase("Butterfly Tom", " Tom")]
        [TestCase("Tall tree", "Tall ")]
        [TestCase("tall tree", " ")]

        public void ApplyTest(string strIn, string strExp) 
        {
            Assert.AreEqual(strExp, tft.Apply(strIn), $"Filter 3 applied to '{strIn}' expected '{strExp}'.");
        }
        
        
    }
}