﻿using Xunit;

namespace Problems.Test
{
    public class SearchInsertPositionTests
    {
        [Theory]
        [InlineData(new[] { 1, 3, 5, 6 }, 5, 2)]
        [InlineData(new[] { 1, 3, 5, 6 }, 2, 1)]
        [InlineData(new[] { 1, 3, 5, 6 }, 7, 4)]
        public void SolutionA_ValidInput_MustReturnCorrectAnswer(int[] array, int target, int answer)
        {
            //Arrange
            var solution = new SearchInsertPosition();

            //Act
            var response = solution.SolutionA(array, target);

            //Assert
            Assert.Equal(answer, response);
        }
    }
}
