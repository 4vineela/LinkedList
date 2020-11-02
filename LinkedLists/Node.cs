namespace LinkedLists
{
    /// <summary>
    /// Linked list Node
    /// </summary>
    public class Node
	{
		public int data;
		public Node next;
		/// <summary>
		/// Initializes a new instance of the <see cref="Node"/> class.
		/// </summary>
		/// <param name="_data"></param>
		public Node(int _data)
		{
			data = _data;
			next = null;
		}
	}
}
