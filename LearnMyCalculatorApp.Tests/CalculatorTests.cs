using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnMyCalculatorApp;
using System;

namespace LearnMyCalculatorApp.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void CalculatorNullTest()
        {
            var calculator = new Calculator();
            Assert.IsNotNull(calculator);
        }
    }
}
