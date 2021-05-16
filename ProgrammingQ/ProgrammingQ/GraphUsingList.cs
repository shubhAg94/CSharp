using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingQ
{
    public class GraphUsingList
    {
        List<List<int>> adjList = new List<List<int>>();
        int totalVertices;
        public GraphUsingList(int totalVertice)
        {
            this.totalVertices = totalVertice;
            for (int i = 0; i < totalVertice; i++)
                adjList.Add(new List<int>());
        }

        private void AddEdge(int source, int destination, bool biDir = true)
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
        private void PrintGraph()
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

        public void Bfs_ShortestPath(int src, int dest)
        {
            //traverse all the nodes of graph
            Queue<int> q = new Queue<int>();
            bool[] visited = new bool[totalVertices];
            int[] dist = new int[totalVertices];
            int[] parent = new int[totalVertices];
            for (int i = 0; i < totalVertices; i++)
            {
                //initializing with -1
                parent[i] = -1;
            }

            q.Enqueue(src);
            visited[src] = true;

            while (!(q.Count == 0))
            {
                int node = q.Dequeue();
                Console.Write($"{node} ");
                foreach (var neighbour in adjList[node])
                {
                    if (!visited[neighbour])
                    {
                        q.Enqueue(neighbour);
                        visited[neighbour] = true;
                        dist[neighbour] = dist[node] + 1;
                        parent[neighbour] = node;
                    }
                }
            }

            //Printing the distance of every node from source
            //for (int i = 0; i < totalVertices; i++)
            //{
            //    Console.Write($"\n{i} Node having distance : {dist[i]} ");
            //}

            Console.WriteLine($"\nShortst distance is : {dist[dest]}");
            Console.WriteLine("Shortest path is : ");
            int temp = dest;
            while (temp != -1)
            {
                Console.Write($"{temp} <--");
                temp = parent[temp];
            }
        }

        public void SnakeLadder_ShortestPath(GraphUsingList graph)
        {
            var board = new int[50];
            board[2] = 13;
            board[5] = 2;
            board[9] = 18;
            board[18] = 11;
            board[17] = -13;
            board[20] = -14;
            board[24] = -8;
            board[25] = -10;
            board[32] = -2;
            board[34] = -22;

            //Insert edges
            for (int u = 0; u <= 36; u++)
            {
                //Throw a dice from 1 to 6
                for (int dice = 1; dice <= 6; dice++)
                {
                    int v = u + dice + board[u + dice];
                    if (v <= 36)
                        graph.AddEdge(u, v, false);
                }
            }

            //Shortest Path
            graph.Bfs_ShortestPath(0, 36);
        }
    }
}
