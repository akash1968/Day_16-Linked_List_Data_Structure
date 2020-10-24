using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day_16_LinkedList_Sec1;

namespace MSTestForLinkedList
{
    [TestClass]
    public class UnitTest1
    {
        [DataRow(30)]
        [TestMethod]
        public void SearchForElementTest(int value)
        {
            //Arrange
            bool expected = false;
            LinkedList list = new LinkedList();
            //Act
            bool actual = list.Search(value);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
