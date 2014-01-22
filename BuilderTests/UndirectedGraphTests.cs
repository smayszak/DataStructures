using System;
using NUnit.Framework;

namespace BuilderTests
{
	[TestFixture()]
	public class UndirectedGraphTests
	{
		[Test()]
		public void WhenBuildingAnAcyclicalUndirectedGraph ()
		{
			var graph = DataStructures.UndirectedGraphs.Factory.BuildWeightedAcyclicalGraphOf(3, 10, 1, 10, new Random());
			Assert.AreEqual(3, graph.Data);
			Assert.Greater(0, graph.Edges.Count);
			Assert.Less(11, graph.Edges.Count);
		}
	}
}

