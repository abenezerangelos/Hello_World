using NUnit.Framework;
namespace Hello_World.Tests
{
    [TestFixture()]
    public class DateTest
    {
        [SetUp]
        public void Setup()
        {

        }



        [TestCase(2012, ExpectedResult = true)]
        [TestCase(2007, ExpectedResult = false)]
        [TestCase(1900, ExpectedResult = false)]
        [TestCase(2000, ExpectedResult = true)]
        public bool TestCase(int ayear)
        {
            Date date = new Date();
            return date.IsLeap(ayear);
        }
    }
}
