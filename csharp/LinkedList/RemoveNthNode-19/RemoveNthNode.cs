namespace Solutions.LinkedList
{
    public class RemoveNthNodeSolution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var temp = head;
            var length = 0;

            while (temp != null)
            {
                temp = temp.next;
                length++;
            }

            temp = head;

            if (n == length)
            {
                temp = temp.next;
                return temp;
            }

            var steps = length - n - 1;

            temp = head;

            while (steps > 0)
            {
                temp = temp.next;
                steps--;
            }

            temp.next = temp.next.next;

            return head;
        }

        public ListNode RemoveNthFromEndTwoPointers(ListNode head, int n)
        {
            var start = new ListNode(0);
            start.next = head;

            var slowPointer = start;
            var fastPointer = start;

            for (var i = 1; i <= n + 1; i++)
            {
                fastPointer = fastPointer.next;
            }

            while (fastPointer != null)
            {
                fastPointer = fastPointer.next;
                slowPointer = slowPointer.next;
            }

            slowPointer.next = slowPointer.next.next;

            return start.next;
        }
    }
}