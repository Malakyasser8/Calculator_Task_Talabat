using NUnit.Framework;
using Calculator.Services;

namespace Calculator.UnitTests.Services
{
    [TestFixture]
    public class CalculatorServices_TestOperations
    {
        private CalculatorServices _primeService;

        [SetUp]
        public void SetUp()
        {
            _primeService = new CalculatorServices();
        }
        /*********Add Testcases**************/
        [Test]
        public void Add_InputIs1and1_Return2()
        {
            var result = _primeService.Add(1, 1);
            Assert.AreEqual(result, 2);

        }
        [Test]
        public void Add_InputIs1and5_Return6()
        {
            var result = _primeService.Add(1, 5);
            Assert.AreEqual(result, 6);

        }
        [Test]
        public void Add_InputIs6and4_Return10()
        {
            var result = _primeService.Add(6, 4);
            Assert.AreEqual(result, 10);

        }
        [Test]
        public void Add_InputIs2147483647and2147483647_ReturnException()
        {
            Assert.Throws<OverflowException>(() =>
            {
                var result = _primeService.Add(2147483647, 2147483647);
            });

        }
        /*********Subtract Testcases**************/
        [Test]
        public void Subtract_InputIs1and1_Return0()
        {
            var result = _primeService.Subtract(1, 1);
            Assert.AreEqual(result, 0);

        }
        [Test]
        public void Subtract_InputIs9and5_Return4()
        {
            var result = _primeService.Subtract(9, 5);
            Assert.AreEqual(result, 4);

        }

        [Test]
        public void Subtract_InputIs6and4_Return2()
        {
            var result = _primeService.Subtract(6, 4);
            Assert.AreEqual(result, 2);

        }

        [Test]
        public void Subtract_InputIsNeg2147483647and2147483647_ReturnException()
        {
            Assert.Throws<OverflowException>(() =>
            {
                var result = _primeService.Subtract(-2147483647, 2147483647);
            });

        }

        /*********Divide Testcases**************/
        [Test]
        public void Divide_InputIs14and2_Return7()
        {
            var result = _primeService.Divide(14, 2);
            Assert.AreEqual(result, 7);

        }

        [Test]
        public void Divide_InputIs9and4_Return2()
        {
            var result = _primeService.Divide(9, 4);
            Assert.AreEqual(result, 2);

        }

        [Test]
        public void Divide_InputIs3and0_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                var result = _primeService.Divide(3, 0);
            });

        }

        /*********Multiply Testcases**************/
        [Test]
        public void Multiply_InputIs9and4_Return36()
        {
            var result = _primeService.Multiply(9, 4);
            Assert.AreEqual(result, 36);

        }

        [Test]
        public void Multiply_InputIsNeg7and5_ReturnNeg35()
        {
            var result = _primeService.Multiply(-7, 5);
            Assert.AreEqual(result, -35);

        }

        [Test]
        public void Multiply_InputIs2147483647and2147483647_ThrowsOverflowException()
        {

            Assert.Throws<OverflowException>(() =>
            {
                var result = _primeService.Multiply(2147483647, 2147483647);
            });
        }

    }
}