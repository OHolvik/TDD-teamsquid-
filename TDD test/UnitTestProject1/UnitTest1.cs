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
            string[] str = {"Length"};
            string expected = "6";

            stringUtil su = new stringUtil();


            //Act
            string result = su.strCount(str);


            //Assert

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestStrType()
        {
            //Arrange
            string [] str = { "hej", "123", "hej123"};
            string [] expected = { "word", "number", "none"};

             stringUtil su = new stringUtil();
            //Act
            string result = su.strType(str);


            //Assert
            Assert.Equals(expected, result);



        }
        [TestMethod]
        public void TestNextPalindrome()
        {
            //Arrange
            int [] str = {123};
            int expected = 123321;

            stringUtil su = new stringUtil();
            //Act
            int result = su.nextPalindrome(str);

            //Assert
            Assert.Equals(expected, result);



        }

        [TestMethod]
        public void TestNextPrime()
        {
            //Arrange
            int[] str = {2};
            int [] expected = { 3, 5, 7 };

            stringUtil su = new  stringUtil();


            //Act

            int result = su.nextPrime(str);

            //Assert

            Assert.Equals(expected, result);

        }
    }
}
