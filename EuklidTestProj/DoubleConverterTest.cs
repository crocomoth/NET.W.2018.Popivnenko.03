using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET.W._2018.Popivnenko._03.DoubleConverterProj;

namespace NET.W._2018.Popivnenko._03.Test
{
    [TestClass]
    public class DoubleConverterTest
    {

        DoubleConverter doubleConverter = new DoubleConverter();

        [DataTestMethod]
        [DataRow(-255.255, "1100000001101111111010000010100011110101110000101000111101011100")]
        [DataRow(255.255, "0100000001101111111010000010100011110101110000101000111101011100")]
        [DataRow(4294967295.0, "0100000111101111111111111111111111111111111000000000000000000000")]
        [DataRow(Double.MinValue, "1111111111101111111111111111111111111111111111111111111111111111")]
        [DataRow(Double.MaxValue, "0111111111101111111111111111111111111111111111111111111111111111")]
        [DataRow(Double.Epsilon, "0000000000000000000000000000000000000000000000000000000000000001")]
        [DataRow(Double.NaN, "1111111111111000000000000000000000000000000000000000000000000000")]
        [DataRow(Double.NegativeInfinity, "1111111111110000000000000000000000000000000000000000000000000000")]
        [DataRow(Double.PositiveInfinity, "0111111111110000000000000000000000000000000000000000000000000000")]
        public void Convert_test(double value,string expectedResult)
        {
            string actualResult = doubleConverter.Convert(value);
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
