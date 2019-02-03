using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class MathTests
    {
        [TestMethod]
        public void Add_WhenCalled_ShouldReturnSumOfArguments()
        {
            Math math = new Math();

            var result = math.Add(1, 2);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument()
        {
            var math = new Math();

            var result = math.Max(2, 1);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument()
        {
            var math = new Math();

            var result = math.Max(1, 2);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Max_ArgumentsAreEqual_ReturnTheSameArgument()
        {
            var math = new Math();

            var result = math.Max(1, 1);

            Assert.AreEqual(1, result);
        }
    }
}
