using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingQ
{
    public class GraphAjdacencyMatrix
    {
        int vertex;
        int[,] adjMatrix;

        public GraphAjdacencyMatrix(int vertex)
        {
            this.vertex = vertex;
            adjMatrix = new int[vertex, vertex];
        }

        public void AddEdge(int source, int destination, bool biDir = true)
        {
            //add edge
            adjMatrix[source, destination] = 1;
            if (biDir)
            {
                //add back edge for undirected graph
                //adjMatrix[destination, source] = 1;
            }
        }

        public void PrintGraph()
        {
            Console.WriteLine("Graph: (Adjacency Matrix)");
            for (int i = 0; i < vertex; i++)
            {
                for (int j = 0; j < vertex; j++)
                {
                    Console.Write(adjMatrix[i,j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("========================================================");
            for (int i = 0; i < vertex; i++)
            {
                Console.WriteLine("Vertex " + i + " is connected to:");
                for (int j = 0; j < vertex; j++)
                {
                    if (adjMatrix[i,j] == 1)
                    {
                        Console.Write(j + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
