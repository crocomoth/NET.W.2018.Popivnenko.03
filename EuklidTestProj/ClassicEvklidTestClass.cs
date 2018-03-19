using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET.W._2018.Popivnenko._03.EvklidProj;

namespace EuklidTestProj
{
    [TestClass]
    public class ClassicEvklidTestClass
    {
        ClassicEvklid evklid = new ClassicEvklid();

        [TestMethod]
        public void TestClassic1()
        {
            int result = evklid.ClassicEvklidMethod(64, 48);
            Assert.AreEqual(16, result);
        }

        [TestMethod]
        public void TestClassic2()
        {
            int result = evklid.ClassicEvklidMethod(432, 111);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestClassic3()
        {
            int result = evklid.ClassicEvklidMethod(661, 113);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestClassic4()
        {
            int result = evklid.ClassicEvklidMethod(32, 48,16);
            Assert.AreEqual(16, result);
        }

        [TestMethod]
        public void TestBinary1()
        {
            int result = evklid.BinaryEvklidMethod(64, 48);
            Assert.AreEqual(16, result);
        }

        [TestMethod]
        public void TestBinary2()
        {
            int result = evklid.BinaryEvklidMethod(432, 111);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestBinary3()
        {
            int result = evklid.BinaryEvklidMethod(661, 113);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestTimer1()
        {
            long result = 0;
            evklid.ClassicEvklidMethod(64, 48);
            result = evklid.GetTimeOfExecution();
            long binaryResult = 0;
            evklid.BinaryEvklidMethod(64, 48);
            binaryResult = evklid.GetTimeOfExecution();
            Assert.IsTrue(binaryResult <= result);
        }

        [TestMethod]
        public void TestTimer2()
        {
            long result = 0;
            evklid.ClassicEvklidMethod(64, 48,32);
            result = evklid.GetTimeOfExecution();
            long binaryResult = 0;
            evklid.BinaryEvklidMethod(64, 48,32);
            binaryResult = evklid.GetTimeOfExecution();
            Assert.IsTrue(binaryResult <= result);
        }

        [TestMethod]
        public void TestTimer3()
        {
            long result = 0;
            evklid.ClassicEvklidMethod(432, 111);
            result = evklid.GetTimeOfExecution();
            long binaryResult = 0;
            evklid.BinaryEvklidMethod(432, 111);
            binaryResult = evklid.GetTimeOfExecution();
            Assert.IsTrue(binaryResult <= result);
        }
    }
}
