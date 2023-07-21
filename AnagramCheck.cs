using System;
public class AnagramChecker
{
    public static bool AreAnagrams(string str1, string str2)
    {
        // Remove whitespaces and convert both strings to lowercase
        str1 = str1.Replace(" ", "").ToLower();
        str2 = str2.Replace(" ", "").ToLower();

        // Check if the lengths of the strings are different
        if (str1.Length != str2.Length)
            return false;

        // Create character frequency arrays to count the occurrences of each character
        int[] charFrequency1 = new int[26]; // Assuming we are dealing with lowercase English alphabet characters
        int[] charFrequency2 = new int[26];

        // Count the occurrences of characters in str1
        foreach (char c in str1)
        {
            int index = c - 'a';
            charFrequency1[index]++;
        }

        // Count the occurrences of characters in str2
        foreach (char c in str2)
        {
            int index = c - 'a';
            charFrequency2[index]++;
        }

        // Compare the character frequencies
        for (int i = 0; i < 26; i++)
        {
            if (charFrequency1[i] != charFrequency2[i])
                return false;
        }

        return true;
    }
}

public class Program
{
    public static void Main()
    {
        string str1 = "listen";
        string str2 = "silent";

        if (AnagramChecker.AreAnagrams(str1, str2))
        {
            Console.WriteLine($"{str1} and {str2} are anagrams.");
        }
        else
        {
            Console.WriteLine($"{str1} and {str2} are not anagrams.");
        }
    }
}
