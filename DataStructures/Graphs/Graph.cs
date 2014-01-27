using System;
using System.Collections.Generic;

namespace DataStructures.Graphs
{
	public class Graph<VertexDataType, WeightType>
	{
		public List<Vertex<VertexDataType,WeightType>> Vertices { get; set; }
		public Graph ()
		{
			Vertices = new List<Vertex<VertexDataType,WeightType>> ();
		}

		public void AddVertex(Vertex<VertexDataType,WeightType> v){
			Vertices.Add (v);
		}

		public void AddEdge(Vertex<VertexDataType,WeightType> to, Vertex<VertexDataType,WeightType> from, WeightType weight){
			var edge = new Edge<VertexDataType, WeightType> ();
			edge.Weight = weight;
			edge.Left = from;
			edge.Right = to;
			from.Edges.Add (edge);
			if (!Vertices.Contains (from)) {
				Vertices.Add (from);
			} 
		}
	}
}

