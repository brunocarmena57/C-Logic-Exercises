using System;

class Program
{
    static void Main(string[] args)
    {
        // create a sorted integer array to search
        int[] arr = { 1, 3, 5, 7, 9 };

        // perform binary search for target value 5
        int index = BinarySearch(arr, 5);

        // print out the index of the target value (-1 if not found)
        Console.WriteLine("Target value found at index: " + index);
    }

    static int BinarySearch(int[] arr, int target)
    {
        // define left and right pointers to define search range
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            // calculate midpoint between left and right pointers
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                // target value found at midpoint
                return mid;
            }
            else if (arr[mid] < target)
            {
                // target value is in right half of search range
                left = mid + 1;
            }
            else
            {
                // target value is in left half of search range
                right = mid - 1;
            }
        }

        // target value not found in array
        return -1;
    }
}
