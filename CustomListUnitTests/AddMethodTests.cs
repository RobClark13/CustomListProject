using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListClass;

namespace CustomListUnitTests
{
    [TestClass]
    public class AddMethodTests
    {
        
        //How do we know we've successfully added somthing to our CustomList
        //Count goes up whwen we add?
        //test taht the item was added to the right index (indexes outside of zero)
        //test for different types of data working correctly
        //
        //
        [TestMethod]
        public void AddItemToCustomList_CheckCountEquals1()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string shoe = "Jordans";
            int actual;
            int expected = 1;
            //act
            list.Add(shoe);
            actual = list.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddItemToCustomList_CheckForItemAtIndex0()
        {
            //arrange
            CustomList<string> list = new CustomList<string>();
            string expected = "Pippin";
            string actual;
            //act
            list.Add(expected);
            actual = list[0];
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void AddItemstoCustomList_CheckForItemsAtIndex3()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string name1 = "Stephon";
            string name2 = "Marbella";
            string name3 = "JT";
            string name4 = "Rob";
            string expected = "Rob";
            string actual;
            //ACt
            list.Add(name1);
            list.Add(name2);
            list.Add(name3);
            list.Add(name4);

            actual = list[3];
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddItemsToCustomList_CheckCapacity()
        {
            //arrange
            CustomList<string> list = new CustomList<string>();
            string seamus = "Seamus";
            string daisy = "Daisy";
            string cody = "Cody";
            string nash = "Nash";
            string beethoven = "Beethoven";
            string bandit = "Bandit";
            int actual;
            int expected = 8;

            //act
            list.Add(seamus);
            list.Add(daisy);
            list.Add(cody);
            list.Add(nash);
            list.Add(beethoven);
            list.Add(bandit);
            actual = list.Capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }

    [TestMethod]
    public void AddIntegerToCustomList_CheckCountEquals1()
        {
            //arrange
            CustomList <int> list = new CustomList<int>();
            int thirteen = 13;
            int expected = 1;
            int actual;
            //act
            list.Add(thirteen);
            actual = list.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
