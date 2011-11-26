using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.IO;

namespace MyStack
{
    [TestFixture]
    public class MathComputeTest
    {
        MathCompute mc;
        [TestFixtureSetUp]
        public void Inti()
        {
            mc = new MathCompute();
        }
        [Test]
        public void TestLagerest()
        {
            StreamReader sr = new StreamReader("../../DataSet.txt");
            string line = "";
            while (null != (line = sr.ReadLine()))
            {
                if (line.StartsWith("#"))
                {
                    continue;
                }
                string[] arr = line.Split(null);
                int execpetValue = int.Parse(arr[0]);
                List<int> inputArr = new List<int>();
                for (int i = 1; i < arr.Length; i++)
                {
                    inputArr.Add(int.Parse(arr[i]));
                }
                Assert.AreEqual(execpetValue, mc.Lagerest(inputArr.ToArray()));
            }
            sr.Close();
        }
    }
}
