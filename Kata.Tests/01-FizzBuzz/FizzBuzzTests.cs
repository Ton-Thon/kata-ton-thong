﻿using Kata._01_FizzBuzz;
using System;

namespace Kata.Tests._01_FizzBuzz
{
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Fizz")]
        [InlineData(6, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(10, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(30, "FizzBuzz")]
        [InlineData(50, "Buzz")]
        [InlineData(75, "FizzBuzz")]
        public void TestGetFizzBuz(int number, string expected)
        {
            // Arrange
            var sut = new FizzBuzz();

            // Act
            var actual = sut.GetFizzBuzz(number);

            // Assert
            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(101)]
        public void TestGetFizzBuz_ShouldThrowExceptionWhenArgumentOutOfRange(int number)
        {
            var sut = new FizzBuzz();
            Action act = () => sut.GetFizzBuzz(number);
            act.Should().Throw<ArgumentOutOfRangeException>("number");
        }
    }
}
