using System;
using DataStructures.UndirectedGraphs;

namespace DataStructures.UndirectedGraphs
{
	public class Factory
	{
		public static Vertice BuildWeightedAcyclicalGraphOf(int depth, int maxEdgesPerNode, int minWeight, int maxWeight, Random random){
			if(depth == 0)
				return null;
			var vertice = new Vertice();
			vertice.Data = depth;
			vertice.Edges = new System.Collections.Generic.List<Edge>();
			var edgesToBuild = random.Next(maxEdgesPerNode);
			var newDepth = depth - 1;
			for(int edgeCounter = 0; edgeCounter < edgesToBuild; edgeCounter++){
				var edge = new Edge();
				var child = BuildWeightedAcyclicalGraphOf(newDepth, maxEdgesPerNode, minWeight, maxWeight, random);
				if(child != null){
					edge.Weight = random.Next (minWeight, maxWeight);
					edge.Parent = vertice;
					edge.Child = child;					vertice.Edges.Add (edge);
				}
			}
			return vertice;
		}
	}
}

