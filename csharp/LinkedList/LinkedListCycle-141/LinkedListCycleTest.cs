using Xunit;

namespace Solutions.LinkedList.Tests
{
    public class LinkedListCycleSolutionTest
    {
        private readonly LinkedListCycleSolution _solution;
        public LinkedListCycleSolutionTest()
        {
            _solution = new LinkedListCycleSolution();
        }

        [Fact]
        public void ShouldReturnTrue()
        {
            var head = new ListNode(3);
            head.next = new ListNode(2);
            head.next.next = new ListNode(0);
            head.next.next = new ListNode(-4);
            head.next.next.next = head.next;

            var result = _solution.HasCycle(head);

            Assert.True(result);
        }

        [Fact]
        public void ShouldReturnTrue2()
        {
            var head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = head;

            var result = _solution.HasCycle(head);

            Assert.True(result);
        }

        [Fact]
        public void ShouldReturnFalse()
        {
            var head = new ListNode(1);

            var result = _solution.HasCycle(head);

            Assert.False(result);
        }

        [Fact]
        public void ShouldReturnFalseForEmptyList()
        {
            ListNode head = null;

            var result = _solution.HasCycle(head);

            Assert.False(result);
        }

        [Fact]
        public void ShouldReturnFalse2()
        {
            var head = new ListNode(1);
            head.next = new ListNode(2);

            var result = _solution.HasCycle(head);

            Assert.False(result);
        }
    }
}