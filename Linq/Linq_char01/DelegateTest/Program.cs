using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateTest
{
    class Program
    {
        public delegate void Delegate1();
        static void Main(string[] args)
        {
 
        }
        static void Repeat10Time(Delegate1 delegate1)
        {
            for (int i = 0; i < 10; i++)
            {
                delegate1();
            }
        }
    }
    public class Writer
    {
        public string test = "";
        public int counter=0;

        public void Dump()
        {
            Console.WriteLine(test);
            counter++;
        }
    }
}

















    //  public delegate void Delegate1();
    //    static void Repeat10Times(Delegate1 someword)
    //    {
    //        for (int i = 0; i < 10; i++)
    //        {
    //            someword();
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        Writer writer = new Writer();
    //        writer.Test = "Hello Linq";
    //        Repeat10Times(writer.Dump);
    //        Console.WriteLine(writer.Counter);
    //        Console.ReadLine();
    //    }
    //}
    //public class Writer
    //{
    //    public string Test;
    //    public int Counter;
    //    public void Dump()
    //    {
    //        Console.WriteLine(Test);
    //        Counter++;
    //    }
    //}
