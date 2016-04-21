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
        public void Test_1_StrType()
        {
            //Arrange
            string str = "hej12";
            string expected = "none";

            stringUtil su = new stringUtil();

            //Act
            string result = su.strType(str);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_2_StrType()
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
        public void Test_3_StrType()
        {
            //Arrange
            string str = "123";
            string expected = "123";

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
            int digit = 123;
            int expected = 123321;

            stringUtil su = new stringUtil();

            //Act
            int result = su.nextPalindrome(digit);

            //Assert
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestNextPrime()
        {
            //Arrange
            int num = 3;
            int[] expected = { 5, 7, 11 };

            stringUtil su = new stringUtil();

            //Act
            int[] result = su.nextPrime(num);

            //Assert
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
