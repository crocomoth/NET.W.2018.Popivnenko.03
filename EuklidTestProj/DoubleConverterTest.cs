using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET.W._2018.Popivnenko._03.DoubleConverterProj;

namespace EuklidTestProj
{
    [TestClass]
    public class DoubleConverterTest
    {
        [TestMethod]
        public void ConvertTest1()
        {
            DoubleConverter doubleConverter = new DoubleConverter();
            double value = -255.255;
            string result = doubleConverter.Convert(value);
            Assert.AreEqual("1100000001101111111010000010100011110101110000101000111101011100", result);
        }
    }
}
