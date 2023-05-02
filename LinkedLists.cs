using System;

// Define a generic LinkedListNode class representing a node in a linked list.
public class LinkedListNode<T>
{
    // Define the Value property representing the value stored in the node.
    public T Value { get; private set; }

    // Define the Next property representing the next node in the list.
    public LinkedListNode<T> Next { get; internal set; }

    // Define the constructor for creating a new node with a given value and next node.
    public LinkedListNode(T value, LinkedListNode<T> next = null)
    {
        Value = value;
        Next = next;
    }
}

// Define a generic LinkedList class representing a linked list.
public class LinkedList<T>
{
    // Define the Head property representing the first node in the list.
    public LinkedListNode<T> Head { get; private set; }

    // Define the constructor for creating an empty list with no nodes.
    public LinkedList()
    {
        Head = null;
    }

    // Define a method for adding a new node to the end of the list with a given value.
    public void AddLast(T value)
    {
        // If the list is empty, set the new node as the head.
        if (Head == null)
        {
            Head = new LinkedListNode<T>(value);
        }
        else
        {
            // Otherwise, find the last node in the list and set its Next property to the new node.
            LinkedListNode<T> current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new LinkedListNode<T>(value);
        }
    }

    // Define a method for checking if a given value is in the list.
    public bool Contains(T value)
    {
        // Traverse the list, checking each node's value until the end of the list is reached or the value is found.
        LinkedListNode<T> current = Head;
        while (current != null)
        {
            if (current.Value.Equals(value))
            {
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    // Define a method for removing the first node with a given value from the list.
    public void Remove(T value)
    {
        // If the list is empty, do nothing.
        if (Head == null)
        {
            return;
        }

        // If the head node contains the value, set the head to its next node (which may be null).
        if (Head.Value.Equals(value))
        {
            Head = Head.Next;
            return;
        }

        // Traverse the list, looking for a node with the given value.
        LinkedListNode<T> previous = Head;
        LinkedListNode<T> current = Head.Next;
        while (current != null)
        {
            if (current.Value.Equals(value))
            {
                // If the value is found, set the previous node's Next property to the current node's Next property.
                previous.Next = current.Next;
                return;
            }
            previous = current;
            current = current.Next;
        }
    }
}