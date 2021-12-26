using ArithmeticAPI.Services;
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

        [HttpPost("/addition")]
        public int Addition(int[] values)
        {
            var usecase = new AdditionUseCase(sumService);
            return usecase.Add(values);
        }

        [HttpPost("/subtraction")]
        public int Subtraction(int[] values)
        {
            var usecase = new SubtractionUseCase(sumService);
            return usecase.Subtract(values);
        }
    }
}
