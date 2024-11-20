using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApps;
using System;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [TestInitialize]
        public void SetUp()
        {
            _calculator = new Calculator();
        }

        [TestMethod]
        public void Add_ShouldReturnCorrectSum()
        {
            double num1 = 5;
            double num2 = 3;

            double result = _calculator.Add(num1, num2);

            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            double num1 = 5;
            double num2 = 3;

            double result = _calculator.Subtract(num1, num2);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            double num1 = 5;
            double num2 = 3;

            double result = _calculator.Multiply(num1, num2);

            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            double num1 = 6;
            double num2 = 3;

            double result = _calculator.Divide(num1, num2);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_ByZero_ShouldThrowDivideByZeroException()
        {
            _calculator.Divide(6, 0);
        }

        [TestMethod]
        public void Power_ShouldReturnCorrectResult()
        {
            double baseValue = 2;
            double exponent = 3;

            double result = _calculator.Power(baseValue, exponent);

            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void SquareRoot_ShouldReturnCorrectResult()
        {
            double num = 9;

            double result = _calculator.SquareRoot(num);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SquareRoot_ShouldThrowArgumentException_ForNegativeNumber()
        {
            _calculator.SquareRoot(-9);
        }

        [TestMethod]
        public void Factorial_ShouldReturnCorrectResult()
        {
            Assert.AreEqual(120, _calculator.Factorial(5));
        }

        [TestMethod]
        public void ApproximatePiLeibniz_ShouldReturnValueCloseToPi()
        {
            int iterations = 1000000;

            double result = _calculator.ApproximatePiLeibniz(iterations);

            // Проверка, что результат близок к Math.PI с точностью 0.01
            Assert.IsTrue(Math.Abs(result - Math.PI) < 0.01);
        }

        // Тест с AreNotEqual для формулы Лейбница
        [TestMethod]
        public void ApproximatePiLeibniz_ShouldNotEqualToRandomValue()
        {
            // Arrange
            int iterations = 1000;
            double incorrectValue = 3.0; // Некорректное значение, чтобы проверить AreNotEqual

            // Act
            double result = _calculator.ApproximatePiLeibniz(iterations);

            // Assert
            Assert.AreNotEqual(incorrectValue, result, "Результат формулы Лейбница не должен быть равен 3.0");
        }

        // Тест на недостаточное количество итераций
        [TestMethod]
        public void ApproximatePiLeibniz_ShouldBeInaccurate_WithFewIterations()
        {
            // Arrange
            int iterations = 1; // Минимальное количество итераций

            // Act
            double result = _calculator.ApproximatePiLeibniz(iterations);

            // Assert
            Assert.AreNotEqual(Math.PI, result, "Результат не должен совпадать с Math.PI при 1 итерации");
            Assert.IsTrue(Math.Abs(result - Math.PI) > 0.1, "Разница между результатом и Math.PI должна быть существенной");
        }

        // Тест на некорректные входные данные (ноль итераций)
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ApproximatePiLeibniz_ShouldThrowArgumentException_WhenIterationsAreZero()
        {
            // Arrange
            int iterations = 0;

            // Act
            _calculator.ApproximatePiLeibniz(iterations);

            // Assert handled by ExpectedException
        }

        // Тест на отрицательные итерации
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ApproximatePiLeibniz_ShouldThrowArgumentException_ForNegativeIterations()
        {
            // Arrange
            int iterations = -100;

            // Act
            _calculator.ApproximatePiLeibniz(iterations);

            // Assert handled by ExpectedException
        }

        // Тест с большим количеством итераций
        [TestMethod]
        public void ApproximatePiLeibniz_ShouldBeAccurate_WithLargeIterations()
        {
            // Arrange
            int iterations = 1000000; // Очень большое количество итераций

            // Act
            double result = _calculator.ApproximatePiLeibniz(iterations);

            // Assert
            Assert.IsTrue(Math.Abs(result - Math.PI) < 0.0001, "Результат должен быть близок к Math.PI с точностью до 0.0001");
        }
    }
}

