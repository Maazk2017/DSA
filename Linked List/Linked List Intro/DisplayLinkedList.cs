using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List_Basics
{
    internal class DisplayLinkedList
    {
        public static void display(Node head)
        {
            Node currentPonter = head;
            while(currentPonter != null)
            {
                Console.Write(currentPonter.val); 
                currentPonter = currentPonter.next;
            }
        }

        public static void displayFor(Node head)
        {
            for (Node currentPointer = head; currentPointer != null;  currentPointer = currentPointer.next)
            {
                Console.Write(currentPointer.val);
            }
        }

        public static void displayRecursive(Node head)
        {
            if (head == null) return;
            Console.Write(head.val + " ");
            displayRecursive(head.next);
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
