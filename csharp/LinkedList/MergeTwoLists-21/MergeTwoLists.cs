namespace Solutions.LinkedList
{
    public class MergeTwoListsSolution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            var newHead = new ListNode(-1);

            var firstListIterator = l1;
            var secondListIterator = l2;
            var finalList = newHead;

            while (firstListIterator != null || secondListIterator != null)
            {
                if (firstListIterator == null ||
                (firstListIterator != null && secondListIterator != null && firstListIterator.val >= secondListIterator.val))
                {
                    finalList.next = secondListIterator;
                    secondListIterator = secondListIterator.next;
                }
                else if (secondListIterator == null ||
                (firstListIterator != null && secondListIterator != null && firstListIterator.val < secondListIterator.val))
                {
                    finalList.next = firstListIterator;
                    firstListIterator = firstListIterator.next;
                }

                finalList = finalList.next;
            }
            return newHead.next;
        }
    }
}
