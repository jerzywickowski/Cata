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
        [Fact]
        public void Calculate_for_3()
        {
            var numbersCalculator = new PrimeNumbersCalculator();
            int[] result = numbersCalculator.Calculate(3);
            Assert.Equal(1, result.Length);
            Assert.Equal(3, result[0]);
        }

        [Fact]
        public void Calculate_for_4()
        {
            var numbersCalculator = new PrimeNumbersCalculator();
            int[] result = numbersCalculator.Calculate(4);
            Assert.Equal(2, result.Length);
            Assert.Equal(2, result[0]);
            Assert.Equal(2, result[1]);
        }
    }
}

