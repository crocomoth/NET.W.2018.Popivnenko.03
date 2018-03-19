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

        [TestMethod]
        public void ConvertTest2()
        {
            DoubleConverter doubleConverter = new DoubleConverter();
            double value = 255.255;
            string result = doubleConverter.Convert(value);
            Assert.AreEqual("0100000001101111111010000010100011110101110000101000111101011100", result);
        }

        [TestMethod]
        public void ConvertTest3()
        {
            DoubleConverter doubleConverter = new DoubleConverter();
            double value = 4294967295.0;
            string result = doubleConverter.Convert(value);
            Assert.AreEqual("0100000111101111111111111111111111111111111000000000000000000000", result);
        }

        [TestMethod]
        public void ConvertTest4()
        {
            DoubleConverter doubleConverter = new DoubleConverter();
            double value = Double.MinValue;
            string result = doubleConverter.Convert(value);
            Assert.AreEqual("1111111111101111111111111111111111111111111111111111111111111111", result);
        }

        [TestMethod]
        public void ConvertTest5()
        {
            DoubleConverter doubleConverter = new DoubleConverter();
            double value = Double.MaxValue;
            string result = doubleConverter.Convert(value);
            Assert.AreEqual("0111111111101111111111111111111111111111111111111111111111111111", result);
        }

        [TestMethod]
        public void ConvertTest6()
        {
            DoubleConverter doubleConverter = new DoubleConverter();
            double value = Double.Epsilon;
            string result = doubleConverter.Convert(value);
            Assert.AreEqual("0000000000000000000000000000000000000000000000000000000000000001", result);
        }


        [TestMethod]
        public void ConvertTest7()
        {
            DoubleConverter doubleConverter = new DoubleConverter();
            double value = Double.NaN;
            string result = doubleConverter.Convert(value);
            Assert.AreEqual("1111111111111000000000000000000000000000000000000000000000000000", result);
        }

        [TestMethod]
        public void ConvertTest8()
        {
            DoubleConverter doubleConverter = new DoubleConverter();
            double value = Double.NegativeInfinity;
            string result = doubleConverter.Convert(value);
            Assert.AreEqual("1111111111110000000000000000000000000000000000000000000000000000", result);
        }

        [TestMethod]
        public void ConvertTest9()
        {
            DoubleConverter doubleConverter = new DoubleConverter();
            double value = Double.PositiveInfinity;
            string result = doubleConverter.Convert(value);
            Assert.AreEqual("0111111111110000000000000000000000000000000000000000000000000000", result);
        }

        [TestMethod]
        public void ConvertTest10()
        {
            DoubleConverter doubleConverter = new DoubleConverter();
            double value = Double.Epsilon;
            string result = doubleConverter.Convert(value);
            Assert.AreEqual("0000000000000000000000000000000000000000000000000000000000000001", result);
        }
    }
}
