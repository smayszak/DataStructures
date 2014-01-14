using System;

namespace DataStructures.BinaryTree
{
	public class Factory
	{
		public Factory ()
		{
		}

		public static Node CreateUnbalancedTree ()
		{
			//              x
			//           /     \
			//          x       x
			//        /   \    /
			//       x    x    x
			//      /
			//     x

			Node head = new Node();
			head.Left = new Node();
			head.Right = new Node();
			head.Left.Left = new Node();
			head.Left.Right = new Node();
			head.Right.Left = new Node();
			head.Left.Left.Left = new Node();
			return head;
		}

		public static Node CreateBalancedTree (int num_nodes)
		{
			//use max heap to use an array for construction
 			Node[] nodeArray = new Node[num_nodes];

			for (int indexValue = 0; indexValue < num_nodes; indexValue++) {
				nodeArray [indexValue] = new Node (){ArrayIndex = indexValue};
			}
			//heap property to do some building:
			for (int index = 0; index < num_nodes; index++) {
				int roundableIndex = index + 1;//because index math works better on indexes starting at 1
				int parentIndex = (roundableIndex / 2) -1;
				int leftIndex = (2*roundableIndex) -1;
				int rightIndex = ((2*roundableIndex) + 1) -1;
				if (parentIndex > -1){
					nodeArray[index].Parent = nodeArray[parentIndex];
				}
				if(leftIndex < num_nodes){
					nodeArray[index].Left = nodeArray[leftIndex];
				}
				if(rightIndex < num_nodes){
					nodeArray[index].Right = nodeArray[rightIndex];
				}
			}
			OrderNodes(nodeArray[0], num_nodes);
			return nodeArray[0];
		}

		private static int OrderNodes (Node node, int val)
		{
			if (node == null) {
				return val;
			}
			val = OrderNodes (node.Right, val);
			node.Value = val;
			if(node.Left == null)
				return val -1;
			val = OrderNodes (node.Left, val -1);
			return val;
		}
	}
}

