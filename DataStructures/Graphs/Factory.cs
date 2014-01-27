using System;
using System.Collections.Generic;

namespace DataStructures.Graphs
{
	public class Factory
	{
		public static Graph<string, int> BuildDirectedGraphRandomlyForEachWeight(List<string> names, List<int> weights){
			var vertices = new Vertex<string,int>[names.Count];
			for (var index = 0; index < vertices.Length; index++) {
				vertices [index] = new Vertex<string,int> (){ Data = names [index] }; 
			}
			var g = new Graph<string, int> ();
			foreach (var v in vertices) {
				g.AddVertex (v);
			}
			if (weights.Count == 0) {
				return g;
			}

			var random = new Random ();

			foreach (var weight in weights) {
				//get two random indexes for the vertices that we will use
				var indexA = random.Next (vertices.Length);
				var indexB = indexA;
				if (vertices.Length < 3) {
					//special cases
					switch (weights.Count) {
					case 2:
						indexB = indexA == 0 ? 1 : 0;
						break;
					case 1:
					default:
						break;
					}
				} else {
					while (indexB == indexA) {
						indexB = random.Next (vertices.Length);
					}
				}

				if (indexA != indexB) {
					g.AddEdge (vertices [indexA], vertices [indexB], weight);
				}
			}
			return g;
		}
	}
}

