using System.Text;

namespace Solutions.LinkedList
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
        }

        public string Print()
        {
            StringBuilder output = new StringBuilder();
            var temp = this;
            while (temp != null)
            {
                output.Append(temp.val);
                if (temp.next != null)
                {
                    output.Append("->");
                }
                temp = temp.next;
            }

            return output.ToString();
        }
    }
}