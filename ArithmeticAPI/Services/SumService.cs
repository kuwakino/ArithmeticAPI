namespace ArithmeticAPI.Services
{
    public class SumService : ISumService
    {
        public int Sum(int[] values) => values.Sum();

    }
}
