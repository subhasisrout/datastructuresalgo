using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Heap
{
    public class HeapHelpers
    {
        public void MaxHeapify(int[] A, int i) //Assuming array A is 0 based (not 1 based)
        {
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;
            if (l < A.Length && A[l] > A[largest])
                largest = l;
            if (r < A.Length && A[r] > A[largest])
                largest = r;
            if (largest != i)
            {
                int temp = A[i];
                A[i] = A[largest];
                A[largest] = temp;
                MaxHeapify(A, largest);
            }
        }

        public void BuildMaxHeap(int[] A)
        {
            for (int i = A.Length/2; i >= 0; i--)
            {
                MaxHeapify(A, i);
            }
        }

        public void AddToMaxHeap(ref int[] A, int num)
        {
            Array.Resize(ref A, A.Length + 1);
            A[A.Length - 1] = num;
            BuildMaxHeap(A);
        }

        public int ExtractMax(ref int[] A)
        {
            if (A.Length == 1)
            {
                int retVal = A[0];
                A = new int[0];
                return retVal;
            }

            int root = A[0];
            A[0] = A[A.Length - 1];
            A = A.Take(A.Length - 1).ToArray();
            MaxHeapify(A, 0);
            return root;

        }
    }
}
