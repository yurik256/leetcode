using Xunit;

namespace Solutions.LinkedList.Tests
{
    public class MergeTwoListsTest
    {
        private readonly MergeTwoListsSolution _solution;

        public MergeTwoListsTest()
        {
            _solution = new MergeTwoListsSolution();
        }

        [Fact]
        public void ShouldMergeTwoLists()
        {
            var firstList = new ListNode(1);
            firstList.next = new ListNode(2);
            firstList.next.next = new ListNode(4);

            var secondList = new ListNode(1);
            secondList.next = new ListNode(3);
            secondList.next.next = new ListNode(4);

            var result = _solution.MergeTwoLists(firstList, secondList);

            Assert.Equal("1->1->2->3->4->4", result.Print());
        }

        [Fact]
        public void ShouldMergeTwoEmptyLists()
        {
            var result = _solution.MergeTwoLists(null, null);

            Assert.Null(result);
        }

        [Fact]
        public void ShouldMergeFirstNonEmptyListWithSecondEmptyList()
        {
            var firstList = new ListNode(1);
            firstList.next = new ListNode(2);
            firstList.next.next = new ListNode(4);

            ListNode secondList = null;

            var result = _solution.MergeTwoLists(firstList, secondList);

            Assert.Equal("1->2->4", result.Print());
        }

        [Fact]
        public void ShouldMergeEmptyListWithNonEmptyList()
        {

            ListNode firstList = null;

            var secondList = new ListNode(1);
            secondList.next = new ListNode(2);
            secondList.next.next = new ListNode(4);

            var result = _solution.MergeTwoLists(firstList, secondList);

            Assert.Equal("1->2->4", result.Print());
        }

        [Fact]
        public void ShouldMergeTwoListsDifferentLengthWithIntersection()
        {
            var firstList = new ListNode(1);

            var secondList = new ListNode(1);
            secondList.next = new ListNode(6);
            secondList.next.next = new ListNode(7);

            var result = _solution.MergeTwoLists(firstList, secondList);

            Assert.Equal("1->1->6->7", result.Print());
        }

        [Fact]
        public void ShouldMergeTwoListsDifferentLengthWithIntersection2()
        {
            var firstList = new ListNode(1);
            firstList.next = new ListNode(6);
            firstList.next.next = new ListNode(7);

            var secondList = new ListNode(1);

            var result = _solution.MergeTwoLists(firstList, secondList);

            Assert.Equal("1->1->6->7", result.Print());
        }

        [Fact]
        public void ShouldMergeTwoListsDifferentLengthWithoutIntersection()
        {
            var firstList = new ListNode(2);
            firstList.next = new ListNode(4);
            firstList.next.next = new ListNode(6);

            var secondList = new ListNode(1);
            secondList.next = new ListNode(3);
            secondList.next.next = new ListNode(5);

            var result = _solution.MergeTwoLists(firstList, secondList);

            Assert.Equal("1->2->3->4->5->6", result.Print());
        }
    }

}