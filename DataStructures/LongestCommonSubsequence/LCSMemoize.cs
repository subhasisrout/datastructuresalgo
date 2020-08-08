using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LongestCommonSubsequence
{
    //Taken from https://www.youtube.com/watch?v=Qf5R-uYQRPk
    //Adding 3 extra lines converts recursion to MEMOIZED DP Solution
    public class LCSMemoize
    {
        int[,] arrMemo;
        int result = -1;
        public int LCS(string p, string q)
        {            
            arrMemo = new int[p.Length, q.Length];  //MEMOIZE Line 1 - instantiate a n*m matrix with all values -1
            for (int i = 0; i < p.Length; i++)
            {
                for (int j = 0; j < q.Length; j++)
                {
                    arrMemo[i, j] = -1;
                }
            }
            return LCSHelper(p, q, p.Length, q.Length);
        }
        public int LCSHelper(string p, string q, int lengthP, int lengthQ)
        {
            if (lengthP >= 1 && lengthQ >= 1 && arrMemo[lengthP - 1, lengthQ - 1] != -1) return arrMemo[lengthP - 1, lengthQ - 1]; //MEMOIZE Line 2
            if (lengthP == 0 || lengthQ == 0)
                result = 0;
            else if (p[lengthP - 1] == q[lengthQ - 1]) //if the last char in both string is same
                result = 1 + LCSHelper(p, q, lengthP - 1, lengthQ - 1);
            else if (p[lengthP - 1] != q[lengthQ - 1]) //if the last char in both string is NOT same
            {
                int tmp1 = LCSHelper(p, q, lengthP, lengthQ - 1);
                int tmp2 = LCSHelper(p, q, lengthP - 1, lengthQ);
                result = Math.Max(tmp1, tmp2);
            }
            if (lengthP >= 1 && lengthQ >= 1) arrMemo[lengthP - 1, lengthQ - 1] = result; //MEMOIZE Line 3.
            return result;
        }
    }
}
