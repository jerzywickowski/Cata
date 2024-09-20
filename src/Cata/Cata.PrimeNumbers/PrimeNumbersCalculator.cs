namespace Cata.PrimeNumbers
{
    public class PrimeNumbersCalculator
    {
        public int[] Calculate(int number)
        {
            var result = new List<int>();
            for (int i = 2; i <= number; i++)
            {
                while (number % i == 0)
                {
                    result.Add(i);
                    number /= i;
                }
            }

            return result.ToArray();
        }
    }
}
