using Assignment.Services;
namespace Assignment.Tests
{
    public class TextFilterServiceTests
    {
        ITextFilterService tfs;

        [SetUp]
        public void Setup()
        {
            tfs = new TextFilterService();
        }

        [TestCase("Hello World", "Hello World")]
        [TestCase("Hello Tom", "Hello ")]
        [TestCase("Butterfly.Tom", ".")]
        [TestCase("Tall tree", " ")]
        [TestCase("     ", "     ")]
        [TestCase("  .   ", "  .   ")]

        public void ApplyTextFilterTest(string strIn, string strExp) 
        {
            Assert.AreEqual(strExp, tfs.ApplyTextFilter(strIn), $"Test File Service applied to '{strIn}' expected '{strExp}'.");
        }
        
        
    }
}