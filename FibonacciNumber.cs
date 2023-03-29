using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 10; // the number of Fibonacci numbers to generate
        Console.WriteLine("Fibonacci sequence up to " + n + " numbers:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }
    static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
