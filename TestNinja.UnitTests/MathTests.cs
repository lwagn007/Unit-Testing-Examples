using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class MathTests
    {
        private Math _math;

        [TestInitialize]
        public void Arrange()
        {
            _math = new Math();
        }

        [TestMethod]
        [DataRow(2, 1, 2)]
        [DataRow(1, 2, 2)]
        [DataRow(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Add_WhenCalled_ShouldReturnSumOfArguments()
        {
            var result = _math.Add(1, 2);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument()
        {
            var result = _math.Max(2, 1);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument()
        {
            var result = _math.Max(1, 2);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Max_ArgumentsAreEqual_ReturnTheSameArgument()
        {
            var result = _math.Max(1, 1);

            Assert.AreEqual(1, result);
        }
    }
}
