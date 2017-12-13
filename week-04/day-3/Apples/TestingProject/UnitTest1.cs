using System;
using ConsoleApp1;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    public class Apples_testing
    {
        [Test]
        public void Testing()
        {
            string message = "apple";
            var AppleString = new AppleString(message);

            string output = AppleString.PrintMessage();

            Assert.AreEqual(message, output);
        }
    }
}
