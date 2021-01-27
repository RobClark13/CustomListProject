using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListClass;

namespace CustomListUnitTests
{
    [TestClass]
    public class ToStringMethodTests
    {
        [TestMethod]
        public void ToString_AddInt_StringValueOfNumber()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            int thirteen = 13;
            string actual;
            string expected = "13";

            //act
            list.Add(thirteen);
            actual = list.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_AddChar_StringValueOfChar()
        {
            //arrange
            CustomList<char> list = new CustomList<char>();
            char c = 'c';
            string actual;
            string expected = "c";

            //act
            list.Add(c);
            actual = list.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_AddThreeInts_AllNumbersOnOneLineWithSpaceBetweenEach()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            int three = 3;
            int thirteen = 13;
            int thirtythree = 33;
            string expected = "3 13 33";
            string actual;
            //act
            list.Add(three);
            list.Add(thirteen);
            list.Add(thirtythree);
            actual = list.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_AddThreeString_AllStringsOnOneLineWithSpaceBetweenEach()
        {
            //arrange
            CustomList<string> list = new CustomList<string>();
            string seamus = "seamus";
            string daisy = "daisy";
            string nash ="nash";
            string actual;
            string expected = "seamus daisy nash";

            //act
            list.Add(seamus);
            list.Add(daisy);
            list.Add(nash);
            actual = list.ToString();

            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void ToString_EmptyList_ReturnEmpty()
        {
            //arrange
            CustomList<string> list = new CustomList<string>();
            string expected = "";
            string actual;
            //act
            actual = list.ToString();
            //assert
            Assert.AreEqual(actual, expected);
        }
       
    }
}
