using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graph
{
    //Taken from Janani Ravi Pluralsight course
    public class AdjacencySetGraph : GraphBase
    {
        private List<Node> _vertices;
        public AdjacencySetGraph(int numVertices, bool directed = false) : base(numVertices, directed)
        {
            _vertices = new List<Node>();
            for (int i = 0; i < numVertices; i++)
            {
                _vertices.Add(new Node(i));
            }
        }

        public override void AddEdge(int v1, int v2, int weight = 1)
        {
            _vertices[v1].AddEdge(v2);
            if (!_directed)
                _vertices[v2].AddEdge(v1);
        }

        public override void Display()
        {
            for (int i = 0; i < _numVertices; i++)
            {
                foreach (var v in this.GetAdjacentVertices(i))
                {
                    Console.WriteLine($"{i} ---> {v}");
                }
            }
        }

        public override List<int> GetAdjacentVertices(int v)
        {
            return _vertices[v].GetAdjacentVertices().ToList<int>();
        }

        public override int GetEdgeWeight(int v1, int v2)
        {
            return 1;
        }

        public override int GetInDegree(int v)
        {
            int inDegree = 0;
            for (int i = 0; i < _numVertices; i++)
            {
                if (_vertices[i].GetAdjacentVertices().Contains(v))
                    inDegree += 1;
            }
            return inDegree;
        }
    }

    public class Node
    {
        private readonly int _vertex;
        private HashSet<int> _adjacencySet;

        public Node(int vertex)
        {
            _vertex = vertex;
            _adjacencySet = new HashSet<int>();
        }

        public void AddEdge(int v1)
        {
            if (_vertex == v1)
                throw new ArgumentException();

            this._adjacencySet.Add(v1);
        }

        public HashSet<int> GetAdjacentVertices()
        {
            return _adjacencySet;
        }
    }
}



