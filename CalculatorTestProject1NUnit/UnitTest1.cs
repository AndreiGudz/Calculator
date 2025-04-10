using Calculator;
using System.Xml.Linq;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace CalculatorTestProject1NUnit
{
    [TestFixture]
    public class Tests
    {
        static string path = Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "TestData.xml");

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

        [Test]
        [TestCaseSource(nameof(GetTestDataForStringSum))]
        public void StringSumTest(string str, int result)
        {
            int actualResult = Calculator.Calculator.StringSum(str);
            ClassicAssert.AreEqual(result, actualResult, $"В строке {str} ожидалось {result}, а получено {actualResult} в строке {str}");
        }
    }
}
