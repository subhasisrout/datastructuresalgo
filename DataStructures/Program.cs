using DataStructures.Graph;
using DataStructures.StringAlgos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //FindAndReplace findReplace = new FindAndReplace();
            //Console.WriteLine(findReplace.ReplacePattern(new StringBuilder("geeksforgeeks"), "eks"));

            //BinarySearch.BinarySearchUtils binarySearchUtils = new BinarySearch.BinarySearchUtils();
            //int[] sortedNumbers = { 1, 4, 6, 10, 20, 22, 23, 50, 70, 75, 100 };
            //Console.WriteLine(binarySearchUtils.IsFound(sortedNumbers, 75));

            //LongestCommonSubsequence.LCSMemoize lcsDpMemoize = new LongestCommonSubsequence.LCSMemoize();
            //Console.WriteLine(lcsDpMemoize.LCS("adjkflsjhfgjjdsjfsalkjhkfjhslkhg", "dzfasfjjdjlhsh"));            

            //KnapsackProblem.KnapsackBottomUp ks = new KnapsackProblem.KnapsackBottomUp();
            //Console.WriteLine(ks.KnapsackMaxValue(9, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 4, 4, 5, 7 }));

            //KnapsackProblem.KnapsackMemoize ks2 = new KnapsackProblem.KnapsackMemoize(new int[] { 0, 1, 2, 3, 4, 5 }, new int[] { 0, 1, 4, 4, 5, 7 }, 9);
            //Console.WriteLine(ks2.KnapsackMaxValue());


            //SinglyLinkedList.LinkedList linkedList = new SinglyLinkedList.LinkedList();
            //DataStructures.SinglyLinkedList.Node head = linkedList.Create();
            //linkedList.Print(head);
            //linkedList.Print(linkedList.DeleteMid(head));
            //linkedList.Print(linkedList.Reverse(head));


            //DoublyLinkedList.LinkedList linkedList = new DoublyLinkedList.LinkedList();
            //var head  = linkedList.Create();
            //linkedList.Print(head);
            //linkedList.Print(linkedList.Reverse(head));

            //BinarySearchTree.BinaryTree tree = new BinarySearchTree.BinaryTree();
            //BinarySearchTree.Node root = tree.Create();
            //Console.WriteLine($"Height of the BST is {tree.MaxDepth(root)}");
            //Console.WriteLine("Doing in order traversal");
            //tree.InOrderTraversal(root);
            //Console.WriteLine("Doing pre order traversal");
            //tree.PreOrderTraversal(root);
            //Console.WriteLine("Doing post order traversal");
            //tree.PostOrderTraversal(root);
            //Console.WriteLine("Doing level order traversal (breadth first search)");
            //tree.LevelOrderTraversal(root);
            //Console.WriteLine(tree.IsTreeValidBinarySearchTree(root,int.MinValue,int.MaxValue));
            //Console.WriteLine(tree.IsTreeValidBinarySearchTree(tree.CreateInvalid(), int.MinValue, int.MaxValue));
            //Console.WriteLine($"Min value of the tree is {tree.MinValue(root)}");
            //BinarySearchTree.Node deletedNode = tree.DeleteRec(root, 30);
            //Console.WriteLine("After Delete - Doing in order traversal");
            //tree.InOrderTraversal(root);


            //      0--------1
            //       \
            //         \
            //           \
            //             2------3

            ////Taken from Janani Ravi Pluralsight course
            ////GraphBase g1 = new AdjacencyMatrixGraph(4);
            //GraphBase g1 = new AdjacencySetGraph(9,true);//from 7
            //g1.AddEdge(0, 1);
            //g1.AddEdge(1, 2);
            //g1.AddEdge(2, 0); //edge added to create cycle.
            //g1.AddEdge(2, 7);
            //g1.AddEdge(2, 4);
            //g1.AddEdge(2, 3);
            //g1.AddEdge(1, 5);
            //g1.AddEdge(5, 6);
            //g1.AddEdge(3, 6);
            //g1.AddEdge(3, 4);
            //g1.AddEdge(6, 8);


            //for (int v = 0; v < 9; v++)
            //{
            //    Console.Write($"Adjacent to {v} - ");
            //    g1.GetAdjacentVertices(v).ForEach(x => Console.Write(x + " "));
            //    Console.Write(Environment.NewLine);
            //}

            //Console.WriteLine("--------------------------------------------");

            //for (int v = 0; v < 9; v++)
            //{
            //    Console.WriteLine($"Indegree of {v} - {g1.GetInDegree(v)}");
            //}

            //for (int i = 0; i < 4; i++)
            //{
            //    List<int> adjV = g1.GetAdjacentVertices(i);
            //    foreach (var item in adjV)
            //    {
            //        Console.WriteLine($"Edge weight: {i} {item} Weight: {g1.GetEdgeWeight(i, item)}");
            //    }
            //}
            //Console.WriteLine("--------------------------------------------------------------------");
            //g1.Display();

            //Console.WriteLine("-----------Doing breadth-first traversal----------");
            //GraphTraversalUtils utils = new GraphTraversalUtils();
            //utils.DFS(g1,0);

            //utils.TopologicalSort(g1);


            //Client program for heaps
            //int[] A = new int[] { 9, 2, 5, 1, 19, 40, 30, 11, 71, 21 };
            //A = new int[] { 1, 3 };
            //Heap.HeapHelpers heapHelpers = new Heap.HeapHelpers();
            //heapHelpers.BuildMaxHeap(A);

            //Console.WriteLine(heapHelpers.ExtractMax(ref A));
            //Console.WriteLine(heapHelpers.ExtractMax(ref A));
            //heapHelpers.AddToMaxHeap(ref A, 2);
            //Console.WriteLine(heapHelpers.ExtractMax(ref A));

        }
    }
}
