using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List_Basics
{
    public class LinkedList
    { // user defined data type
        public Node head;
        public Node tail;

        int size;

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
            size++;

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
            size++;

        }

        public void deleteAtHead()
        {
            if (head == null) return;
            head = head.next;
            if (head == null) tail = null;
            size--;
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

        public bool search(int val)
        {
            Node currentPointer = head;
            while(currentPointer != null)
            {
                if (head == null) return false; 
                if (currentPointer.val == val)
                {
                    return true;
                }
            }
            return false;
        }

        public void insert(int idx, int val)
        {

            if (idx < 0 || idx >= size)
            {
                Console.WriteLine("Invalid index");
                return;
            }

            // Case1: Insert at head;
            if (idx == 0)
            {
                addAtHead(val);
                return;
            }

            // Case2: Add at tail
            if (idx == size)
            {
                addAtTail(val);
                return;
            }

            // Case3: Add in middle
            Node temp = new Node(val);
            Node currentPointer = head;

            for (int i=1; i<=idx-1; i++)
            {
                currentPointer = currentPointer.next;
            }

            temp.next = currentPointer.next;
            currentPointer.next = temp;
            size++;
        }

        public void deleteAtIdx(int idx)
        {
            if (idx < 0 || idx >= size)
            {
                Console.WriteLine("Invalid index");
                return;
            }

            // Case 1: Delete at head
            if (idx == 0)
            {
                deleteAtHead();
                return;
            }

            // Case2: Delete at tail
            if (idx == size-1)
            {
                Node currentPointer2 = head;
                for (int i = 1; i <= idx - 1; i++)
                {
                    currentPointer2 = currentPointer2.next;
                }
                currentPointer2.next = null;
                tail = currentPointer2;
                size--;
                return;
            }

            // Case3: Delete in middle

            Node currentPointer = head;
            for(int i=1; i<=idx-1; i++)
            {
                currentPointer = currentPointer.next;
            }

            Node nodeTodelete = currentPointer.next;
            currentPointer.next = nodeTodelete.next;
            size--;

        }
    }
    internal class LinkedListDataStructure
    {
    }
}
 