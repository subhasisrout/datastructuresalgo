using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graph
{
    public class GraphTraversalUtils
    {
        public void BFS(GraphBase g, int startNode = 0)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(startNode);
            int[] visited = new int[g.GetVerticesCount()];
            List<int> adjVertices;


            while (queue.Count() != 0)
            {
                var x = queue.Dequeue();
                if (visited[x] == 1)
                    continue;

                visited[x] = 1;
                Console.Write(x + "   ");


                adjVertices = g.GetAdjacentVertices(x);

                foreach (var item in adjVertices)
                {
                    if (visited[item] != 1)
                        queue.Enqueue(item);
                }
            }
        }

        public void DFS(GraphBase g, int startNode = 0)
        {
            int[] visited = new int[g.GetVerticesCount()];
            DFSHelper(g, visited, 0);
        }

        private void DFSHelper(GraphBase g, int[] visited, int node)
        {
            if (visited[node] == 1)
                return;

            Console.Write(node + "   ");
            visited[node] = 1;

            List<int> adjVertices = g.GetAdjacentVertices(node);
            foreach (var item in adjVertices)
            {
                DFSHelper(g, visited, item);
            }
        }

        public void TopologicalSort(GraphBase g)
        {
            Queue<int> queue = new Queue<int>();
            Dictionary<int, int> inDegreeMap = new Dictionary<int, int>();
            for (int i = 0; i < g.GetVerticesCount(); i++)
            {
                inDegreeMap.Add(i, g.GetInDegree(i));
                if (inDegreeMap[i] == 0)
                    queue.Enqueue(i);
            }

            List<int> topologicalSortedList = new List<int>();

            while (queue.Count() != 0)
            {
                int vertex = queue.Dequeue();
                topologicalSortedList.Add(vertex);

                List<int> adjVertices = g.GetAdjacentVertices(vertex);
                for (int i = 0; i < adjVertices.Count(); i++)
                {
                    inDegreeMap[adjVertices[i]] = inDegreeMap[adjVertices[i]] - 1;
                    if (inDegreeMap[adjVertices[i]] == 0)
                        queue.Enqueue(adjVertices[i]);
                }
            }

            if (topologicalSortedList.Count() != g.GetVerticesCount())
                throw new Exception("Graph has cycle(s)");

            topologicalSortedList.ForEach((x) => Console.WriteLine(x));
        }

        //returning the distance table. (3-column array)
        //first col - vertex
        //second col - distance from the source
        //third col - preceding node
        //second and third col are represented as a tuple in dictionary value. Dictionary key being the vertex itself.
        public Dictionary<int, Tuple<int, int>> BuildDistanceTable(GraphBase g, int source)
        {
            Dictionary<int, Tuple<int, int>> distanceTable = new Dictionary<int, Tuple<int, int>>();
            int numVertices = g.GetVerticesCount();
            for (int i = 0; i < numVertices; i++)            
                distanceTable[i] = new Tuple<int, int>(-1, -1); //initially distance from source and preceding are NULL (-1)

            distanceTable[source] = new Tuple<int, int>(0, source);

            var queue = new Queue<int>();
            queue.Enqueue(source);

            while (queue.Count() != 0)
            {
                int currentVertex = queue.Dequeue();
                int currentDistance = distanceTable[currentVertex].Item1;

                var adjacentVertices = g.GetAdjacentVertices(currentVertex);
                foreach (var neighbor in adjacentVertices)
                {
                    if (distanceTable[neighbor].Item1 != -1) //imp check here
                        distanceTable[neighbor] = new Tuple<int, int>(1 + currentDistance, currentVertex);

                    if (g.GetAdjacentVertices(neighbor).Count > 0)
                        queue.Enqueue(neighbor);
                }

            }

            return distanceTable;
        }
    }
}





