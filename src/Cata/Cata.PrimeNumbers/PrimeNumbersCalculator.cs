namespace Cata.PrimeNumbers
{
    public class PrimeNumbersCalculator
    {
        public int[] Calculate(int number)
        {
            if (number % 2 == 0)
            {
                number = (number / 2);
                if (number % 2 == 0)
                {
                    return new int[] { 2, 2 };
                }
                else
                {
                    return new int[] { 2 };
                }
            }

            return new int[] { number };
        }
    }
}
