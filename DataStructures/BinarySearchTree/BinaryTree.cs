using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearchTree
{
    public class BinaryTree
    {
        public Node Create()
        {
            Node root = null;

            //                  20
            //          10               30
            //      1       12       21      50
            //                           45      55


            root = new Node();
            root.Data = 20;
            root.LeftChild = new Node();
            root.RightChild = new Node();

            root.LeftChild.Data = 10;
            root.LeftChild.LeftChild = new Node();
            root.LeftChild.RightChild = new Node();

            root.RightChild.Data = 30;
            root.RightChild.LeftChild = new Node();
            root.RightChild.RightChild = new Node();

            root.LeftChild.LeftChild.Data = 1;
            root.LeftChild.LeftChild.LeftChild = null;
            root.LeftChild.LeftChild.RightChild = null;

            root.LeftChild.RightChild.Data = 12;
            root.LeftChild.RightChild.LeftChild = null;
            root.LeftChild.RightChild.RightChild = null;

            root.RightChild.LeftChild.Data = 21;
            root.RightChild.LeftChild.LeftChild = null;
            root.RightChild.LeftChild.RightChild = null;

            root.RightChild.RightChild.Data = 50;
            root.RightChild.RightChild.LeftChild = new Node();
            root.RightChild.RightChild.RightChild = new Node();

            root.RightChild.RightChild.LeftChild.Data = 45;
            root.RightChild.RightChild.LeftChild.LeftChild = null;
            root.RightChild.RightChild.LeftChild.RightChild = null;

            root.RightChild.RightChild.RightChild.Data = 55;
            root.RightChild.RightChild.RightChild.LeftChild = null;
            root.RightChild.RightChild.RightChild.RightChild = null;

            return root;
        }

        public Node CreateInvalid()
        {
            Node root = null;

            //                  20
            //          10              30
            //      1       12       21      50


            root = new Node();
            root.Data = 20;
            root.LeftChild = new Node();
            root.RightChild = new Node();

            root.LeftChild.Data = 10;
            root.LeftChild.LeftChild = new Node();
            root.LeftChild.RightChild = new Node();

            root.RightChild.Data = 30;
            root.RightChild.LeftChild = new Node();
            root.RightChild.RightChild = new Node();

            root.LeftChild.LeftChild.Data = 1;
            root.LeftChild.LeftChild.LeftChild = null;
            root.LeftChild.LeftChild.RightChild = null;

            root.LeftChild.RightChild.Data = 22; //Incorrect value in a BST
            root.LeftChild.RightChild.LeftChild = null;
            root.LeftChild.RightChild.RightChild = null;

            root.RightChild.LeftChild.Data = 21;
            root.RightChild.LeftChild.LeftChild = null;
            root.RightChild.LeftChild.RightChild = null;

            root.RightChild.RightChild.Data = 50;
            root.RightChild.RightChild.LeftChild = null;
            root.RightChild.RightChild.RightChild = null;


            return root;
        }

        public bool IsTreeValidBinarySearchTree(Node root)
        {
            //Easiest way is - a) do inorder walk b) check that the output is sorted ascending or not (can be optimized by not using auxilary array and keeping a track of prev value)

            List<int> listInt = new List<int>();
            InOrderTraversal2(root, listInt);
            return Utils.IsArraySorted(listInt.ToArray(), listInt.Count());

            //https://www.geeksforgeeks.org/a-program-to-check-if-a-binary-tree-is-bst-or-not/



        }

        public bool IsTreeValidBinarySearchTree(Node root,int min, int max)
        {
            if (root == null)
                return true;

            if (root.Data < min || root.Data > max)
                return false;

            return IsTreeValidBinarySearchTree(root.LeftChild, min, root.Data - 1) &&
                IsTreeValidBinarySearchTree(root.RightChild, root.Data + 1, max);
        }

        public int MaxDepth(Node root)
        {
            if (root == null)
                return 0;
            else
            {
                int ldepth = MaxDepth(root.LeftChild);
                int rdepth = MaxDepth(root.RightChild);

                if (ldepth > rdepth)
                    return ldepth + 1;
                else
                    return rdepth + 1;
            }
        }

        //public bool InOrderTraversal3(Node root)
        //{
        //    //https://www.geeksforgeeks.org/a-program-to-check-if-a-binary-tree-is-bst-or-not/
        //}
        public void InOrderTraversal(Node root)
        {
            if (root == null)
                return;
            InOrderTraversal(root.LeftChild);
            Console.WriteLine(root.Data);
            InOrderTraversal(root.RightChild);
        }

        public void InOrderTraversal2(Node root, List<int> list)
        {
            if (root == null)
                return;
            InOrderTraversal2(root.LeftChild, list);
            list.Add(root.Data);
            InOrderTraversal2(root.RightChild, list);
        }

        public void PreOrderTraversal(Node root)
        {
            if (root == null)
                return;
            Console.WriteLine(root.Data);        //Only this sequence changes in in,pre,post order traversal. All three are depth-first traversal
            PreOrderTraversal(root.LeftChild);
            PreOrderTraversal(root.RightChild);

        }

        public void PostOrderTraversal(Node root)
        {
            if (root == null)
                return;
            PostOrderTraversal(root.LeftChild);
            PostOrderTraversal(root.RightChild);
            Console.WriteLine(root.Data);        //Only this sequence changes in in,pre,post order traversal. All three are depth-first traversal
        }

        //https://www.geeksforgeeks.org/level-order-tree-traversal/
        public void LevelOrderTraversal(Node root) //this is the breadth first traversal
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                Node tmp = queue.Dequeue();
                Console.WriteLine(tmp.Data);

                if (tmp.LeftChild != null)
                    queue.Enqueue(tmp.LeftChild);

                if (tmp.RightChild != null)
                    queue.Enqueue(tmp.RightChild);
            }

        }

        public int MinValue(Node root) // assumption root is never be null;
        {
            int minV = root.Data;
            while (root.LeftChild != null)
            {
                minV = root.LeftChild.Data;
                root = root.LeftChild;                
            }

            return minV;
        }

        

        public Node DeleteRec(Node root, int data)
        {
            //base case
            if (root == null)
                return root;

            //recur down the tree
            if (root.Data < data)
                root.RightChild = DeleteRec(root.RightChild, data);
            else if(root.Data > data)
                root.LeftChild = DeleteRec(root.LeftChild, data);

            //if data is same as root.data, this is the node to be deleted
            else
            {
                //case for one child or no child
                if (root.LeftChild == null)
                    return root.RightChild;
                if (root.RightChild == null)
                    return root.LeftChild;


                //case node with 2 children. Get the inorder successor (min value in right subtree)
                root.Data = MinValue(root.RightChild);

                root.RightChild = DeleteRec(root.RightChild, root.Data);
            }

            return root;
        }
    }
}
