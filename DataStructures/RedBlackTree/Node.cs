using System;

namespace DataStructures.RedBlackTree
{
	public class Node<T> where T : IComparable<T>
	{
		public bool Black { get; set; }
		public T Data { get; set; }
		public Node<T> Left {get;set;}
		public Node<T> Right { get; set; }

		public int CompareTo(T other)
		{
			if (other == null) return 1;

			return Data.CompareTo(other);
		}
	}
}

