using System;
namespace Homework_4.LinkedList
{
    public class DoublyLinkedList
    {
        public Node First { get; set; }
        public Node Last { get; set; }

        public void InsertFirst(int data)
        {
            // Create the node
            Node newNode = new Node();
            // Put data in the node
            newNode.Data = data;
            // Put the old node into Next
            newNode.Next = First;
            if (First != null) First.Previous = newNode;
            // Make the first the new node
            First = newNode;

            if (First.Next == null) Last = newNode;
        }

        public Node DeleteFirst()
        {
            // Assign the temporary variable
            Node temp = First;
            // Assign the new head
            First = First.Next;
            if (First != null) First.Previous = null;
            if (First == null) Last = null;
            return temp;
        }

        public void DisplayList()
        {
            Console.WriteLine("Iterating through list...");
            Node current = First;
            while (current != null)
            {
                current.DisplayNode();
                current = current.Next;
            }
        }

        public void InsertLast(int data)
        {
            Node currentLastNode = Last;
            Node newNode = new Node();
            newNode.Data = data;
            currentLastNode.Next = newNode;
            newNode.Previous = currentLastNode;
            Last = newNode;
        }
    }
}

