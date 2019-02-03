using System;
using System.Linq;
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
        [Ignore("Test of the ignore attribute")]
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

        [TestMethod]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);
            var expected = new[] { 1, 3, 5 }.OrderBy(i=> i).ToArray();

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count());

            Assert.AreEqual(1, result.ToArray()[0]);
            Assert.AreEqual(3, result.ToArray()[1]);
            Assert.AreEqual(5, result.ToArray()[2]);

            CollectionAssert.AreEquivalent(expected, result.ToArray());

            CollectionAssert.AreEqual(expected, result.OrderBy( i => i).ToArray());
            CollectionAssert.AllItemsAreUnique(result.ToArray());
        }
    }
}
