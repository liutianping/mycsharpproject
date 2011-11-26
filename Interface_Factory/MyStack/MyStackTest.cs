using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace MyStack
{
    [TestFixture]
    public class MyStackTest
    {
        private MyStack myStack;
        [SetUp]
        public void Init()
        {
            myStack = new MyStack();
        }

        [Test]
        public void TestPush()
        {
            myStack.Push("hello word");
            Assert.AreEqual("hello word", myStack.Pop());
        }

        [Test]
        public void TestPush2()
        {
            for (int i = 0; i <100; ++i)
            {
                myStack.Push(i + "");
            }
            for (int i = 0; i < 100; ++i)
            {
                Assert.AreEqual(99-i+"",myStack.Pop());
            }
        }
        [Test,ExpectedException]
        public void TestPush3()
        {
            for (int i = 0; i < 101; i++)
            {
                myStack.Push(i+"");
            }

            for (int i = 0; i < 101; i++)
            {
                string result = myStack.Pop();
                Assert.AreEqual(100-i+"",result);
            }
        }

        [Test,ExpectedException]
        public void TestPop()
        {
            Assert.AreEqual("hello",myStack.Pop());
        }

        [Test]
        public void TestPop1()
        {
            myStack.Push("hello");
            myStack.Push("word");
            Assert.AreEqual("word",myStack.Pop());
            Assert.AreEqual("hello",myStack.Pop());
            myStack.Push("hello");
            myStack.Push("word");
            myStack.Delete(1);
            Assert.AreEqual("hello",myStack.Top());
        }

        [Test,ExpectedException]
        public void TestTop()
        {
            Assert.AreEqual("hello",myStack.Top());
        }
        [Test]
        public void TestTop1()
        {
            myStack.Push("hello");
            myStack.Push("word");
            Assert.AreEqual("word", myStack.Top());
            myStack.Pop();
            Assert.AreEqual("hello", myStack.Top());

        }

        [Test,ExpectedException]
        public void TestDelete()
        {
            myStack.Push("hello");
            myStack.Delete(101);
            Assert.AreEqual(0,myStack.Size());
        }
    }
}
