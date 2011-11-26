using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 3, b = 5;
            //int c = Min(a, b);
            //Console.WriteLine(c);
            //Console.Read();
        }
        //static T Min<T>(T a, T b) where T : IComparable<T>
        //{
        //    if (a.CompareTo(b) < 0)
        //    { return a; }
        //    else
        //        return b;
        //}
        delegate void Delegate1();
        delegate int Delegate2();
        delegate void Delegate3(string name,int age);
        void CreateDelegate()
        {
            Delegate1 delegate1 = a;
            Delegate2 delegate2 = b;
            Delegate3 delegate3 = c;
        }
        void a()
        { 
        }
        int b()
        { return 0; }
        void c(string name,int age)
        { }
    }
}
