using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] nums = new int[] { 0, 4, 3, 0 }; // Input array
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
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0;
            var p1 = l1;
            var p2 = l2;

            var sum = p1.val + p2.val;
            ListNode res = new ListNode(sum < 10 ? sum : sum - 10);
            ListNode pRes = res;
            carry = sum < 10 ? 0 : 1;

            p1 = p1.next;
            p2 = p2.next;

            while (p1 != null && p2 != null)
            {
                sum = p1.val + p2.val + carry;
                pRes.next = new ListNode(sum < 10 ? sum : sum - 10);
                carry = sum < 10 ? 0 : 1;
                pRes = pRes.next;

                p1 = p1.next;
                p2 = p2.next;
            }
            
            while (p1 != null)
            {
                sum = p1.val + carry;
                pRes.next = new ListNode(sum < 10 ? sum : sum - 10);
                carry = sum < 10 ? 0 : 1;
                pRes = pRes.next;
                p1 = p1.next;
            }

            while (p2 != null)
            {
                sum = p2.val + carry;
                pRes.next = new ListNode(sum < 10 ? sum : sum - 10);
                carry = sum < 10 ? 0 : 1;
                pRes = pRes.next;
                p2 = p2.next;
            }
            if (carry != 0)
            {
                pRes.next = new ListNode(carry);
            }
            return res;
        }

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
            while (i < n)
            {
                j = i + 1;
                while (j < n)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                    j++;
                }
                i++;
            }

            return null;
        }

    }
}
