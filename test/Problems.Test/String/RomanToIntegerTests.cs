﻿using Problems.String;
using Xunit;

namespace Problems.Test.String
{
    public class RomanToIntegerTests
    {
        [Theory]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("XIV", 14)]
        public void SolutionA_ValidInput_MustReturnCorrectAnswer(string array, int responseExpected)
        {
            //Arrange
            var solution = new RomanToInteger();

            //Act
            var response = solution.SolutionA(array);

            //Assert
            Assert.Equal(responseExpected, response);
        }
    }
}
