using System;

namespace DataStructures.SinglyLinkedList
{
	public class Node<T>
	{
		public Node<T> Next { get; set; }
		public T Data { get; set; }
		public Node ()
		{
		}
	}
}

