﻿using NUnit.Framework;

namespace TheWorksLibTests
{
    [TestFixture]
    public class SomeClassTests
    {
        [Test]
        public void TestSomethingThatSucceeds()
        {
            Assert.IsTrue(true);
        }
        [Test]
        public void TestSomethingThatFails()
        {
            Assert.IsTrue(false);
        }
    }
}