using Xunit;

namespace Solutions.LinkedList.Tests
{
    public class PalindromeLinkedListTest
    {
        private readonly PalindromeLinkedListSolution _solution;

        public PalindromeLinkedListTest()
        {
            _solution = new PalindromeLinkedListSolution();
        }

        [Fact]
        public void ShouldReturnTrueForEmptyList()
        {
            ListNode firstList = null;

            var result = _solution.IsPalindrome(firstList);

            Assert.True(result);
        }

        [Fact]
        public void ShouldReturnTrueForListWithOneNode()
        {
            ListNode firstList = new ListNode(1);

            var result = _solution.IsPalindrome(firstList);

            Assert.True(result);
        }

        [Fact]
        public void ShouldReturnFalse()
        {
            ListNode firstList = new ListNode(1);
            firstList.next = new ListNode(2);
            firstList.next.next = new ListNode(1);
            firstList.next.next.next = new ListNode(1);

            var result = _solution.IsPalindrome(firstList);

            Assert.False(result);
        }

        [Fact]
        public void ShouldReturnTrue()
        {
            ListNode firstList = new ListNode(1);
            firstList.next = new ListNode(2);
            firstList.next.next = new ListNode(2);
            firstList.next.next.next = new ListNode(1);

            var result = _solution.IsPalindrome(firstList);

            Assert.True(result);
        }
    }

}