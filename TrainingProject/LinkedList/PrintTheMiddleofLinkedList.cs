using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.LinkedList
{
    public class PrintTheMiddleofLinkedList
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

        public void printMiddle()
        {
            Node slow_ptr = head;
            Node fast_ptr = head;

            if (head != null)
            {
                while (fast_ptr != null && fast_ptr.next != null)
                {
                    fast_ptr = fast_ptr.next.next;
                    slow_ptr = slow_ptr.next;
                }

                Console.WriteLine("The middle element is [" + slow_ptr.data + "] \n");
            }
        }
         
        public void push(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = head;
            head = new_node;
        }

        public void printList()
        {
            Node node = head;
            while (node != null)
            {
                Console.WriteLine(node.data + "->");
                node = node.next;
            }            
        }
    }
}
