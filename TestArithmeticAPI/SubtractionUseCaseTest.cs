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
    public class SubtractionUseCaseTest
    {
        [TestMethod]
        public void GIVEN_an_array_of_integer_numbers_WHEN_add_is_called_THEN_should_return_the_addition()
        {
            //arrange
            ISumService sumService = new SumService();
            SubtractionUseCase useCase = new SubtractionUseCase(sumService);

            int[] givenParams = { 1, 2, 3, -4 };
            int expectedAddition = 2;

            //act
            int actualAddition = useCase.Subtract(givenParams);

            //assert
            Assert.AreEqual(expectedAddition, actualAddition);
        }
    }
}
