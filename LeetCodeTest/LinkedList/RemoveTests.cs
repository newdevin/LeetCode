using LeetCode.LinkedList;
using Xunit;

namespace LeetCodeTest.LinkedList
{
    public class RemoveTests
    {
        readonly Remove r;
        public RemoveTests()
        {
            r = new LeetCode.LinkedList.Remove();
        }
        [Fact]
        public void DeleteNodeFromEndTest()
        {
            ListNode head = new ListNode(3);
            head.next = new ListNode(4);
            head.next.next = new ListNode(5);
            head.next.next.next = new ListNode(6);

            head = r.RemoveNthFromEnd(head, 1);

            Assert.Equal(3, head.val);
            Assert.Equal(4, head.next.val);
            Assert.Equal(5, head.next.next.val);
            Assert.Null(head.next.next.next);

        }

        [Fact]
        public void DeleteNodeFromEndTest2()
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);

            head = r.RemoveNthFromEnd(head, 1);

            Assert.Equal(1, head.val);
            Assert.Null(head.next);

        }

        [Fact]
        public void DeleteSecondNodeFromEndTest()
        {
            ListNode head = new ListNode(3);
            head.next = new ListNode(4);
            head.next.next = new ListNode(5);
            head.next.next.next = new ListNode(6);

            head = r.RemoveNthFromEnd(head, 2);

            Assert.Equal(3, head.val);
            Assert.Equal(4, head.next.val);
            Assert.Equal(6, head.next.next.val);
            Assert.Null(head.next.next.next);

        }

        [Fact]
        public void DeleteLastNodeFromEndTest()
        {
            ListNode head = new ListNode(3);
            head.next = new ListNode(4);
            head.next.next = new ListNode(5);
            head.next.next.next = new ListNode(6);

            head = r.RemoveNthFromEnd(head, 4);

            Assert.Equal(4, head.val);
            Assert.Equal(5, head.next.val);
            Assert.Equal(6, head.next.next.val);
            Assert.Null(head.next.next.next);

        }

        [Fact]
        public void DeleteNonExistentNodeFromEndTest()
        {
            ListNode head = new ListNode(3);
            head.next = new ListNode(4);
            head.next.next = new ListNode(5);
            head.next.next.next = new ListNode(6);

            head = r.RemoveNthFromEnd(head, 10);

            Assert.Equal(3, head.val);
            Assert.Equal(4, head.next.val);
            Assert.Equal(5, head.next.next.val);
            Assert.Equal(6, head.next.next.next.val);
            Assert.Null(head.next.next.next.next);

        }

    }

}