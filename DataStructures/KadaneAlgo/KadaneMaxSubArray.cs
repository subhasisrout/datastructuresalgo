using System;

// refer https://medium.com/@rsinghal757/kadanes-algorithm-dynamic-programming-how-and-why-does-it-work-3fd8849ed73d
// for intuitive understanding.

namespace DataStructures.KadaneAlgo
{
    public class KadaneMaxSubArray
    {
        public int GetMaxSubArrayValue(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                throw new ArgumentNullException();

            int globalMax = Int32.MinValue;
            int localMax = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                localMax = Math.Max(arr[i], localMax + arr[i]);
                globalMax = Math.Max(globalMax, localMax);
            }
            return globalMax;
        }
    }
}
