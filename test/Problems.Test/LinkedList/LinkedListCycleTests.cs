﻿using Problems.LinkedList;
using static Problems.LinkedList.LinkedListCycle;

namespace Problems.Test.LinkedList
{
    public class LinkedListCycleTests
    {
        [Fact]
        public void SolutionA_HasCycle_MustReturnTrue()
        {
            //Arrange
            var solution = new LinkedListCycle();
            var head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = head.next;

            //Act
            var result = solution.SolutionA(head);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void SolutionA_NoCycle_MustReturnfalse()
        {
            //Arrange
            var solution = new LinkedListCycle();
            var head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);

            //Act
            var result = solution.SolutionA(head);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void SolutionB_HasCycle_MustReturnTrue()
        {
            //Arrange
            var solution = new LinkedListCycle();
            var head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = head.next;

            //Act
            var result = solution.SolutionB(head);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void SolutionB_NoCycle_MustReturnfalse()
        {
            //Arrange
            var solution = new LinkedListCycle();
            var head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);

            //Act
            var result = solution.SolutionB(head);

            //Assert
            Assert.False(result);
        }
    }
}
