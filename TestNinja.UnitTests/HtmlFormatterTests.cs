using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class HtmlFormatterTests
    {
        [TestMethod]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("abc");

            // Specific Assertion Example
            Assert.AreEqual("<strong>abc</strong>", result);

            // General Assertion Example
            Assert.AreEqual(true, result.StartsWith("<strong>"));
            Assert.AreEqual(true, result.EndsWith("</strong>"));
            Assert.AreEqual(true, result.Contains("abc"));
        }
    }
}
