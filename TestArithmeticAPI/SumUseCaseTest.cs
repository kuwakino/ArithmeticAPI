using ArithmeticAPI.Services;
using ArithmeticAPI.UseCases;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArithmeticAPI
{
    [TestClass]
    public class SumUseCaseTest
    {
        [TestMethod]
        public void GIVEN_an_array_of_integer_numbers_WHEN_sum_is_called_THEN_should_return_the_sum_of_the_values()
        {
            //arrange
            ISumService sumService = new SumService();
            SumUseCase useCase = new SumUseCase(sumService);

            int[] givenParams = { 1, 2, 3, -4 };
            int expectedAddition = 2;

            //act
            int actualAddition = useCase.Sum(givenParams);

            //assert
            Assert.AreEqual(expectedAddition, actualAddition);
        }
    }
}
