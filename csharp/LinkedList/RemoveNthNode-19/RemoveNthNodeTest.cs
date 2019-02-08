using Xunit;

namespace Solutions.LinkedList.Tests
{
    public class RemoveNthNodeTest
    {
        private readonly RemoveNthNodeSolution _solution;

        public RemoveNthNodeTest()
        {
            _solution = new RemoveNthNodeSolution();
        }

        [Fact]
        public void ShouldRemoveNodeFromFrontOfTheList()
        {
            var head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);

            var result = _solution.RemoveNthFromEnd(head, 3);

            Assert.Equal("2->3", result.Print());
        }

        [Fact]
        public void ShouldRemoveNodeFromBackOfTheList()
        {
            var head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);

            var result = _solution.RemoveNthFromEnd(head, 1);

            Assert.Equal("1->2", result.Print());
        }

        [Fact]
        public void ShouldRemoveNodeFromMiddleOfTheList()
        {
            var head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);

            var result = _solution.RemoveNthFromEnd(head, 2);

            Assert.Equal("1->3", result.Print());
        }

        [Fact]
        public void ShouldRemoveNodeWhenOneElementInTheList()
        {
            var head = new ListNode(1);

            var result = _solution.RemoveNthFromEnd(head, 1);

            Assert.Null(result);
        }
    }

}