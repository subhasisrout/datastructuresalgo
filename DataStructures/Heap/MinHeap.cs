﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Heap
{

    // Taken from HackerRank youtube video. Very neatly explained. And intuitive.
    // https://www.youtube.com/watch?v=t0Cq6tVNRBA
    public class MinHeap
    {
        private int[] arr;
        public int Size { get; private set; }
        private int capacity;

        public MinHeap(int capacity)
        {
            this.capacity = capacity;
            Size = 0;
            arr = new int[capacity];
        }

        private void Swap(int index1, int index2)
        {
            int tmp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = tmp;
        }

        private int GetLeftChildIndex(int parentIndex)
        {
            return 2 * parentIndex + 1;
        }
        private int GetRightChildIndex(int parentIndex)
        {
            return 2 * parentIndex + 2;
        }
        private int GetParentIndex(int childIndex)
        {
            return (childIndex - 1) / 2;
        }

        private bool HasLeftChild(int parentIndex)
        {
            return GetLeftChildIndex(parentIndex) < Size;
        }
        private bool HasRightChild(int parentIndex)
        {
            return GetRightChildIndex(parentIndex) < Size;
        }

        private bool HasParent(int childIndex)
        {
            return GetParentIndex(childIndex) >= 0;
        }

        private int GetLeftChild(int parentIndex)
        {
            return arr[GetLeftChildIndex(parentIndex)];
        }
        private int GetRightChild(int parentIndex)
        {
            return arr[GetRightChildIndex(parentIndex)];
        }
        private int GetParent(int parentIndex)
        {
            return arr[parentIndex];
        }



        private void EnsureCapacity()
        {
            if (Size == capacity)
            {
                int[] newArray = new int[capacity * 2];
                for (int i = 0; i < arr.Length; i++)
                {
                    newArray[i] = arr[i];
                }
                arr = newArray;
            }
        }

        public void Insert(int item)
        {
            EnsureCapacity();
            arr[Size] = item;
            Size++;
            HeapifyUp();
        }

        public int Remove()
        {
            if (Size == 0)
                throw new InvalidOperationException();
            int retVal = arr[0];
            Swap(0, Size - 1);
            Size--;
            HeapifyDown();
            return retVal;
        }

        private void HeapifyUp() //In both Heapifyup and HeapifyDown, the first line sets the current index
        {
            int currIndex = Size - 1;
            while (HasParent(currIndex) && GetParent(GetParentIndex(currIndex)) > arr[currIndex])
            {
                Swap(GetParentIndex(currIndex), currIndex);
                currIndex = GetParentIndex(currIndex); // move up. thats why it is heapify up.
            }
        }

        private void HeapifyDown() //In both Heapifyup and HeapifyDown, the first line sets the current index
        {
            int currIndex = 0;
            while (HasLeftChild(currIndex))
            {
                //next 3 lines finds the smaller child - left or right
                int smallerChildIndex = GetLeftChildIndex(currIndex);
                if (HasRightChild(currIndex) && GetRightChild(currIndex) < GetLeftChild(currIndex))
                    smallerChildIndex = GetRightChildIndex(currIndex);

                if (arr[currIndex] < arr[smallerChildIndex])
                    break;
                else
                    Swap(currIndex, smallerChildIndex);

                currIndex = smallerChildIndex; // move down. thats why it is heapify down
            }
        }
        
    }
}
