using System;
using System.Collections.Generic;
using System.Text;

namespace MyStack
{
    public class MyStack
    {
        private int nextIndex;
        private string[] elements;

        public MyStack()
        {
            nextIndex = 0;
            elements = new string[100];
        }

        public void Push(string element)
        {
            if (nextIndex == 100)
            {
                throw new Exception("超出数组索引");
            }
            elements[nextIndex++] = element;
        }

        public string Pop()
        {
            if (nextIndex == 0)
                throw new Exception("超出数组索引界限");
            return elements[--nextIndex];
        }

        public string Top()
        {
            if (nextIndex == 0)
                throw new Exception("超出数组索引界限");
            return elements[nextIndex - 1];
        }

        public void Delete(int n)
        {
            nextIndex -= n;
        }

        public int Size()
        {
            if (nextIndex < 0)
                throw new Exception(" 数组索引超出界限");
            return nextIndex;
        }

        public static void Main()
        {
        }
    }
}
