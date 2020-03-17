using System;
using System.Collections.Generic;
using Xunit;

namespace LeetCodePractice
{
    public class MinStackUnitTests
    {
        // 155. Min Stack https://leetcode.com/problems/min-stack/
        /// <summary>
        /// Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.
        ///     push(x) -- Push element x onto stack.
        ///     pop() -- Removes the element on top of the stack.
        ///     top() -- Get the top element.
        ///     getMin() -- Retrieve the minimum element in the stack.
        /// </summary>
        [Fact]
        public void MinStack()
        {
            MinStack minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            Assert.Equal(-3, minStack.GetMin()); //--> Returns - 3.
            minStack.Pop();
            Assert.Equal(0, minStack.Top()); //--> Returns 0.
            Assert.Equal(-2, minStack.GetMin()); //--> Returns - 2.
        }
    }
    public class MinStack
    {

        /** initialize your data structure here. */
        public MinStack()
        {

        }

        public void Push(int x)
        {

        }

        public void Pop()
        {

        }

        public int Top()
        {
            return 0;
        }

        public int GetMin()
        {
            return 0;
        }
    }
}
