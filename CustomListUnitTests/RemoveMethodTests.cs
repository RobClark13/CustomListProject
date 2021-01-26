using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListClass;

namespace CustomListUnitTests
{
    [TestClass]
    public class RemoveMethodTests
    {
        [TestMethod]
        public void Remove_ItemFromCustomListAFterAddingTwoItems_CountEquals1()
        {
            //arrange
            CustomList<string> list = new CustomList<string>();
            string lime = "lime";
            string lemon = "lemon";
            int actual;
            int expected = 1;
            //act
            list.Add(lime);
            list.Add(lemon);
            list.Remove(lime);
            actual = list.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_DuplicateItemFromList_OnlyFirstInstanceRemoved()
        {
            //arrange
            CustomList<string> list = new CustomList<string>();
            string hockey = "Hockey";
            string basketball = "Basketball";
            string football = "Football";
            string tennis = "Tennis";
            string actual;
            string expected = "Basketball";

            //act
            list.Add(hockey);
            list.Add(hockey);
            list.Add(basketball);
            list.Add(football);
            list.Add(tennis);
            list.Remove("Hockey");
            actual = list[1];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_ItemNotInList_CountStaysTheSame()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            int one = 1;
            int thirteen = 13;
            int twentyfive = 25;
            int expected = 2;
            int actual;
            //act
            list.Add(one);
            list.Add(thirteen);
            list.Remove(twentyfive);
            actual = list.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_ItemNotInList_ReturnsFalse()
        {
            //arrange
            CustomList<string> list = new CustomList<string>();
            string godzilla = "Godzilla";
            string rodan = "Rodan";
            string mothra = "Mothra";
            string kingKong = "King Kong";
            bool expected = false;
            bool actual;
            //act
            list.Add(godzilla);
            list.Add(rodan);
            list.Add(mothra);
            actual = list.Remove(kingKong);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Remove_()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            int actual;
            int one = 1;
            int two = 2;

            //act
            list.Add(one);
            list.Add(two);
            list.Remove(two);
            actual = list[1];
        }
        [TestMethod]
        public void Remove_ItemNotInList_CountStays3()
        {
            //arrange
            CustomList<string> list = new CustomList<string>();
            string godzilla = "Godzilla";
            string rodan = "Rodan";
            string mothra = "Mothra";
            string kingKong = "King Kong";
            int expected = 3;
            int actual;
            //act
            list.Add(godzilla);
            list.Add(rodan);
            list.Add(mothra);
            list.Remove(kingKong);
            actual = list.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_Item_ReturnsTrue()
        {
            //arrange
            CustomList<string> list = new CustomList<string>();
            string godzilla = "Godzilla";
            string rodan = "Rodan";
            string mothra = "Mothra";
            bool expected = true;
            bool actual;
            //act
            list.Add(godzilla);
            list.Add(rodan);
            list.Add(mothra);
            actual = list.Remove(mothra);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
