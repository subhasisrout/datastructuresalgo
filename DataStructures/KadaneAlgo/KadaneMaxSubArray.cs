using System;

// refer https://medium.com/@rsinghal757/kadanes-algorithm-dynamic-programming-how-and-why-does-it-work-3fd8849ed73d
// for intuitive understanding.

namespace DataStructures.KadaneAlgo
{
    public class KadaneMaxSubArray
    {
        public int GetMaxSubArrayValue(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                throw new ArgumentNullException();

            int globalMax = Int32.MinValue;
            int localMax = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                localMax = Math.Max(nums[i], localMax + nums[i]);
                globalMax = Math.Max(globalMax, localMax);
            }
            return globalMax;
        }
    }
}
