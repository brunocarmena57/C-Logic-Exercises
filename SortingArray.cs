using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };
        Console.WriteLine("Original array:");
        PrintArray(arr);

        SortArray(arr);
        Console.WriteLine("\nSorted array:");
        PrintArray(arr);
    }

    static void SortArray(int[] arr)
    {
        Array.Sort(arr);
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
