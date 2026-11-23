namespace Linked_List_Basics
{
    public class Node
    {
        public int val;
        public Node next;

        public Node (int val)
        {
            this.val = val;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // 10->20->30->40->50
            Node a = new Node(10); 
            Node b = new Node(20); 
            Node c = new Node(30);
            Node d = new Node(40); 
            Node e = new Node(50);
            // Connect 
            a.next = b;
            b.next = c;
            c.next = d;
            d.next = e;
            e.next = null;

            // 1) Displaying

            //DisplayLinkedList.display(a);            //DisplayLinkedList.displayRecursive(a);

            // 2) Getting
            //Console.Write(GetLinkedList.getNode(a, 3));

            // 3) Linked list as a data structure
            LinkedList l1 = new LinkedList();
            l1.addAtTail(10);
            l1.addAtTail(20);
            l1.addAtTail(30);
            l1.addAtTail(40);
            //l1.display();
            //l1.addAtHead(5);
            //Console.WriteLine(" ");
            l1.display();
            l1.insert(2, 15);
            Console.WriteLine(" ");
            l1.display();
        }
    }
}
