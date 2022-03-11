using System;

namespace t61_RotateList
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
        }
    }

    public class Solution
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null || k == 0)
            {
                return head;
            }
            var current = head;
            int numberOfNodes = 1;
            while (current.next != null)
            {
                numberOfNodes++;
                current= current.next;
            }

            var rotateTimes = k % numberOfNodes;
            current.next = head;

            ListNode result = head;

            while (numberOfNodes < k && result != null)
            {
                result = result.next;
                numberOfNodes++;
            }

            if (numberOfNodes!=k)
            {

            }



            return result;
        }
    }
