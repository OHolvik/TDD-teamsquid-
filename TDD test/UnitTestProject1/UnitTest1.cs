using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_test;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestStrCount()
        {

            //Arrange
            string str = "Length";
            int expected = 6;

            stringUtil su = new stringUtil();

            //Act
            int result = su.strCount(str);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestStrType1()
        {
            //Arrange
            string str = "hej";
            string expected = "word";

            stringUtil su = new stringUtil();
            //Act
            string result = su.strType(str);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestStrType2()
        {
            //Arrange
            string str = "123";
            string expected = "number";

            stringUtil su = new stringUtil();
            //Act
            string result = su.strType(str);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestStrType3()
        {
            //Arrange
            string str = "hej123";
            string expected = "none";

            stringUtil su = new stringUtil();
            //Act
            string result = su.strType(str);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestNextPalindrome()
        {
            //Arrange
            int num = 123;
            int expected = 123321;

            stringUtil su = new stringUtil();
            //Act
            int result = su.nextPalindrome(num);

            //Assert
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestNextPrime()
        {
            //Arrange
            int num =  2 ;
            int[] expected = { 3, 5, 7 };

            stringUtil su = new stringUtil();

            //Act
            int[] result = su.nextPrime(num);

            //Assert
            CollectionAssert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestIsPrime()
        {
            int num = 101;
            bool expected = true;

            stringUtil su = new stringUtil();

            //Act
            bool result = su.isPrime(num);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
