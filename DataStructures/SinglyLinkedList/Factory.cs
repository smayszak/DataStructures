using System;

namespace DataStructures.SinglyLinkedList
{
	public class Factory
	{
		public static Node<T> CreateFor<T> (T[] data)
		{
			var head = new Node<T> ();
			if (data == null || data.Length == 0)
				return head;

			head.Data = data [0];
			Node<T> previous = head;
			for (var index = 1; index < data.Length; index++) {
				var newNode = new Node<T>();
				previous.Next = newNode;
				newNode.Data = data[index];
				previous = newNode;
			}

			return head;
		}

		public static Node<int> Create(int count)
		{
			var intData = new int[count];
			for (var i = 0; i < count; i++) {
				intData[i] = i;
			}
			return CreateFor(intData);
		}
	}
}

