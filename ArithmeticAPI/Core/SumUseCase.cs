using ArithmeticAPI.Services;

namespace ArithmeticAPI.UseCases
{
    public class SumUseCase
    {
        private ISumService sumService;

        public SumUseCase(ISumService sumService) => this.sumService = sumService;

        public int Sum(int[] values) => sumService.Sum(values);
    }
}