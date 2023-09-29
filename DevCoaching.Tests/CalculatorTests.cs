using FluentAssertions;

namespace DevCoaching.Tests
{
    public class CalculatorTests : IDisposable
    {
        private Calculator _sut;

        public CalculatorTests()
        {
            _sut = new Calculator();
        }

        public void Dispose()
        {
            _sut = null;
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(20, 20, 40)]
        public void AddShouldPass(decimal one, decimal two, decimal expected)
        {
            // Action
            var result = _sut.Add(one, two);

            // Assertion
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(1001, 1000)]
        public void AddShouldError(decimal one, decimal two)
        {
            // Action
            var func = () => _sut.Add(one, two);

            // Assertion
            func.Should().Throw<Exception>();
        }
    }


    public class Calculator
    {
        public decimal Add(decimal one, decimal two)
        {
            if (one > 1000) throw new Exception("Too large");

            return one + two;
        }
    }
}