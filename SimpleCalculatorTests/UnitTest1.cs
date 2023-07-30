
using NUnit.Framework;
using SimpleCalculator;

namespace SimpleCalculatorTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_AddsTwoNumbers_ReturnsSum()
        {
            var result = _calculator.Add(3, 4);
            Assert.That(result, Is.EqualTo(7));
        }
    }
}
