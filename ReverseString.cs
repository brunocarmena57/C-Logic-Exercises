using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "Hello, world, this is Bruno Carmena!";
        string reversed = ReverseString(input);
        Console.WriteLine(reversed);
    }

    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}