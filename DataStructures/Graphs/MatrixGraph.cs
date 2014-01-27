using System;
using System.Collections.Generic;

namespace DataStructures.Graphs
{
	public class MatrixGraph<VertexDataType, WeightType>
	{
		public List<Vertex<VertexDataType,WeightType>> Vertices { get; set; }
		public MatrixGraph ()
		{
		}
	}
}

