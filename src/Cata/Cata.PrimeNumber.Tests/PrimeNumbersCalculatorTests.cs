using Cata.PrimeNumbers;

namespace Cata.PrimeNumber.Tests

{
    public class PrimeNumbersCalculatorTests
    {
        [Theory]
        [InlineData(2, new [] { 2 })]
        [InlineData(3, new [] { 3 })]
        [InlineData(4, new [] { 2, 2 })]
        public void Calculate_for_2(int input, int[] output)
        {
            var numbersCalculator = new PrimeNumbersCalculator();
            int[] result = numbersCalculator.Calculate(input);
            Assert.Equal(output.Length, result.Length);
            Assert.Equal(output, result);
        }
    }
}

