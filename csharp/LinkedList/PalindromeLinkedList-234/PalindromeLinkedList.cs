namespace Solutions.LinkedList
{
    public class PalindromeLinkedListSolution
    {
        public bool IsPalindrome(ListNode head)
        {
            if (head == null)
            {
                return true;
            }

            var slow = head;
            var fast = head;

            while (fast.next != null && fast.next.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            slow = slow.next;

            var secondHalfPointer = reverseList(slow);
            var firstHalfPointer = head;

            while (secondHalfPointer != null)
            {
                if (secondHalfPointer.val != firstHalfPointer.val)
                {
                    return false;
                }
                secondHalfPointer = secondHalfPointer.next;
                firstHalfPointer = firstHalfPointer.next;
            }

            return true;
        }

        private ListNode reverseList(ListNode head)
        {
            ListNode current = head;
            ListNode prev = null;

            while (current != null)
            {
                var temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }

            return prev;
        }
    }
}
