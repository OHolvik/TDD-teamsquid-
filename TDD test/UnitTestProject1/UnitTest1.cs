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

        }
        [TestMethod]
        public void TestNextPalindrome()
        {

        }

        [TestMethod]
        public void TestNextPrime()
        {

        }
    }
}
