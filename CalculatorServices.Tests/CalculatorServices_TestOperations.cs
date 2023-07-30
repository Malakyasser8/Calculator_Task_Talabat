using NUnit.Framework;
using Calculator.Services;

namespace Calculator.UnitTests.Services
{
    [TestFixture]
    public class CalculatorServices_TestOperations
    {
        private CalculatorServices CalculatorObj;

        [SetUp]
        public void SetUp()
        {
            CalculatorObj = new CalculatorServices();
        }
        /*********Add Testcases**************/
        [TestCase(1, 1, 2)]
        [TestCase(7, 5, 12)]
        [TestCase(6, 9, 15)]
        public void Add_Testing(int FirstNum, int SecondNum, int ActualResult)
        {
            var ExpectedResult = CalculatorObj.Add(FirstNum, SecondNum);

            Assert.AreEqual(ActualResult, ExpectedResult);

        }
        [Test]
        public void Add_InputIs2147483647and2147483647_ReturnException()
        {
            Assert.Throws<OverflowException>(() =>
            {
                var result = CalculatorObj.Add(2147483647, 2147483647);
            });

        }
        /*********Subtract Testcases**************/
        [TestCase(1, 1, 0)]
        [TestCase(6, 10, -4)]
        [TestCase(-5, 4, -9)]
        public void Subtract_Testing(int FirstNum, int SecondNum, int ActualResult)
        {
            var ExpectedResult = CalculatorObj.Subtract(FirstNum, SecondNum);
            Assert.AreEqual(ActualResult, ExpectedResult);

        }
        [Test]
        public void Subtract_InputIsNeg2147483647and2147483647_ReturnException()
        {
            Assert.Throws<OverflowException>(() =>
            {
                var result = CalculatorObj.Subtract(-2147483647, 2147483647);
            });

        }

        /*********Divide Testcases**************/
        [TestCase(2, 1, 2)]
        [TestCase(10, 5, 2)]
        [TestCase(7, 2, 3)]
        public void Divide_Testing(int FirstNum, int SecondNum, int ActualResult)
        {
            var ExpectedResult = CalculatorObj.Divide(FirstNum, SecondNum);
            Assert.AreEqual(ActualResult, ExpectedResult);

        }
        [Test]
        public void Divide_InputIs5and0_ReturnDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                var result = CalculatorObj.Divide(5, 0);
            });

        }

        /*********Multiply Testcases**************/
        [TestCase(2, 1, 2)]
        [TestCase(6, 6, 36)]
        [TestCase(4, 4, 16)]
        public void Multiply_Testing(int FirstNum, int SecondNum, int ActualResult)
        {
            var ExpectedResult = CalculatorObj.Multiply(FirstNum, SecondNum);
            Assert.AreEqual(ActualResult, ExpectedResult);

        }
        [Test]
        public void Multiply_InputIs2147483647and2147483647_ReturnException()
        {
            Assert.Throws<OverflowException>(() =>
            {
                var result = CalculatorObj.Multiply(2147483647, 2147483647);
            });

        }

    }
}