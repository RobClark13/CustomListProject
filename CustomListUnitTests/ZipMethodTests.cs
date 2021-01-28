using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListClass;

namespace CustomListUnitTests
{
    [TestClass]
    public class ZipMethodTests
    {
        [TestMethod]
        public void Zipper_ZipTwoListsOfEqualLength_CountEqualsNewList()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int> { 1, 3, 5 };
            CustomList<int> list2 = new CustomList<int> { 2, 4, 6 };
            CustomList<int> newList = new CustomList<int>();
            int actual;
            int expected = 6;
            //act
            newList = newList.Zipper(list1, list2);
            actual = newList.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipMethod_ZipTwoListsOfEqualLength_CheckIndex2()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int> { 1, 3, 5 };
            CustomList<int> list2 = new CustomList<int> { 2, 4, 6 };
            CustomList<int> newList = new CustomList<int>();
            int actual;
            int expected = 3;
            //act
            newList = newList.Zipper(list1, list2);
            actual = newList[2];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipMethod_ZipTwoListOfUnequalLength_CheckCount()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int> { 1, 3, 5, 7 };
            CustomList<int> list2 = new CustomList<int> { 2, 4, 6 };
            CustomList<int> newList = new CustomList<int>();
            int actual;
            int expected = 7;
            //act
            newList = newList.Zipper(list1, list2);
            actual = newList.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipMethod_ZipTwoListsOfUnequalLength_CheckIndex4()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int> { 1, 3, 5 };
            CustomList<int> list2 = new CustomList<int> { 2, 4, 6, 7 };
            CustomList<int> newList = new CustomList<int>();
            int actual;
            int expected = 7;
            //act
            newList = newList.Zipper(list1, list2);
            actual = newList[6];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipMethod_ZipTwoListsOfStringsEqualLength_CheckIndex3()
        {
            //arrange
            CustomList<string> list1 = new CustomList<string> { "Chicken", "Cow", "Goat" };
            CustomList<string> list2 = new CustomList<string> { "Egg", "Milk", "Goat Milk" };
            CustomList<string> newList = new CustomList<string>();
            string expected = "Milk";
            string actual;
            //act
            newList = newList.Zipper(list1, list2);
            actual = newList[3];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipMethod_ZipTwoListsOfIntsEqualLength_CheckFullList()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int> { 1, 3, 5 };
            CustomList<int> list2 = new CustomList<int> { 2, 4, 6 };
            CustomList<int> newList = new CustomList<int>();
            string expected = "1 2 3 4 5 6";
            string actual;
            //act
            newList = newList.Zipper(list1, list2);
            actual = newList.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
