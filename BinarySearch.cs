using System;

class BinarySearching
{
    static void Main()
    {
        int[] array = { 1, 3, 4, 7, 9, 11, 13 };
        int target = 7;

        int result = BinarySearch(array, target);
        if (result == -1)
        {
            Console.WriteLine("Target not found in array");
        }
        else
        {
            Console.WriteLine("Target found at index " + result);
        }
    }

    static int BinarySearch(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (array[mid] == target)
            {
                return mid;
            }
            else if (array[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return -1; // target not found
    }
}
