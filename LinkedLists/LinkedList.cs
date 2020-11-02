// C# Program to insert in a sorted list 
using LinkedLists;
using System;
using System.Collections.Specialized;

public class LinkedList :ILinkedList
{
	// head of list 
	Node head;
	
	/// <summary>
	/// SortedInsert inserts a newNode in a list
	/// </summary>
	/// <param name="newNode">A new node to be inserted</param>
	public void SortedInsert(Node newNode)
	{
		Node current;

		/* Special case for head node */
		if (head == null || head.data >= newNode.data)
		{
			newNode.next = head;
			head = newNode;
		}
		else
		{
			/* Locate the node before point of insertion. */
			current = head;
			while (current.next != null && current.next.data < newNode.data)
				current = current.next;

			newNode.next = current.next;
			current.next = newNode;
		}
	}

	/// <summary>
	/// Function to create a node
	/// </summary>
	/// <param name="data"></param>
	/// <returns></returns>
	public Node NewNode(int data)
	{
		Node newNode = new Node(data);
		return newNode;
	}

	/// <summary>
	/// This function used to determine size of the linkedlist
	/// </summary>
	/// <returns></returns>
	public int Size()
    {
		int _size = 0;
		Node temp = head;
		while (temp != null)
		{
			_size++;
			temp = temp.next;
		}
		return _size;
	}

	/// <summary>
	/// This function used to check if linked list is sorted.
	/// </summary>
	/// <returns></returns>
	public bool IsSorted()
    {
		bool bRet = true;
		Node temp = head;
		while (temp != null && temp.next !=null)
		{
			if(temp.data>(temp.next).data)
            {
				bRet = false;
				break;
            }
			temp = temp.next;
		}

		return bRet;
	}

	/// <summary>
	/// Function to print linked list
	/// </summary>
	public void PrintList()
	{
		Node temp = head;
		while (temp != null)
		{
			Console.Write(temp.data + " ");
			temp = temp.next;
		}
	}



	/// <summary>
	/// This is driver funtion to live demo interactivelly
	/// </summary>
	public void InteractiveDemo()
    {
		Node new_node;
		bool moreTry = true;
		int choice;
		while (moreTry)
        {
			Console.WriteLine("*****SORTED LINKEDLIST OPERATION*****");
			Console.WriteLine("1. Add new element");
			Console.WriteLine("2. Display list");
			Console.WriteLine("3.Exit");
			Console.WriteLine("Enter your options:");
			choice = Convert.ToInt32(Console.ReadLine());
			switch (choice)
            {
				case 1:
					int element;
					Console.WriteLine("Eneter the element to be added:");
					element = Convert.ToInt32(Console.ReadLine());
					new_node = NewNode(element);
					SortedInsert(new_node);
					break;
				case 2:
					Console.WriteLine("Elements of the sorted list are:");
					PrintList();
					Console.WriteLine();
					break;
				case 3:
					moreTry = false;
					break;
				default:
					Console.WriteLine("Select valid choice:");
					break;
			}
		}
	}

	/* Driver code */
	public static void Main(String[] args)
	{
		LinkedList llist = new LinkedList();
		Node new_node;
		new_node = llist.NewNode(5);
		llist.SortedInsert(new_node);

		new_node = llist.NewNode(10);
		llist.SortedInsert(new_node);

		new_node = llist.NewNode(7);
		llist.SortedInsert(new_node);

		new_node = llist.NewNode(3);
		llist.SortedInsert(new_node);

		new_node = llist.NewNode(1);
		llist.SortedInsert(new_node);

		new_node = llist.NewNode(9);
		llist.SortedInsert(new_node);

		Console.WriteLine("Created Linked List");
		llist.PrintList();

		Console.ReadLine();
	}
}
