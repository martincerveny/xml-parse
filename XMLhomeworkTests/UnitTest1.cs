using NUnit.Framework;
using XMLhomework;

namespace Tests
{
    public class Tests
    {

        [TestCase(@"/Users/martincerveny/RiderProjects/XMLhomework/XMLhomework/test.xml")]
        public void When_InvalidXML_Parse_Returns_True(string file)
        {
            Assert.That(XMLParse.Parse(file), Is.True);
        }
    }
}