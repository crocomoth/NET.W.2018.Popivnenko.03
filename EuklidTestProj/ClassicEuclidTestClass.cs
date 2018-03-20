using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET.W._2018.Popivnenko._03.EvklidProj;

namespace NET.W._2018.Popivnenko._03.Test
{
    [TestClass]
    public class ClassicEuclidTestClass
    {
        ClassicEvklid evklid = new ClassicEvklid();

        [DataTestMethod]
        [DataRow(16, new int[] { 64, 48 })]
        [DataRow(3,new int[] { 432, 111 })]
        [DataRow(1, new int[] { 661, 113 })]
        [DataRow(16, new int[] { 32, 48, 16 })]
        public void ClassicEuclidMethod_test(int expectedResult, params int[] numbers)
        {
            int actualResult = evklid.ClassicEuclidMethod(numbers);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [DataTestMethod]
        [DataRow(16, new int[] { 64, 48 })]
        [DataRow(3, new int[] { 432, 111 })]
        [DataRow(1, new int[] { 661, 113 })]
        [DataRow(16, new int[] { 32, 48, 16 })]
        public void BinaryEuclidMethod_test(int expectedResult,params int[] numbers)
        {
            int actualResult = evklid.BinaryEuclidMethod(numbers);
            Assert.AreEqual(expectedResult, actualResult);
        }


        [DataTestMethod]
        [DataRow(new int[] { 64,48})]
        [DataRow(new int[] { 64,48,32})]
        [DataRow(new int[] { 432,111})]
        public void GetTimeOfExecution_test(params int[] numbers)
        {
            evklid.ClassicEuclidMethod(numbers);
            long elapsedTimeForClassic = evklid.GetTimeOfExecution();
            evklid.BinaryEuclidMethod(numbers);
            long elapsedTimeForBinary = evklid.GetTimeOfExecution();
            Assert.IsTrue(elapsedTimeForBinary <= elapsedTimeForClassic);
            
        }

        
    }
}
