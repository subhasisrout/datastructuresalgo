using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearch
{
    public class BinarySearchUtils
    {
        public int IsFound(int[] arrNumbers, int numberToFind)
        {
            if (arrNumbers.Length == 0)
                return Int32.MinValue;
            int len = arrNumbers.Length;
            int left = 0;
            int right = len - 1;
            int mid = (left + right) / 2;
            bool isFound = false;

            do
            {
                if (numberToFind > arrNumbers[mid])
                {
                    left = mid + 1;
                }
                else if (numberToFind < arrNumbers[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    isFound = true;
                    left = mid;
                    right = mid;
                }
                mid = (left + right) / 2;
            }
            while (left < right);

            if (isFound)
                return mid;
            else
                return Int32.MinValue;
            
        }
    }
}
