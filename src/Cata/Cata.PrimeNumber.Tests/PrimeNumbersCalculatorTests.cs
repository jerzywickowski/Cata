using Cata.PrimeNumbers;

namespace Cata.PrimeNumber.Tests

{
    public class PrimeNumbersCalculatorTests
    {
        [Fact]
        public void Calculate_for_2()
        {
            var numbersCalculator = new PrimeNumbersCalculator();
            int[] result = numbersCalculator.Calculate(2);
            Assert.Equal(1, result.Length);
            Assert.Equal(2, result[0]);
        }
    }
}

