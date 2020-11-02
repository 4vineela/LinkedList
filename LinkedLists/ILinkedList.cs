using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    public interface ILinkedList
    {
        public void SortedInsert(Node newNode);
        public Node NewNode(int data);
        public void PrintList();
        public int Size();
        public void InteractiveDemo();
        public bool IsSorted();
    }
}
