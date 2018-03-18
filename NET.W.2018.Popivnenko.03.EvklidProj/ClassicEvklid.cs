using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Popivnenko._03.EvklidProj
{
    public class ClassicEvklid
    {
        public int ClassicEvklidMethod(params int[] numbers)
        {
            if (numbers.Length < 2)
            {
                return -1;
            }
            int result = EvklidForTwoNumbers(numbers[0], numbers[1]);
            for (int i = 2;i<numbers.Length - 1;i++)
            {
                result = EvklidForTwoNumbers(result, numbers[i]);
            }
            return result;
        }

        private int EvklidForTwoNumbers(int num1,int num2)
        {
            while (num2 != 0)
            {
                int buf = num2;
                num2 = num1 % num2;
                num1 = buf;
            }
            return num1;
        }
    }
}
