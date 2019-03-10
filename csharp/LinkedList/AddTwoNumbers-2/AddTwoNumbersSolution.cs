namespace Solutions.LinkedList
{
    // 2. Add Two Numbers
    // https://leetcode.com/problems/add-two-numbers/
    public class AddTwoNumbersSolution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var temp1 = l1;
            var temp2 = l2;
            ListNode result = new ListNode(-1);
            var temp = result;

            var leftOver = 0;

            while (temp1 != null || temp2 != null)
            {
                var val = leftOver;

                if (temp1 != null)
                {
                    val += temp1.val;
                    temp1 = temp1.next;
                }

                if (temp2 != null)
                {
                    val += temp2.val;
                    temp2 = temp2.next;
                }

                leftOver = val >= 10 ? 1 : 0;
                val = val % 10;
                temp.next = new ListNode(val);
                temp = temp.next;
            }

            if (leftOver > 0)
            {
                temp.next = new ListNode(1);
            }

            return result.next;
        }

    }
}
