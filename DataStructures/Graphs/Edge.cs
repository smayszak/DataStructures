using System;

namespace DataStructures.Graphs
{
	public class Edge<VertexDataType, WeightType>
	{
		public WeightType Weight { get; set; }
		public Vertex<VertexDataType,WeightType> Left { get; set; }
		public Vertex<VertexDataType,WeightType> Right { get; set; }
		public Edge ()
		{
		}
	}
}

