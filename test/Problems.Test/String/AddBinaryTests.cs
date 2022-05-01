﻿using Problems.String;
using Xunit;

namespace Problems.Test.String
{
    public class AddBinaryTests
    {
        [Theory]
        [InlineData("11","1","100")]
        [InlineData("1010", "1011", "10101")]
        public void SolutionA_ValidInput_MustReturnCorrectAnswer(string a, string b, string responseExpected)
        {
            //Arrange
            var solution = new AddBinary();

            //Act
            var response = solution.SolutionA(a,b);

            //Assert
            Assert.Equal(responseExpected, response);
        }
    }
}
