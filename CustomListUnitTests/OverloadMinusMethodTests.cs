using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListClass;

namespace CustomListUnitTests
{
    [TestClass]
    public class OverloadMinusMethodTests
    {
        [TestMethod]
        public void OverloadMinus_RemoveOneInstance_CountEqualsNewList()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int> { 1, 2, 3, 4 };
            CustomList<int> list2 = new CustomList<int> { 1, 5, 6, 7 };
            CustomList<int> newList;
            int actual;
            int expected = 3;

            //act
            newList = list1 - list2;
            actual = newList.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadMinus_RemoveTwoItems_CountEqualsNewList()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int> { 13, 25, 30, 40 };
            CustomList<int> list2 = new CustomList<int> { 33, 43, 13, 25 };
            CustomList<int> newList;
            int actual;
            int expected = 2;

            //act
            newList = list1 - list2;
            actual = newList.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadMinus_RemoveInstanceOfString_CountEqualsNewList()
        {
            //arrange
            CustomList<string> list1 = new CustomList<string> { "Red Wings", "Rangers", "Blackhawks" };
            CustomList<string> list2 = new CustomList<string> { "Bluejackets", "Blackhawks", "Predators" };
            CustomList<string> newList;
            int actual;
            int expected = 2;
            //act
            newList = list1 - list2;
            actual = newList.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadMinus_UnequalLists_CountEqualsNewList()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int> { 13, 25, 30, 40 };
            CustomList<int> list2 = new CustomList<int> { 30, 43, 55};
            CustomList<int> newList;
            int expected = 3;
            int actual;
            //act
            newList = list1 - list2;
            actual = newList.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadMinus_RemoveOneInstance_CheckIndex()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int> { 44, 23, 45 };
            CustomList<int> list2 = new CustomList<int> { 22, 44, 69 };
            CustomList<int> newList;
            int expected = 45;
            int actual;
            //act
            newList = list1 - list2;
            actual = newList[1];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadMinus_RemoveInstanceOfString_CheckIndex()
        {
            //arrange
            CustomList<string> list1 = new CustomList<string> { "Rob", "Courtney", "Faith", "Seamus" };
            CustomList<string> list2 = new CustomList<string> { "Faith", "Nash", "Daisy" };
            CustomList<string> newList;
            string actual;
            string expected = "Seamus";
            //act
            newList = list1 - list2;
            actual = newList[2];
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
