using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.SinglyLinkedList
{
    public class LinkedList
    {
        public Node Create()
        {

            Node fourthNode = new Node();
            fourthNode.Data = 1;
            fourthNode.Next = null;

            Node thirdNode = new Node();
            thirdNode.Data = 10;
            thirdNode.Next = fourthNode;

            Node secondNode = new Node();
            secondNode.Data = 15;
            secondNode.Next = thirdNode;

            Node head = new Node();
            head.Data = 2;
            head.Next = secondNode;

            return head;
            
        }

        public void Print(Node head)
        {
            Console.WriteLine("Printing singly linked list");
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.Data + "-->");
                temp = temp.Next;
            }
            Console.Write("null"+"\n");            
        }

        public Node Reverse(Node head)
        {
            Console.WriteLine("Reversing singly linked list");
            Node prev = null;
            Node current = head;
            Node next = null;
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            //out of the above 4 lines in the loop, line 2,3 does the work. While line 1,4 are just for iteration.
            head = prev;
            return head;
        }

        public Node DeleteMid(Node head)
        {
            if (head == null)
                return null;
            if (head.Next == null)
                return null;

            Node prev=head, slowPtr=head, fastPtr = head;

            while (fastPtr != null && fastPtr.Next != null) //fastPtr will move in twice the speed
                //as of slowPtr and hence reach NULL, when the slowPtr is in the middle.
            {
                fastPtr = fastPtr.Next.Next;
                prev = slowPtr;
                slowPtr = slowPtr.Next;
            }

            prev.Next = slowPtr.Next;

            return head;
        }


       
    }

}
