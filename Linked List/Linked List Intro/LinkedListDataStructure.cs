using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List_Basics
{
    public class LinkedList
    { // user defined data type
        public Node head;
        public Node tail;

        public void addAtTail(int val)
        {
            // make a new node
            Node temp = new Node(val);

            if (tail == null)
            {
                head = tail = temp;
            }

            // add reference of the new node in the previous last node
            tail.next = temp;
            temp.next = null;

            // set tail to new last node;
            tail = temp;

        }

        public void addAtHead(int val)
        {
            // make a new node
            Node temp = new Node(val);
            if (head == null)
            {
                head = tail = temp;
            }

            // add referenc of head in the new node.next and put head on the new node  
            temp.next = head;
            head = temp;

        }

        public void display()
        {
            if (head == null) return;
            Node currentPonter = head;
            while (currentPonter != null)
            {
                Console.Write(currentPonter.val + " ");
                currentPonter = currentPonter.next;
            }
        }
    }
    internal class LinkedListDataStructure
    {
    }
}
