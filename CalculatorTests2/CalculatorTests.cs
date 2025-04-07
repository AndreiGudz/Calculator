using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;

namespace Calculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        // Тесты для Add
        public static IEnumerable<object[]> GetTestDataForAdd()
        {
            yield return new object[] { 1, 2, 3 };    // положительный
            yield return new object[] { -5, 5, 0 };   // положительный
            yield return new object[] { 2, 2, 5 };    // отрицательный
        }

        [TestMethod()]
        [DynamicData(nameof(GetTestDataForAdd), DynamicDataSourceType.Method)]
        public void AddTest(double a, double b, double result)
        {
            double actualResult = Calculator.Add(a, b);
            Assert.AreEqual(result, actualResult);
        }

        // Тесты для Subtract
        public static IEnumerable<object[]> GetTestDataForSubtract()
        {
            yield return new object[] { 5, 3, 2 };    // положительный
            yield return new object[] { -5, -3, -2 }; // положительный
            yield return new object[] { 10, 5, 6 };   // отрицательный
        }

        [TestMethod()]
        [DynamicData(nameof(GetTestDataForSubtract), DynamicDataSourceType.Method)]
        public void SubtractTest(double a, double b, double result)
        {
            double actualResult = Calculator.Subtract(a, b);
            Assert.AreEqual(result, actualResult);
        }

        // Тесты для Multiply
        public static IEnumerable<object[]> GetTestDataForMultiply()
        {
            yield return new object[] { 2, 3, 6 };    // положительный
            yield return new object[] { -2, 4, -8 };  // положительный
            yield return new object[] { 2, 2, 5 };   // отрицательный
        }

        [TestMethod()]
        [DynamicData(nameof(GetTestDataForMultiply), DynamicDataSourceType.Method)]
        public void MultiplyTest(double a, double b, double result)
        {
            double actualResult = Calculator.Multiply(a, b);
            Assert.AreEqual(result, actualResult);
        }

        // Тесты для Divide
        public static IEnumerable<object[]> GetTestDataForDivide()
        {
            yield return new object[] { 6, 2, 3 };    // положительный
            yield return new object[] { -8, 2, -4 };  // положительный
            yield return new object[] { 10, 2, 4 };   // отрицательный
        }

        [TestMethod()]
        [DynamicData(nameof(GetTestDataForDivide), DynamicDataSourceType.Method)]
        public void DivideTest(double a, double b, double result)
        {
            double actualResult = Calculator.Divide(a, b);
            Assert.AreEqual(result, actualResult);
        }

        // Тесты для Square
        public static IEnumerable<object[]> GetTestDataForSquare()
        {
            yield return new object[] { 3, 9 };      // положительный
            yield return new object[] { -2, 4 };     // положительный
            yield return new object[] { 4, 15 };     // отрицательный
        }

        [TestMethod()]
        [DynamicData(nameof(GetTestDataForSquare), DynamicDataSourceType.Method)]
        public void SquareTest(double a, double result)
        {
            double actualResult = Calculator.Square(a);
            Assert.AreEqual(result, actualResult);
        }

        // Тесты для SquareRoot
        public static IEnumerable<object[]> GetTestDataForSquareRoot()
        {
            yield return new object[] { 4, 2 };      // положительный
            yield return new object[] { 9, 3 };      // положительный
            yield return new object[] { 16, 5 };     // отрицательный
        }

        [TestMethod()]
        [DynamicData(nameof(GetTestDataForSquareRoot), DynamicDataSourceType.Method)]
        public void SquareRootTest(double a, double result)
        {
            double actualResult = Calculator.SquareRoot(a);
            Assert.AreEqual(result, actualResult);
        }

        // Дополнительный тест для проверки исключения при делении на 0
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZeroTest()
        {
            Calculator.Divide(5, 0);
        }

        // Дополнительный тест для проверки исключения при отрицательном числе в SquareRoot
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void SquareRootNegativeTest()
        {
            Calculator.SquareRoot(-4);
        }
    }
}