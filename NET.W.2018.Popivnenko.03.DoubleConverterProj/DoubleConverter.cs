using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Popivnenko._03.DoubleConverterProj
{
    /// <summary>
    /// Class that converts double value
    /// into IEEE 754 style string with bit representation.
    /// </summary>
    public class DoubleConverter
    {
        /// <summary>
        /// Method that converts double into string of bits.
        /// </summary>
        /// <param name="number">Double value to be processed.</param>
        /// <returns>String with bit representation.</returns>
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
