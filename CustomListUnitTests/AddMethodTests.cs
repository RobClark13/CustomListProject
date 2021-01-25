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
            CustomList list = new CustomList();
            string shoe = "Jordans";
            //act

            //assert


        }
    }
}
