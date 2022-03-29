using Kata._01_FizzBuzz;

namespace Kata.Tests._01_FizzBuzz
{
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        public void GetFizzBuzz_ShouldReturnNumberAsStringCorrect(int number, string result)
        {
            // Arrange
            var sut = new FizzBuzz();

            // Act
            var actual = sut.GetFizzBuzz(1);

            // Assert
            actual.Should().Be(result);
        }
    }
}
