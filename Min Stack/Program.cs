using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.
 * push(x) -- Push element x onto stack.
 * pop() -- Removes the element on top of the stack.
 * top() -- Get the top element.
 * getMin() -- Retrieve the minimum element in the stack. 
 */


namespace Min_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Your MinStack object will be instantiated and called as such:
             * MinStack obj = new MinStack();
             * obj.Push(x);
             * obj.Pop();
             * int param_3 = obj.Top();
             * int param_4 = obj.GetMin();
             */

            MinStack minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            minStack.GetMin();
            minStack.Pop();
            minStack.Top();
            minStack.GetMin();

        }
    }

    public class MinStack
    {
        private readonly Stack<(int val, int min)> _stack;

        /** initialize your data structure here. */
        public MinStack()
        {
            _stack = new Stack<(int, int)>();
        }

        public void Push(int x)
        {
            int min = _stack.Any() ? Math.Min(x, GetMin()) : x;
            _stack.Push((x, min));
        }

        public void Pop()
        {
            _stack.Pop();
        }

        public int Top()
        {
            return _stack.Peek().val;
        }

        public int GetMin()
        {
            return _stack.Peek().min;
        }
    }
}
