using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graph
{
    public abstract class GraphBase
    {
        protected int _numVertices;
        protected bool _directed;
        public GraphBase(int numVertices, bool directed=false)
        {
            _numVertices = numVertices;
            _directed = directed;
        }

        public abstract void AddEdge(int v1, int v2, int weight=1);

        public abstract List<int> GetAdjacentVertices(int v);

        public abstract int GetInDegree(int v);

        public abstract int GetEdgeWeight(int v1, int v2);

        public abstract void Display();

        public int GetVerticesCount()
        {
            return _numVertices;
        }



    }
}
