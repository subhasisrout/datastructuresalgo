using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.KnapsackProblem
{
    //Taken from https://www.youtube.com/watch?v=xOlhR_2QCXY
    //Adding 3 extra lines converts recursion to MEMOIZED DP Solution
    public class KnapsackMemoize
    {
        int result = -1;
        int[] W;
        int[] V;
        int capacity;

        public KnapsackMemoize(int[] W, int[] V, int capacity)
        {            
            this.V = V;
            this.W = W;
            this.capacity = capacity;
        }
        public int KnapsackMaxValue()
        {
            int n = W.Length - 1;
            return KS(n, capacity); //KS value till nth element with remaining capacity C
        }

        public int KS(int n, int C) //KS value till nth element with remaining capacity C
        {
            if (n == 0 || C == 0)
                result = 0;
            else if (W[n] > C)
                result = KS(n - 1, C);
            else
            {
                int tmp1 = KS(n - 1, C);
                int tmp2 = V[n] + KS(n - 1, C - W[n]);
                result = Math.Max(tmp1, tmp2);
            }
            return result;
        }
    }
}
