using System;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] nums = new  int[] { 1,2,2,2}; // Input array
            int[] expectedNums = new int[]{ 1, 1, 2, 2, 3}; // The expected answer with correct length
            var sol = new Solution();
            int k = sol.RemoveDuplicates(nums); // Calls your implementation
            foreach (var item in nums)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
            Console.WriteLine(k);
        }
    }

    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int j = 0;
            int i = 1;

            while (i < nums.Length)
            {
                if (nums[i]==nums[j])
                {
                    while (nums[i]==nums[j])
                    {
                        i++;
                        if (i==nums.Length)
                        {
                            j++;
                            nums[j] = nums[i-1];
                            return j+1;
                        }
                    }
                    j++;
                    nums[j]=nums[j-1];
                }
                else
                {
                    j++;
                    nums[j]=nums[i];
                    i++;
                }
            }
            return j+1;
        }
    }
}
