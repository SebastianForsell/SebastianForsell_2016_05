using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uppgift3.Models;

namespace Uppgift3.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SpeedCalculator calculateSpeed = new SpeedCalculator();

            var actual = calculateSpeed.GetCurrentSpeed("15", "3");
            var expected = 5;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            SpeedCalculator calculateSpeed = new SpeedCalculator();

            var actual = calculateSpeed.GetCurrentSpeed("fem", "tvåhundra sextio fem");
            var expected = 15.32473;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            SpeedCalculator calculateSpeed = new SpeedCalculator();

            var actual = calculateSpeed.GetCurrentSpeed("666.262M", "316L");
            var expected = 0.0545454545454545;

            Assert.AreEqual(expected, actual);
        }
    }
}
