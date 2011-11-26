using System;
using System.Collections.Generic;
using System.Text;

namespace MyStack
{
    public class MathCompute
    {
        public int Lagerest(int[] array)
        {
            int result = int.MinValue;
            if (null == array || 0 == array.Length)
            {
                throw new Exception("参数传递异常！！");
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > result)
                {
                    result = array[i];
                }
            }
            return result;
        }
    }
}
