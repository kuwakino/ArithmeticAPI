using ArithmeticAPI.Services;

namespace ArithmeticAPI.UseCases
{
    public class AdditionUseCase
    {
        private ISumService sumService;

        public AdditionUseCase(ISumService sumService) => this.sumService = sumService;

        public int Add(int[] values)
        {
            bool hasAnyNegative = values.Any(v => v < 0);
            if (hasAnyNegative)
            {
                throw new Exception("Invalid Addition. Only positive numbers are accepted.");
            }

            return sumService.Sum(values);
        }
    }
}