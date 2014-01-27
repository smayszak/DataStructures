using System;
using NUnit.Framework;
using System.Collections.Generic;
using DataStructures.Graphs;

namespace BuilderTests
{
	[TestFixture ()]
	public class GraphBuilderTests
	{
		[Test]
		public void TheTotalEdgesMatchTheNumberOfWeightsPresentedToTheFactory()
		{
			var cities = new List<string> () {
				"chicago",
				"seattle",
				"new york",
				"san francisco",
				"dallas",
				"memphis",
				"atlanta",
				"miami"
			};

			var weights = new List<int> (){ 5, 2, 67, 3, 45, 11, 5, 23, 10, 33, 100, 431, 332, 899, 101, 80, 23, 512, 9120 };

			var graph = Factory.BuildDirectedGraphRandomlyForEachWeight (cities, weights);

			Assert.AreEqual(cities.Count, graph.Vertices.Count);
			var countEdges = 0;
			foreach (var vertex in graph.Vertices) {
				countEdges += vertex.Edges.Count;
			}
			Assert.AreEqual (countEdges, weights.Count);
			//cant really test anything since it is created randomly
		}
	}
}

