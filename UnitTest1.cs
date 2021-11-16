
using Microsoft.VisualStudio.TestTools.UnitTesting;
using practice_linkedlist;

namespace UC7
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestCaseForSearchANode()
        {
            //Arrange
            var searchTest = new practice_linkedlist.testFunctions();
            searchTest.Add(56);
            searchTest.Add(30);
            searchTest.Add(70);
           
            ///Actual
            var result = searchTest.Search(30);
            //Assert
            Assert.AreEqual(true, result);


        }

        [TestMethod]
        public void TestCaseForInsertAfter()
        {
            //Arrange
            var insertAfterNode = new practice_linkedlist.testFunctions();
            insertAfterNode.Add(70);
            insertAfterNode.Add(30);
            insertAfterNode.Add(56);

            //Act
            var result = insertAfterNode.AddAfter(30, 40);
            //search -> next check-> result

            //Assert
            Assert.AreEqual(result.next, result);
        }

        [TestMethod]
        public void TestCaseForDelete()
        {
            //Arrange
            var insertAfterNode = new practice_linkedlist.testFunctions();
            insertAfterNode.Add(70);
            insertAfterNode.Add(30);
            insertAfterNode.Add(56);
            insertAfterNode.AddAfter(30, 40);
            //Act
            var result = insertAfterNode.Delete(40);
            //search -> next check-> result

            //Assert
            Assert.AreEqual(3, result);
        }

    }
}
