using Xunit;

namespace Solutions.LinkedList.Tests
{
    public class ReverseLinkedListSolutionTest
    {
        private ReverseLinkedListSolution _solution;

        public ReverseLinkedListSolutionTest()
        {
            _solution = new ReverseLinkedListSolution();
        }

        [Fact]
        public void ShouldReverseLinkedList()
        {
            var head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);

            var result = _solution.ReverseList(head);

            Assert.Equal(3, result.val);
            Assert.Equal(2, result.next.val);
            Assert.Equal(1, result.next.next.val);
        }

        [Fact]
        public void ShouldReverseLinkedListWhenListHasOneNode()
        {
            var head = new ListNode(1);

            var result = _solution.ReverseList(head);

            Assert.Equal(1, head.val);
            Assert.Null(head.next);
        }

        [Fact]
        public void ShouldReturnNullWhenLinkedListWhenListIsEmpty()
        {
            ListNode head = null;

            var result = _solution.ReverseList(head);

            Assert.Null(head);
        }

        [Fact]
        public void ReverseList2ShouldReverseLinkedList()
        {
            var head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);

            var result = _solution.ReverseList2(head);

            Assert.Equal(3, result.val);
            Assert.Equal(2, result.next.val);
            Assert.Equal(1, result.next.next.val);
        }

        [Fact]
        public void ReverseList2ShouldReverseLinkedListWhenListHasOneNode()
        {
            var head = new ListNode(1);

            var result = _solution.ReverseList2(head);

            Assert.Equal(1, head.val);
            Assert.Null(head.next);
        }

        [Fact]
        public void ReverseList2ShouldReturnNullWhenLinkedListWhenListIsEmpty()
        {
            ListNode head = null;

            var result = _solution.ReverseList2(head);

            Assert.Null(head);
        }

        [Fact]
        public void ReverseListRecursiveShouldReverseLinkedList()
        {
            var head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);

            var result = _solution.ReverseListRecursive(head);

            Assert.Equal(3, result.val);
            Assert.Equal(2, result.next.val);
            Assert.Equal(1, result.next.next.val);
        }

        [Fact]
        public void ReverseListRecursiveShouldReverseLinkedListWhenListHasOneNode()
        {
            var head = new ListNode(1);

            var result = _solution.ReverseListRecursive(head);

            Assert.Equal(1, head.val);
            Assert.Null(head.next);
        }

        [Fact]
        public void ReverseListRecursiveShouldReturnNullWhenLinkedListWhenListIsEmpty()
        {
            ListNode head = null;

            var result = _solution.ReverseListRecursive(head);

            Assert.Null(head);
        }
    }
}