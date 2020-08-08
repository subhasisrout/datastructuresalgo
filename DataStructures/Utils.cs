using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Utils
    {
        public static bool IsArraySorted(int[] arr, int n)
        {

            // Array has one or no element
            if (n == 0 || n == 1)
                return true;

            for (int i = 1; i < n; i++)

                // Unsorted pair found
                if (arr[i - 1] > arr[i])
                    return false;

            // No unsorted pair found
            return true;
        }
    }
}
