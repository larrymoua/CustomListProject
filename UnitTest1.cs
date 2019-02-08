using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTestMethod1()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 3;
            int expectedResult = 1;
            //Act
            myList.Add(value);

            //Assert
            Assert.AreEqual(expectedResult, myList.Count);
        }
        [TestMethod]
        public void AddTestMethod2()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 3;
            int expectedResult = 3;
            //Act
            myList.Add(value);

            //Assert
            Assert.AreEqual(expectedResult, myList[0]);
        }
        [TestMethod]
        public void AddTestMethod3()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 3;
            int value1 = 5;
            int expectedResult = 3;
            //Act
            myList.Add(value);
            myList.Add(value1);

            //Assert
            Assert.AreEqual(expectedResult, myList[0]);
        }
        [TestMethod]
        public void AddTestMethod4()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 3;
            int value1 = 5;
            int expectedResult = 5;
            //Act
            myList.Add(value);
            myList.Add(value1);

            //Assert
            Assert.AreEqual(expectedResult, myList[1]);
        }
        [TestMethod]
        public void AddTestMethod5()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 3;
            int value1 = 5;
            int value2 = 6;
            int expectedResult = 6;
            //Act
            myList.Add(value);
            myList.Add(value1);
            myList.Add(value2);

            //Assert
            Assert.AreEqual(expectedResult, myList[2]);
        }
        [TestMethod]
        public void AddTestMethod6()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 3;
            int value1 = 5;
            int value2 = 6;
            int value3 = 8;
            int value4 = 18;
            int value5 = 38;
            int value6 = 28;
            int value7 = 81;

            int expectedResult = 28;
            //Act
            myList.Add(value);
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            myList.Add(value6);
            myList.Add(value7);

            //Assert
            Assert.AreEqual(expectedResult, myList[6]);
        }
        [TestMethod]
        public void Add13Values()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 3;
            int value1 = 5;
            int value2 = 6;
            int value3 = 8;
            int value4 = 18;
            int value5 = 38;
            int value6 = 28;
            int value7 = 81;
            int value8 = 81;
            int value9 = 81;
            int value10 = 81;
            int value11 = 82;
            int value12 = 82;
            int value13 = 81;

            int expectedResult = 81;
            //Act
            myList.Add(value);
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            myList.Add(value6);
            myList.Add(value7);
            myList.Add(value8);
            myList.Add(value9);
            myList.Add(value10);
            myList.Add(value11);
            myList.Add(value12);
            myList.Add(value13);

            //Assert
            Assert.AreEqual(expectedResult, myList[13]);
        }
        [TestMethod]
        public void AddStringMethod1()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            string value = "Tom";
            int expectedResult = 1;
            //Act
            myList.Add(value);

            //Assert
            Assert.AreEqual(expectedResult, myList.Count);
        }
        [TestMethod]
        public void AddStringMethod2()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            string value = "Tom";
            string value1 = "bob";
            string expectedResult = "bob";
            //Act
            myList.Add(value);
            myList.Add(value1);

            //Assert
            Assert.AreEqual(expectedResult, myList[1]);
        }
        [TestMethod]
        public void RemoveTestMethod1()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 3;
            int expectedResult = 0;
            //Act
            myList.Add(value);
            myList.Remove(value);

            //Assert
            Assert.AreEqual(expectedResult, myList.Count);
        }
        [TestMethod]
        public void RemoveTestMethod2()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 3;
            int value1 = 5;
            int expectedResult = 5;
            //Act
            myList.Add(value);
            myList.Add(value1);
            myList.Remove(value1);

            //Assert
            Assert.AreEqual(expectedResult, myList[0]);
        }
        [TestMethod]
        public void RemoveTestMethod3()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 3;
            int expectedResult = 0;
            //Act
            myList.Remove(value);

            //Assert
            Assert.AreEqual(expectedResult, myList.Count);
        }
        [TestMethod]
        public void RemoveTestMethod4()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 3;
            int expectedResult = 0;
            //Act
            myList.Remove(value);

            //Assert
            Assert.AreEqual(expectedResult, myList.Count);
        }
        [TestMethod]
        public void RemoveTestMethod5()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 3;
            int expectedResult = 0;
            //Act
            myList.Remove(value);

            //Assert
            Assert.AreEqual(expectedResult, myList.Count);
        }
    }

}
