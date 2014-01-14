using System;
using NUnit.Framework;
using DataStructures.Tree;

namespace BuilderTests
{
	[TestFixture()]
	public class TreeBuilderTests
	{
		[Test()]
		public void UnbalancedTreeIsUnbalanced ()
		{
			var root = Builder.CreateUnbalancedTree();
			var unbalanced = !IsBalanced(root);
			Assert.IsTrue (unbalanced);
		}

		[Test()]
		public void BalancedTreeIsBalanced ()
		{
			var root = Builder.CreateBalancedTree(10);
			var balanced = IsBalanced(root);
			Assert.IsTrue (balanced);
		}

		private static bool IsBalanced(Node node){
			var leftHeight = MaxHeight(node, 1);
			var rightHeight = MinHeight(node, 1);

			var diff = leftHeight < rightHeight ? rightHeight - leftHeight : leftHeight - rightHeight;
			if(diff < 2)
				return true;
			return false;
		}

		private static int MaxHeight(Node node, int level){

			if(node == null || (node.Left == null && node.Right == null))
				return level;
			level = level + 1;
			int left = MaxHeight(node.Left, level);
			int right = MaxHeight(node.Right, level);

			if(left < right)
				return right;
			return left;
		}

		private static int MinHeight(Node node, int level){
			if(node == null || node.Left == null || node.Right == null)
				return level;
			level = level + 1;
			int left = MinHeight(node.Left, level);
			int right = MinHeight(node.Right, level);

			if(left > right)
				return right;
			return left;
		}
	}
}

