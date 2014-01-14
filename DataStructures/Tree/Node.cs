using System;

namespace DataStructures.Tree
{
	public class Node
	{
		public int Value { get; set; }
		public int ArrayIndex { get; set; }
		public Node Parent { get; set; }
		public Node Left { get; set; }
		public Node Right { get; set; }
	}
}

