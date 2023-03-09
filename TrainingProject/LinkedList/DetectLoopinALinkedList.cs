using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.LinkedList
{
    public class DetectLoopinALinkedList
    {
        public Node head;
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

        public void push(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = head;
            head = new_node;
        }

        public bool detectLoop(Node h)
        {
            HashSet<Node> hNode = new HashSet<Node>();
            while(h != null)
            {
                if(hNode.Contains(h))
                {
                    return true;
                }

                hNode.Add(h);

                h = h.next;
            }
            return false;
        }
    }
}
