using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graph
{
    public class AdjacencyMatrixGraph : GraphBase
    {
        private int[,] _matrix;
        private List<int> _adjacentVertices = null;

        public AdjacencyMatrixGraph(int numVertices, bool directed = false) : base(numVertices, directed)
        {
            _matrix = new int[numVertices, numVertices];   //matrix will be initialized to all zeros.
            //matrix row used for "FROM vertex" and column used for "TO vertex".
        }

        public override void AddEdge(int v1, int v2, int weight=1)
        {
            if (v1 >= _numVertices || v2 >= _numVertices || v1 < 0 || v2 < 0)
                throw new ArgumentOutOfRangeException($"Vertices v1 and v2 should be between 0 and ({_numVertices}-1)");

            if(weight < 1)
                throw new ArgumentOutOfRangeException($"An edge cannot have weight less than 1");

            _matrix[v1, v2] = weight;

            if (!_directed)
                _matrix[v2, v1] = weight;
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
            if (v < 0 || v >= _numVertices)
                throw new ArgumentOutOfRangeException();

            _adjacentVertices = new List<int>();
            for (int i = 0; i < _numVertices; i++)
            {
                if (_matrix[v,i] > 0)
                    _adjacentVertices.Add(i);
            }
            return _adjacentVertices;
        }

        public override int GetEdgeWeight(int v1, int v2)
        {
            return _matrix[v1, v2];
        }

        public override int GetInDegree(int v)
        {
            if (v < 0 || v >= _numVertices)
                throw new ArgumentOutOfRangeException();

            int inDegree = 0;
            for (int i = 0; i < _numVertices; i++)
            {
                if (_matrix[i, v] > 0)           //not i,v not v,i  as inDegree is the number to entries TO node.
                    inDegree+=1;

            }
            return inDegree;
        }


    }
}
