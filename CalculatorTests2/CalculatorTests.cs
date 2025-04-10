using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Diagnostics;

namespace Calculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        static string path = Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "TestData.xml");

        /*        #region Тесты для других операций
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

                #endregion*/

        // Тесты для Divide
        public static IEnumerable<object[]> GetTestDataForDivide()
        {
            var doc = XDocument.Load(path);
            return doc.Root
                .Element("DivideTestCases")
                .Elements("TestCase")
                .Select(el => new object[] 
                { 
                    double.Parse(el.Element("Param1").Value),
                    double.Parse(el.Element("Param2").Value),
                    double.Parse(el.Element("Param3").Value)
                });
        }

        [TestMethod()]
        [DynamicData(nameof(GetTestDataForDivide), DynamicDataSourceType.Method)]
        public void DivideTest(double a, double b, double result)
        {
            double actualResult = Calculator.Divide(a, b);
            Assert.AreEqual(result, actualResult, Calculator.epsilon, $"ожидалось {result}, при делении {a} на {b}, а получено {actualResult}");
        }

        // Тесты для SquareRoot
        public static IEnumerable<object[]> GetTestDataForSquareRoot()
        {
            var doc = XDocument.Load(path);
            return doc.Root
                .Element("SquareRootTestCases")
                .Elements("TestCase")
                .Select(el => new object[]
                {
                    double.Parse(el.Element("Param1").Value),
                    double.Parse(el.Element("Param2").Value)
                });
        }

        [TestMethod()]
        [DynamicData(nameof(GetTestDataForSquareRoot), DynamicDataSourceType.Method)]
        public void SquareRootTest(double a, double result)
        {
            double actualResult = Calculator.SquareRoot(a);
            Assert.AreEqual(result, actualResult, Calculator.epsilon, $"ожидалось {result}, при вычислении квадратного корня, а получено {actualResult}");
        }

        // Дополнительный тест для проверки исключения при делении на 0
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZeroTest()
        {
            Calculator.Divide(5, 0);
            Assert.Fail("Исключение не произошло");
        }

        // Дополнительный тест для проверки исключения при отрицательном числе в SquareRoot
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void SquareRootNegativeTest()
        {
            Calculator.SquareRoot(-4);
            Assert.Fail("Исключение не произошло");
        }

        // Тесты для StringSum
        public static IEnumerable<object[]> GetTestDataForStringSum()
        {
            var doc = XDocument.Load(path);
            return doc.Root
                .Element("StringSumCases")
                .Elements("TestCase")
                .Select(el => new object[]
                {
                    el.Element("Param1").Value,
                    int.Parse(el.Element("Param2").Value)
                });
        }

        [TestMethod()]
        [DynamicData(nameof(GetTestDataForStringSum), DynamicDataSourceType.Method)]
        public void StringSumTest(string str, int result)
        {
            int actualResult = Calculator.StringSum(str);
            Assert.AreEqual(result, actualResult, $"В строке {str} ожидалось {result}, а получено {actualResult}\n {string.Join("   ", str)}");
        }
    }
}