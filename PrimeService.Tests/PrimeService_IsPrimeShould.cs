using NUnit.Framework;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    [TestFixture]
    public class PrimeService_IsPrimeShould
    {
        private PrimeService _primeService;

        [SetUp]
        public void SetUp()
        {
            _primeService = new PrimeService();
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
        public void ExeptionFunc()
        {
            OverflowException exception = Assert.Throws<OverflowException>(() =>
            {
                var result = _primeService.Add(2147483647, 2147483647);
            });
            Assert.IsInstanceOf(exception, typeof(OverflowException));
        }

        // [Test]
        // public void Add_InputIs2147483647and2147483647_ReturnException()
        // {
        //     Assert.Throws<OverflowException>(() =>
        //     {
        //         var result = _primeService.Add(2147483647, 2147483647);
        //     });

        // }
        // [TestCase(1)]
        // [TestCase(1)]
        // [TestCase(1)]

    }
}