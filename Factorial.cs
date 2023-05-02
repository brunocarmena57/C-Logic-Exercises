using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 5; // number to calculate the factorial of
        int result = Factorial(n);
        Console.WriteLine("Factorial of " + n + " is " + result);
    }

    // Recursive function to calculate the factorial of n
    static int Factorial(int n)
    {
        // Base case: if n is 0, return 1
        if (n == 0)
        {
            return 1;
        }
        // Recursive case: calculate factorial of (n-1) and multiply by n
        else
        {
            int subproblem = Factorial(n - 1);
            int result = n * subproblem;
            return result;
        }
    }
}
