﻿using ArithmeticAPI.Services;
using ArithmeticAPI.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace ArithmeticAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class OperationsController : Controller
    {
        private SumService sumService;

        public OperationsController()
        {
            sumService = new SumService();
        }

        /// <summary>
        /// Return the sum of all the elements of an array.
        /// </summary>
        /// <param name="values">Array of integer numbers, separated by commas. Include only positive numbers.</param>
        /// <returns>The sum of all the values of the array passed.</returns>
        [HttpPost("/addition")]
        public int Addition(int[] values)
        {
            var usecase = new AdditionUseCase(sumService);
            return usecase.Add(values);
        }

        /// <summary>
        /// Return the sum of all the elements of an array. 
        /// </summary>
        /// <param name="values">Array of integer numbers, separated by commas. Include minus signal to subtract elemets from the final sum.</param>
        /// <returns>The sum of all the values of the array passed.</returns>
        [HttpPost("/subtraction")]
        public int Subtraction(int[] values)
        {
            var usecase = new SubtractionUseCase(sumService);
            return usecase.Subtract(values);
        }
    }
}
