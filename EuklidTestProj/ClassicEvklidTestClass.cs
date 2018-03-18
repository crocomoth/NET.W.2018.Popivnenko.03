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
    }
}
