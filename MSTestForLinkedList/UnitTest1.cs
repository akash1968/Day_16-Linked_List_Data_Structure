// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akash Kumar Singh"/>
// --------------------------------------------------------------------------------------------------------------------
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day_16_LinkedList_Sec1;

namespace MSTestForLinkedList
{
    [TestClass]
    public class UnitTest1
    {
        [DataRow(30, 40)]
        [TestCategory("Testing the position of the node")]
        [TestMethod]
        public void EnterAfterPositionTest(int value, int position)
        {
            //Arrange
            LinkedList list = new LinkedList();
            //Act
            int expected = 40;
            int actual = list.InsertAtParticularPosition(30, 40);
           //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
