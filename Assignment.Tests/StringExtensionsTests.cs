using Assignment.Extensions;
using System.Globalization;
namespace Assignment.Tests
{
    public class StringExtensionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("Hello","l")]
        [TestCase("Hell","el")]
        [TestCase("","")]
        [TestCase("a","a")]
        [TestCase("am","am")]
        [TestCase("here","er")]
        public void GetCentreTest(string strIn, string strExp) 
        {

            Assert.That(strExp.Equals(strIn.GetCentre()), $"Centre of '{strIn}' is '{strExp}'");
        }

        [Test]
        public void SplitToWordsLongTest() 
        {
            string strIn = "Hello World, here I am.";
            var colItems = strIn.SplitToWords();
            Assert.That(colItems.Count == 11);
            
        }

        [Test]
        public void SplitToWordsTest()
        {
            string stringIn = "a b c";
            var lOut = stringIn.SplitToWords();
            Assert.That(lOut.Count==5,"Expected collection lenght == 5");
            Assert.That(lOut.Count > 0 && "a".Equals(lOut[0]),"First Element matches 'a'");
            Assert.That(lOut.Count > 1 && " ".Equals(lOut[1]), "Second Element matches ' '");
            Assert.That(lOut.Count > 2 && "b".Equals(lOut[2]), "Third Element matches 'b'");
            Assert.That(lOut.Count > 3 && " ".Equals(lOut[3]), "Second Element matches ' '");
            Assert.That(lOut.Count > 4 && "c".Equals(lOut[4]), "Third Element matches 'c'");
        }

        [TestCase("hello", true)]
        [TestCase("h", true)]
        [TestCase(",", false)]
        [TestCase(".", false)]
        [TestCase(" ", false)]
        [TestCase("!", false)]
        [TestCase("bye", true)]
        public void IsWordTest(string stringIn, bool isWord)
        {
            Assert.That(stringIn.IsWord(), Is.EqualTo(isWord), string.Format("String '{0}' is{1} a word.",stringIn,isWord ? "":" not"));
        }
    }
}