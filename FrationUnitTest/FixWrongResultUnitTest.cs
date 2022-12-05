using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionLib;

namespace FrationUnitTest
{
    [TestClass]
    public class FixWrongResultUnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            //Arrange
            string text = "95/100";
            string expected = "95/100";
            //Act
            FractionClass obj = new FractionClass();
            string actual = obj.FixWrongResult(text);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string text = "195/100";
            string expected = "100/100";
            //Act
            FractionClass obj = new FractionClass();
            string actual = obj.FixWrongResult(text);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            string text = "";
            //Act
            FractionClass obj = new FractionClass();
            Action actual = () => obj.FixWrongResult(text);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            string text = "/";
            //Act
            FractionClass obj = new FractionClass();
            Action actual = () => obj.FixWrongResult(text);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            string text = "35/10/10/25";
            //Act
            FractionClass obj = new FractionClass();
            Action actual = () => obj.FixWrongResult(text);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            string text = "10/1b";
            //Act
            FractionClass obj = new FractionClass();
            Action actual = () => obj.FixWrongResult(text);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }

        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            string text = "1010";
            //Act
            FractionClass obj = new FractionClass();
            Action actual = () => obj.FixWrongResult(text);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }
    }
}
