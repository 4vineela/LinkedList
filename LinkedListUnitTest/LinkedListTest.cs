using LinkedLists;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedListUnitTest
{
    
    [TestClass]
    public class LinkedListTest
    {
        [TestMethod]
        public void TestSortedInsert()
        {
            Node new_node;
            LinkedList llist = new LinkedList();
            llist.InteractiveDemo();
            new_node = llist.NewNode(5);
            llist.SortedInsert(new_node);
            new_node = llist.NewNode(25);
            llist.SortedInsert(new_node);
            Assert.IsNotNull(llist);
            Assert.AreEqual(llist.Size(), 2);
        }

        [TestMethod]
        public void TestSortedOrder()
        {
            Node new_node;
            LinkedList llist = new LinkedList();
            llist.InteractiveDemo();
            new_node = llist.NewNode(5);
            llist.SortedInsert(new_node);
            new_node = llist.NewNode(25);
            llist.SortedInsert(new_node);
            new_node = llist.NewNode(15);
            llist.SortedInsert(new_node);
            Assert.AreEqual(llist.IsSorted(), true);

        }
    }
}
