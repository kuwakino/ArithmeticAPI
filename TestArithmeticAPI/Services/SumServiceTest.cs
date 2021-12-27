using ArithmeticAPI.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestArithmeticAPI.Services
{
    [TestClass]
    public class SumServiceTest
    {
        [TestMethod]
        public void GIVEN_an_array_of_integer_numbers_WHEN_sum_is_called_THEN_should_return_the_sum()
        {
            //arrange
            ISumService sumService = new SumService();

            int[] givenParams = { 1, -2, 3, 4 };
            const int expectedSum = 6;

            //act
            int actualSum = sumService.Sum(givenParams);

            //assert
            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}
