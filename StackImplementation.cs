using System;

public class Stack<T>
{
    private T[] array;
    private int top;
    private const int DefaultCapacity = 10;

    public Stack()
    {
        array = new T[DefaultCapacity];
        top = -1;
    }

    public Stack(int capacity)
    {
        if (capacity <= 0)
            throw new ArgumentException("Capacity must be a positive integer.");

        array = new T[capacity];
        top = -1;
    }

    public int Count
    {
        get { return top + 1; }
    }

    public bool IsEmpty
    {
        get { return top == -1; }
    }

    public void Push(T item)
    {
        if (top == array.Length - 1)
            ResizeArray();

        top++;
        array[top] = item;
    }

    public T Pop()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Stack is empty.");

        T item = array[top];
        top--;
        return item;
    }

    public T Peek()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Stack is empty.");

        return array[top];
    }

    private void ResizeArray()
    {
        int newCapacity = array.Length * 2;
        Array.Resize(ref array, newCapacity);
    }
}

public class Program
{
    public static void Main()
    {
        Stack<int> stack = new Stack<int>();

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine($"Count: {stack.Count}");
        Console.WriteLine($"Peek: {stack.Peek()}");

        int poppedItem = stack.Pop();
        Console.WriteLine($"Popped: {poppedItem}");

        Console.WriteLine($"Count after pop: {stack.Count}");
    }
}
