using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.LinkedList
{
    public class ReverseLinkedList
    {
        Node head;
        public class Node
        {
            public int data;
            public Node next;

            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        public void AddNode(Node node)
        {
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;

                while (temp.next != null)
                {
                    temp = temp.next;
                }

                temp.next = node;
            }
        }

        public void ReverseList()
        {
            Node prev = null, current = head, next = null;
            while(current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            head = prev;

        }

        public void PrintList()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data + " ");
                current = current.next;
            }
            Console.ReadKey();
        }
    }
}
