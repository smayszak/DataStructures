using System;

namespace DataStructures.UndirectedGraphs
{
	public class Edge
	{
		public Vertice Parent { get; set; }
		public Vertice Child { get; set; }
		public int Weight { get; set; }
	}
}

