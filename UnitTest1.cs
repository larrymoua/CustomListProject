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
        public void AddMethod13Values()
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
            myList.Remove(3);

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
            myList.Remove(3);

            //Assert
            Assert.AreEqual(expectedResult, myList[0]);
        }
        [TestMethod]
        public void RemoveTestMethod3()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 3;
            int value1 = 5;
            int value2 = 8;
            int expectedResult = 8;
            //Act
            myList.Add(value);
            myList.Add(value1);
            myList.Add(value2);
            myList.Remove(3);
            myList.Remove(5);

            //Assert
            Assert.AreEqual(expectedResult, myList[0]);
        }
        [TestMethod]
        public void RemoveTestMethod5()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 3;
            int value1 = 5;
            int value2 = 8;
            int expectedResult = 5;
            //Act
            myList.Add(value);
            myList.Add(value1);
            myList.Add(value2);
            myList.Remove(3);
            myList.Remove(8);

            //Assert
            Assert.AreEqual(expectedResult, myList[0]);
        }
        [TestMethod]
        public void RemoveTestMethod4()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 3;
            int value1 = 5;
            int value2 = 8;
            int expectedResult = 1;
            //Act
            myList.Add(value);
            myList.Add(value1);
            myList.Add(value2);
            myList.Remove(3);
            myList.Remove(8);

            //Assert
            Assert.AreEqual(expectedResult, myList.Count);
        }
        [TestMethod]
        public void RemoveTestMethod6()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 3;
            int value1 = 5;
            int value2 = 8;
            int expectedResult = 8;
            //Act
            myList.Add(value);
            myList.Add(value1);
            myList.Add(value2);
            myList.Remove(3);

            //Assert
            Assert.AreEqual(expectedResult, myList[1]);
        }
        [TestMethod]
        public void RemoveStringMethod7()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            string value = "hi";
            string value1 = "dad";
            string value2 = "bod";
            string expectedResult = "bod";
            //Act
            myList.Add(value);
            myList.Add(value1);
            myList.Add(value2);
            myList.Remove("hi");
            myList.Remove("dad");

            //Assert
            Assert.AreEqual(expectedResult, myList[0]);
        }
        [TestMethod]
        public void ToStringMethodStrings3Values()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            string value = "hi";
            string value1 = "dad";
            string value2 = "bod";
            string expectedResult = "hidadbod";
           
            //Act
            myList.Add(value);
            myList.Add(value1);
            myList.Add(value2);
            string actualResult = myList.ToString();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void ToStringMethodInts()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 4;
            int value1 = 3;
            int value2 = 1;
            string expectedResult = "431";

            //Act
            myList.Add(value);
            myList.Add(value1);
            myList.Add(value2);
            string actualResult = myList.ToString();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void ToStringMethod6Values()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>() {1,2,3,4,5,6 };
            string expectedResult = "123456";
            //Act
            string actualResult = myList.ToString();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void ToStringMethod13Values()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>() { 1, 2, 3, 4, 5, 6 ,7,8,9,10,11,12,13};
            string expectedResult = "12345678910111213";
            //Act
            string actualResult = myList.ToString();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    
        [TestMethod]
        public void ToStringMethodRemove()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>() {4,8,9,6,3,2,1};
            string expectedResult = "489631";
            //Act
            myList.Remove(2);           
            string actualResult = myList.ToString();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AddOperator()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>() { 1, 3, 2 };
            CustomList<int> myList1 = new CustomList<int>() { 3, 1, 1 };

            int expectedResult = 1;
         
            //Act
            CustomList<int> customList = myList + myList1;
            
            //Assert
            Assert.AreEqual(expectedResult, customList[5]);
            
        }
        [TestMethod]
        public void AddOperator13valuesEachList()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>() {1,2,3,4,5,6,7,8,9,10,11,12,13};
            CustomList<int> myList1 = new CustomList<int>() {12,11,10,9,8,7,6,5,4,3,2,1};

            int expectedResult = 13;

            //Act
            CustomList<int> customList = myList + myList1;

            //Assert
            Assert.AreEqual(expectedResult, customList[12]);

        }
        [TestMethod]
        public void AddOperatorCheckCount()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            CustomList<int> myList1 = new CustomList<int>() {13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            int expectedResult = 26;

            //Act
            CustomList<int> customList = myList + myList1;

            //Assert
            Assert.AreEqual(expectedResult, customList.Count);

        }
        [TestMethod]
        public void AddOperatorRemoveAndCheckCount()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>() { 1, 3, 2 };
            CustomList<int> myList1 = new CustomList<int>() { 3, 1, 1 };

            int expectedResult = 5;

            //Act
            CustomList<int> customList = myList + myList1;
            customList.Remove(2);

            //Assert
            Assert.AreEqual(expectedResult, customList.Count);

        }
            [TestMethod]
        public void AddOperatorAddandRemoveCheckIndex()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>() { 1, 3, 2 };
            CustomList<int> myList1 = new CustomList<int>() { 3, 1, 1 };

            int expectedResult = 5;

            //Act
            CustomList<int> customList = myList + myList1;
            customList.Remove(1);
            customList.Add(5);

            //Assert
            Assert.AreEqual(expectedResult, customList[3]);

        }
        [TestMethod]
        public void SubtractOperator()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>() { 1, 3, 2 };
            CustomList<int> myList1 = new CustomList<int>() { 3, 1, 1 };

            int expectedResult = 2;

            //Act
            CustomList<int> customList = myList - myList1;

            //Assert
            Assert.AreEqual(expectedResult, customList[0]);

        }
        [TestMethod]
        public void ZipperMethod()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>() { 1, 3, 2 };
            CustomList<int> myList1 = new CustomList<int>() { 3, 1, 1 };

            CustomList<int> customList = new CustomList<int>();
            int expectedResult = 6;
            //Act
            customList = CustomList<int>.Zip(myList,myList1);
            //Assert
            Assert.AreEqual(expectedResult, customList.Count);

        }
        [TestMethod]
        public void ZipperMethod1()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>() { 1, 3, 2 };
            CustomList<int> myList1 = new CustomList<int>() { 3, 1, 1 };

            CustomList<int> customList = new CustomList<int>();
            int expectedResult = 3;
            //Act
            customList = CustomList<int>.Zip(myList, myList1);
            //Assert
            Assert.AreEqual(expectedResult, customList[1]);

        }
        [TestMethod]
        public void ZipperMethod2()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>() { 1, 3, 2 };
            CustomList<int> myList1 = new CustomList<int>() { 3, 1, 1 };

            CustomList<int> customList = new CustomList<int>();
            int expectedResult = 1;
            //Act
            customList = CustomList<int>.Zip(myList, myList1);
            //Assert
            Assert.AreEqual(expectedResult, customList[5]);

        }
        [TestMethod]
        public void ZipperMethod3()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>() { 1, 3, 2 };
            CustomList<int> myList1 = new CustomList<int>() { 3, 1, 1 };

            CustomList<int> customList = new CustomList<int>();
            int expectedResult = 3;
            //Act
            customList = CustomList<int>.Zip(myList, myList1);
            //Assert
            Assert.AreEqual(expectedResult, customList[2]);

        }
    }
}