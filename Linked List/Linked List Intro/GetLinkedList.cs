using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List_Basics
{
    internal class GetLinkedList
    {
        public static int getNode(Node head, int target)
        {
            Node currentPointer = head;
            for (int i=0; i<target; i++)
            {
                currentPointer = currentPointer.next;
            }
            return currentPointer.val;
        }
        public void connectLists()
        {
            // 10->20->30->40->50
            Node a = new Node(10);
            Node b = new Node(20);
            Node c = new Node(30);
            Node d = new Node(40);
            Node e = new Node(50);
            Node f = new Node(5);
            // Connect 
            a.next = b;
            b.next = c;
            c.next = d;
            d.next = e;
            e.next = f;
            f.next = null;
        }
    }
}
