using System;

namespace DataStructures.RedBlackTree
{
	public class Factory<T> where T :IComparable<T>
	{
		//1. Every node is either red = f or black = t
		//2. The root is black
		//3. Every leaf (sentinal node) is black
		//4. If a node is red, both children are black.
		//5. For any node all paths to descendant leaves contain the same number of black nodes
		public static Node<int> BuildFor(int[] array){
			Node<int> head = null;
			var f = new Factory<int> ();
			foreach (var i in array) {
				head = f.Build (head, i);
			}
			return head;
		}

		public static Node<char> BuildForCharsIn(string word){
			Node<char> head = null;
			var f = new Factory <char>();
			foreach (var c in word.ToCharArray()) {
				head = f.Build (head, c);
			}
			return head;
		}

		public Node<T> Build(Node<T> head, T newValue){
			var newNode = new Node<T> ();
			newNode.Data = newValue;

			if (head == null) {
				//rule #2
				head = newNode;
				head.Black = true;
				return head;
			}

			//head is not null. apply BST property of insertion.
			head = InsertInto (head, head, newNode);
			//now we need to balance it
			return head;
		}

		private Node<T> InsertInto(Node<T> trailing, Node<T> node, Node<T> newNode){
			var compare = node.CompareTo (newNode.Data);
			var childrenNull = node.Left == null && node.Right == null;
			if (compare  == 0) {//equal
			} else if (compare == -1) {//greater than current
				if (childrenNull && trailing != node) {
					return PushNodeLeft (node, newNode);
				} else {
				}
				if (node.Right == null) {
					node.Right = newNode;
					AlterColor (node.Black, node, node.Right);
					return node;
				}
				return InsertInto (node, node.Right, newNode);

			} else {//less than current
				if (node.Left == null) {
					node.Left = newNode;
					AlterColor (node.Black, node, node.Left);
					return node;
				}
			}
			return node;
		}

		private Node<T> PushNodeLeft(Node<T> node, Node<T> newNode){
			var nodeIsBlack = node.Black;
			var temp = node;
			node = newNode;
			node.Left = temp;
			AlterColor (nodeIsBlack, node, node.Left);
			return node;
		}
		private Node<T> PushNodeRight(Node<T> node, Node<T> newNode){
			var nodeIsBlack = node.Black;
			var temp = node;
			node = newNode;
			node.Right = temp;
			AlterColor(nodeIsBlack, node, node.Right);
			return node;
		}
		private void AlterColor(bool parentColor, Node<T> parent, Node<T> child){
			parent.Black = parentColor;
			if (parent.Black) {
				if (parent.Left == child) {
					child.Black = false;
				} else {
					child.Black = true;
				}
			} else {
				child.Black = true;
			}
		}
	}
}

