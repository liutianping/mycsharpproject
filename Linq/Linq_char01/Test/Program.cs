using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //int row = 6;
            //string s = "";
            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = i; j < row - 1; j++)
            //    {
            //        s += " ";
            //    }
            //    for (int k = 0; k <= i; k++)
            //    {
            //        s += "* ";
            //    }
            //    s += "\r\n";
            //}
            //Console.Write(s);
            //Console.ReadLine();
            //int row = 6;
            //string s = "";
            //for (int i = 0; i < row; i++)//循环row-1次
            //{
            //    for (int space = 0; space < row - i; space++)//打印前面的空格
            //    {
            //        s += " ";
            //    }
            //    for (int simble = 0; simble < 2*i-1; simble++)//打印每行的字符，这主要是2*i-1控制
            //    {
            //        s += "*";
            //    }
            //    s += "\r\n";
            //}
            //Console.WriteLine(s);


            //int row = 5;
            //char c = '@';

            //string s = "";
            //for (int i = 1; i <= row; i++)
            //{

            //    c = (char)((int)c + 1);
            //    for (int j = i; j <= row - 1; j++)
            //    {
            //        s += " ";
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        s += c;
            //    }
            //    s += "\r\n";
            //}
            //for (int i =0; i <= row; i++)
            //{
            //    for (int space = -1; space < i; space++)
            //    {
            //        s += " ";
            //    }
            //    for (int simble = 0;simble<2*(row-i-2)+1; simble++)
            //    {
            //        s += "*";
            //    }
            //    s += "\r\n";
            //}
            //    Console.Write(s);
            //    Console.ReadLine();


            //访问枚举里的值有两种方法吧
           // 第一：
            //这种相当于数组的下标访问。但要强制转换类型为TimeofDay
            TimeofDay timeofDay = (TimeofDay)1;
            Console.WriteLine(timeofDay);
           // 第二：直接枚举名.值
            Console.WriteLine(TimeofDay.Afternoon);
            Console.ReadLine();
        }
    }
    public enum TimeofDay
    {
        Morning,
        Afternoon,
        Evening
    } 
}
