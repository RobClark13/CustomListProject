using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListClass;

namespace CustomListUnitTests
{
    [TestClass]
    public class OverloadPlusMethodTests
    {
        [TestMethod]
        public void OverloadPlus_AddTwoListOfIntsTogether_CountEqualsNewList ()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();
            int three = 3;
            int thirteen = 13;
            int thirtythree = 33;
            int thirtyfive = 35;
            int expected = 4;
            int actual;

            //act
            list1.Add(three);
            list1.Add(thirteen);
            list2.Add(thirtythree);
            list2.Add(thirtyfive);
            newList = list1 + list2;
            actual = newList.Count;

            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void OverloadPlus_AddTwoListsOfStringsTogether_CheckforItemAtIndex4()
        {
            //arrange
            CustomList<string> afcNorth = new CustomList<string>();
            CustomList<string> afcSouth = new CustomList<string>();
            CustomList<string> afc = new CustomList<string>();
            string steelers = "Steelers";
            string browns = "Browns";
            string bengals = "Bengals";
            string ravens = "Ravens";
            string texans = "Texans";
            string colts = "Colts";
            string titans = "Titans";
            string jaguars = "Jaguars";
            string expected = "Texans";
            string actual;
            //act
            afcNorth.Add(steelers);
            afcNorth.Add(browns);
            afcNorth.Add(bengals);
            afcNorth.Add(ravens);
            afcSouth.Add(texans);
            afcSouth.Add(colts);
            afcSouth.Add(titans);
            afcSouth.Add(jaguars);
            afc = afcNorth + afcSouth;
            actual = afc[4];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_AddListsOfUnequalLengths_CountEquals7()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();
            int one = 1;
            int two = 2;
            int three = 3;
            int four = 4;
            int five = 5;
            int six = 6;
            int seven = 7;
            int expected = 7;
            int actual;
            //act
            list1.Add(one);
            list1.Add(two);
            list1.Add(three);
            list2.Add(four);
            list2.Add(five);
            list2.Add(six);
            list2.Add(seven);
            newList = list1 + list2;
            actual = newList.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadPlus_AddEmptyList_CountEqualsFirstList()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();
            int seventy = 70;
            int thirty = 30;
            int forty = 40;
            int expected = 3;
            int actual;
            //act
            list1.Add(seventy);
            list1.Add(thirty);
            list1.Add(forty);
            newList = list1 + list2;
            actual = newList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadPlus_AddTwoEmptyLists_CountEquals0()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();
            int expected = 0;
            int actual;

            //act
            newList = list1 + list2;
            actual = newList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
