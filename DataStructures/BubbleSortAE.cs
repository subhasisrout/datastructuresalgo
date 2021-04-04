// #AE Check AE video for refresher

namespace DataStructures
{
    public class BubbleSortAE
    {
        public static int[] BubbleSort(int[] array)
        {
            bool isSwapped = true;
            int lastIndex = array.Length - 1;
            while (isSwapped == true)
            {
                isSwapped = false;
                for (int i = 0; i < lastIndex; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        isSwapped = true;
                        Swap(array, i, i + 1);
                    }
                }
                lastIndex--; //This line is not needed, but present there as a SMALL OPTIMIZATION.

                // Once the loop finishes for the first time, the largest element is bubbled up to the last position (i.e in its correct position)
                // When the loop finishes for the second time, the largest and second largest element are bubbled up to the last and second last position (i.e in its correct position)
                // Thats why we reduce lastIndex.
            }
            return array;
        }
        private static void Swap(int[] arr, int index1, int index2)
        {
            int tmp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = tmp;
        }
    }
}
