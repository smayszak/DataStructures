using System;
using System.Collections.Generic;

namespace DataStructures.Graphs
{
	public class Vertex<DataType, WeightDataType>
	{
		public DataType Data { get; set; }
		public List<Edge<DataType, WeightDataType>> Edges { get; set; }
		public Vertex(){
			Edges = new List<Edge<DataType, WeightDataType>> ();
		}
	}
}

