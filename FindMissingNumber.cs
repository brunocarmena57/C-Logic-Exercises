using System;


// Find the missing number, being in this case #3

namespace FindMissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1, 2, 4, 5, 6};
            int missingNumber = FindMissingNumber(nums);
            Console.WriteLine("The missing number is: " + missingNumber);
        }

        public static int FindMissingNumber(int[] nums)
        {
            int n = nums.Length + 1;
            int sum = (n * (n + 1)) / 2;
            int missingNumber = sum;

            for (int i = 0; i < nums.Length; i++)
            {
                missingNumber -= nums[i];
            }

            return missingNumber;
        }
    }
}