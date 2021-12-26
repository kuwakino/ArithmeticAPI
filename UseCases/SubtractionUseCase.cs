using ArithmeticAPI.Services;

namespace ArithmeticAPI.UseCases
{
    public class SubtractionUseCase
    {
        private ISumService sumService;

        public SubtractionUseCase(ISumService sumService) => this.sumService = sumService;

        public int Subtract(int[] values) => sumService.Sum(values);
    }
}