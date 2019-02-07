using System;

namespace Solutions.LinkedList
{
    public class ReverseLinkedListSolution
    {
        public ListNode ReverseList(ListNode head)
        {
            var current = head;
            ListNode prev = null;

            while (current != null)
            {
                var next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            return prev;
        }

        public ListNode ReverseList2(ListNode head)
        {
            ListNode newHead = null;

            while (head != null)
            {
                var next = head.next;
                head.next = newHead;

                newHead = head;
                head = next;
            }

            return newHead;
        }

        public ListNode ReverseListRecursive(ListNode head)
        {
            return ReverseListRecursive(head, null);
        }

        private ListNode ReverseListRecursive(ListNode head, ListNode newHead)
        {
            if (head == null)
            {
                return newHead;
            }

            var next = head.next;
            head.next = newHead;

            return ReverseListRecursive(next, head);
        }
    }
}