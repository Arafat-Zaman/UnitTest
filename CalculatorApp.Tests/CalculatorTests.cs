using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        // Setup runs before each test
        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        // Test for addition method
        [Test]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            var result = _calculator.Add(a, b);

            // Assert
            Assert.AreEqual(8, result);
        }

        // Test for division method
        [Test]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            // Arrange
            int a = 10;
            int b = 2;

            // Act
            var result = _calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(5, result);
        }

        // Test for division by zero exception
        [Test]
        public void Divide_ByZero_ShouldThrowException()
        {
            // Arrange
            int a = 10;
            int b = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(a, b));
        }
    }
}

