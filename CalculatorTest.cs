using Xunit;
namespace teste_xunit
{
    public class CalculatorTest
    {
        [Fact]
        public void SumIsCorrect()
        {
            // Given
            Calculator calculator = new Calculator();

            // When
            double result = calculator.Sum(2,2);
        
            // Then
            Assert.Equal(4, result);
        }

        [Fact]
        public void SubtractIsCorrect() 
        {
            // Given
            Calculator calculator = new Calculator();

            // When
            double result = calculator.Subtract(3,2);

            //Then
            Assert.Equal(1, result);
        }

        [Fact]
        public void MultiplyIsCorrect() 
        {
            // Given
            Calculator calculator = new Calculator();

            // When
            double result = calculator.Multiply(3,2);

            //Then
            Assert.Equal(6, result);
        }

        [Fact]
        public void DivideIsCorrect() 
        {
            // Given
            Calculator calculator = new Calculator();

            // When
            double result = calculator.Divide(6,2);

            //Then
            Assert.Equal(3, result);
        }

        [Fact]
        public void DivideByZeroIsCorrect () 
        {
            // Given
            Calculator calculator = new Calculator();

            // When
            double result = calculator.Divide(4,0);

            //Then
            Assert.Equal(double.PositiveInfinity, result);
        }
    }
}