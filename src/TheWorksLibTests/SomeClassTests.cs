using NUnit.Framework;

namespace TheWorksLibTests
{
    [TestFixture]
    public class SomeClassTests
    {
        [Test]
        public void TestSomethingThatSucceeds()
        {
            var someValue = true;
            Assert.IsTrue(true);
        }
        [Test]
        public void TestSomethingThatWasCorrected()
        {
            //Assert.IsTrue(false);
            Assert.IsTrue(true);
        }
    }
}
