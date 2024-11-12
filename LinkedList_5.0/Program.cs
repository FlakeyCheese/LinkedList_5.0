using System;

namespace linked_list
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList lnklist = new LinkedList();
            lnklist.PrintAllNodes();
            Console.WriteLine();

            lnklist.AddAtLast(12);
            lnklist.AddAtLast("John");
            lnklist.AddAtLast("Peter");
            lnklist.AddAtLast(34);
            lnklist.PrintAllNodes();
            Console.WriteLine();

            lnklist.AddAtStart(55);
            lnklist.PrintAllNodes();
            Console.WriteLine();

            lnklist.RemoveFromStart();
            lnklist.PrintAllNodes();

            Console.ReadKey();
        }
    }
    public class Node
    {
        public Node Next;
        public object Value;
    }

    public class LinkedList
    {
        private Node head;
        private Node current;//This will have latest node
        public int Count;

        public LinkedList()
        {
            head = new Node();
            current = head;
        }
        public void AddAtLast(object data)
        {
            Node newNode = new Node();
            newNode.Value = data;
            current.Next = newNode;
            current = newNode;
            Count++;
        }
        public void RemoveFromStart()
        {
            if (Count > 0)
            {
                head.Next = head.Next.Next;
                Count--;
            }
            else
            {
                Console.WriteLine("No element exist in this linked list.");
            }
        }
        public void AddAtStart(object data)
        {
            Node newNode = new Node() { Value = data };
            newNode.Next = head.Next;//new node will have reference of head's next reference
            head.Next = newNode;//and now head will refer to new node
            Count++;
        }

        public void PrintAllNodes()
        {
            //Traverse from head
            Console.Write("Head ->");
            Node curr = head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write(curr.Value);
                Console.Write("->");
            }
            Console.Write("NULL");
        }
    }
}
