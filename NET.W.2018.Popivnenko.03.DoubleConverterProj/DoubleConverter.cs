using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Popivnenko._03.DoubleConverterProj
{
    public class DoubleConverter
    {
        public string Convert(double number)
        {
            string buf = "";
            string result = "";
            double value = number;
            foreach (byte b in BitConverter.GetBytes(value))
            {
                buf = "";
                buf += System.Convert.ToString(b, 2).PadLeft(8, '0');
                result = buf + result;
            }
            return result;
        }
    }
}
