using Kata._01_FizzBuzz;

namespace Kata.Tests._01_FizzBuzz
{
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Fizz")]
        [InlineData(6, "Fizz")]
        public void TestGetFizzBuz(int number, string expected)
        {
            // Arrange
            var sut = new FizzBuzz();

            // Act
            var actual = sut.GetFizzBuzz(number);

            // Assert
            actual.Should().Be(expected);
        }
    }
}
