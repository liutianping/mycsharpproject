using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace for_for
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arrInt = {7,6,5,4,3,2 };
            //for (int i = 0; i < arrInt.Length; i++)
            //{
            //    if(i>=1)
            //    Console.WriteLine("第{0}趟比较：  i的值为：{1}",i,i);
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.WriteLine("      第{0}次比较：  j的值为：{1}",j+1,j);
            //        if (arrInt[i] < arrInt[j])
            //        {
            //            int temp = arrInt[i];
            //            arrInt[i] = arrInt[j];
            //            arrInt[j] = temp;
            //        }
            //        foreach (int c in arrInt)
            //        {
            //            Console.Write("     "+c + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------");
            //foreach (int c in arrInt)
            //{
            //    Console.Write(c + " ");
            //}



            int row = 6;
            string s = "";
            for (int i = 0; i < row; i++)
            {
                for (int j = i; j < row - 1; j++)
                {
                    s += " ";
                }
                for (int k = 0; k <= i; k++)
                {
                    s += "* ";
                }
                s += "\r\n";
            }
            Console.Write(s);
            Console.ReadLine();

        }
        
    }
}
