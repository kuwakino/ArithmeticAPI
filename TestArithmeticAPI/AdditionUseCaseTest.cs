using ArithmeticAPI.Services;
using ArithmeticAPI.UseCases;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestArithmeticAPI
{
    [TestClass]
    public class AdditionUseCaseTest
    {
        [TestMethod]
        public void GIVEN_an_array_of_integer_postive_numbers_WHEN_add_is_called_THEN_should_return_the_addition()
        {
            //arrange
            var sumService = new SumServiceSpy();
            AdditionUseCase useCase = new AdditionUseCase(sumService);

            int[] givenParams = { 1, 2, 3, 4 };
            int expectedAddition = 10;

            //act
            int actualAddition = useCase.Add(givenParams);

            //assert
            Assert.AreEqual(1, sumService.CountExecution);
            Assert.AreEqual(expectedAddition, actualAddition);
        }

        [TestMethod]
        public void GIVEN_an_array_of_integer_postive_AND_negative_numbers_WHEN_add_is_called_THEN_should_return_an_error()
        {
            //arrange
            var sumService = new SumService();
            AdditionUseCase useCase = new AdditionUseCase(sumService);

            int[] givenParams = { 1, 2, 3, -4 };
            string expectedError = "Invalid Addition. Only positive numbers are accepted.";

            //act
            string actualError = null;
            try
            {
                int actualAddition = useCase.Add(givenParams);
            } catch (Exception err)
            {
                actualError = err.Message;
            }
            
            //assert
            Assert.AreEqual(expectedError, actualError);
        }
    }

    internal class SumServiceSpy : ISumService
    {
        private int countExecution = 0;

        public int CountExecution { get => countExecution; set => countExecution = value; }

        public int Sum(int[] givenParams)
        {
            countExecution++;
            return 10;
        }
    }
}