using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingQ
{
    public class GraphAdjacencyList
    {
        /// <summary>
        /// To add an edge in an undirected graph 
        /// </summary>
        /// <param name="adjList"></param>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        private static void AddEdge(List<List<int>> adjList, int source, int destination, bool biDir = true)
        {
            //add edge
            adjList[source].Add(destination);
            if (biDir)
            {
                //add back edge for undirected graph
                adjList[destination].Add(source);
            }
        }

        /// <summary>
        /// A utility function to print the adjacency list representation of graph 
        /// </summary>
        /// <param name="adjList"></param>
        private static void PrintGraph(List<List<int>> adjList)
        {
            for (int i = 0; i < adjList.Count; i++)
            {
                Console.WriteLine("\nAdjacency list of vertex " + i);
                for (int j = 0; j < adjList[i].Count; j++)
                {
                    Console.Write(" -> " + adjList[i][j]);
                }
                Console.WriteLine();
            }
        }

        public static void CreateListGraph()
        {
            // Creating a graph with 5 vertices 
            int V = 5;
            List<List<int>> adjList = new List<List<int>>(V);

            for (int i = 0; i < V; i++)
                adjList.Add(new List<int>());

            // Adding edges one by one 
            AddEdge(adjList, 0, 1);
            AddEdge(adjList, 0, 4);
            AddEdge(adjList, 1, 2);
            AddEdge(adjList, 1, 3);
            AddEdge(adjList, 1, 4);
            AddEdge(adjList, 2, 3);
            AddEdge(adjList, 3, 4);

            PrintGraph(adjList);
        }

        private static void AddEdgeDictionary(Dictionary<int, List<int>> dictGraph, int source, int destination, bool biDir = true)
        {
            //add edge
            dictGraph[source].Add(destination);
            if (biDir)
            {
                //add back edge for undirected graph
                dictGraph[destination].Add(source);
            }
        }
        public static void CreateDictionaryGraph()
        {
            // Creating a graph with 5 vertices
            var vertices = new int[5] { 0, 1, 2, 3, 4 };
            Dictionary<int, List<int>> dictGraph = new Dictionary<int, List<int>>();
            for (int i = 0; i < vertices.Length; i++)
                dictGraph.Add(vertices[i], new List<int>());

            // Adding edges one by one 
            AddEdgeDictionary(dictGraph, 0, 1);
            AddEdgeDictionary(dictGraph, 0, 4);
            AddEdgeDictionary(dictGraph, 1, 2);
            AddEdgeDictionary(dictGraph, 1, 3);
            AddEdgeDictionary(dictGraph, 1, 4);
            AddEdgeDictionary(dictGraph, 2, 3);
            AddEdgeDictionary(dictGraph, 3, 4);

            PrintDictionaryGraph(dictGraph);
            //Ref
            //dictGraph[1] = new List<int> { 2, 3, 4 };
            //dictGraph[2] = new List<int> { 1, 3, 4 };
            //dictGraph[3] = new List<int> { 1, 2, 4 };
            //dictGraph[4] = new List<int> { 1, 2, 3, 5 };
            //dictGraph[5] = new List<int> { 4, 6 };
            //dictGraph[6] = new List<int> { 5 };
        }
        private static void PrintDictionaryGraph(Dictionary<int, List<int>> dictGraph)
        {
            foreach (var item in dictGraph)
            {
                Console.WriteLine("\nAdjacency list of vertex " + item.Key);
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.Write(" -> " + item.Value[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
