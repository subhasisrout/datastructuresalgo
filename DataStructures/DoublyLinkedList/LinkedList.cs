using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.DoublyLinkedList
{
    public class LinkedList
    {
        public Node Create()
        {
            Node head = null, secondNode = null, thirdNode = null;

            thirdNode = new Node();
            thirdNode.Data = 10;
            thirdNode.Next = null;
            thirdNode.Prev = secondNode;

            secondNode = new Node();
            secondNode.Data = 15;
            secondNode.Next = thirdNode;
            secondNode.Prev = head;

            head = new Node();
            head.Data = 2;
            head.Next = secondNode;
            head.Prev = null;

            return head;
            
        }

        public void Print(Node head)
        {
            Console.WriteLine("Printing doubly linked list");
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
            Console.WriteLine("Reversing doubly linked list");
            Node prev = null;
            Node current = head;
            Node next = null;
            while (current != null)
            {
                next = current.Next; 
                current.Next = prev; 
                current.Prev = next; //one line extra from singly linked list
                prev = current; 
                current = next; 
            }
            //out of the above 5 lines in the loop, line 2,3,4 does the work. While line 1,5 are just for iteration.
            head = prev;
            return head;
        }


       
    }

}
