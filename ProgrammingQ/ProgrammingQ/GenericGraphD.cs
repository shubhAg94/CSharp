using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingQ
{
    public class GenericGraphD<T>
    {
        Dictionary<T, List<T>> graph = new Dictionary<T, List<T>>();

        public GenericGraphD(T[] vertices)
        {
            for (int i = 0; i < vertices.Length; i++)
                graph.Add(vertices[i], new List<T>());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <param name="biDir">if true means graph is undirected means it is bi-directional</param>
        public void AddEdge(T source, T destination, bool biDir = true)
        {
            //add edge
            graph[source].Add(destination);
            if(biDir)
            {
                //add back edge for undirected graph
                graph[destination].Add(source);
            }
        }
        public void PrintGenericGraph()
        {
            Console.WriteLine("Adjacency list of vertices:");
            foreach (var item in graph)
            {
                Console.Write($"{item.Key} -> ");
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.Write($"{item.Value[i]}, ");
                }
                Console.WriteLine();
            }
        }
    }
}
