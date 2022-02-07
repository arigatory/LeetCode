using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] nums = new  int[] {0,4,3,0 }; // Input array
            int target = 0;
            var sol = new Solution();
            
            var res = sol.TwoSum(nums, target); // Calls your implementation
            foreach (var item in res)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }
    }

    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int i = 0;

            foreach (int num in nums)
            {
                if (i < 2 || num > nums[i - 2])
                {
                    nums[i++] = num;
                }
            }

            return i;
        }

        public int[] TwoSum(int[] nums, int target)
        {
            int i = 0;
            
            int j;
            int n = nums.Length;
            while (i<n)
            {
                j = i + 1;
                while (j<n)
                {
                    if (nums[i]+ nums[j] == target)
                    {
                        return new int[]{i,j};
                    }
                    j++;
                }
                i++;
            }

            return null;
        }

    }
}
