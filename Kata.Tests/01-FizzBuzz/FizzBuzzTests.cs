using Kata._01_FizzBuzz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Tests._01_FizzBuzz
{
    public class FizzBuzzTests
    {
        [Fact]
        public void SayHelloTest_ShouldReturnTest()
        {
            // Arrange
            var sut = new FizzBuzz();

            // Act
            var actual = sut.GetFizzBuzz();

            // Assert
            actual.Should().Be("Hello Test!");
        }
    }
}
