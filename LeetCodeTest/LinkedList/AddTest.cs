using LeetCode.LinkedList;
using Xunit;

namespace LeetCodeTest.LinkedList
{
    public class AddTest
    {
        [Fact]
        public void AddListsOfSameSize()
        {
            Add a = new Add();
            var l1 = new ListNode();
            l1.val = 2;
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);

            var l2 = new ListNode();
            l2.val = 5;
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);


            var l3 = a.AddTwoNumbers(l1, l2);

            Assert.Equal(7, l3.val);
            Assert.Equal(0, l3.next.val);
            Assert.Equal(8, l3.next.next.val);

        }

        [Fact]
        public void AddListsOfDifferentSize()
        {
            Add a = new Add();
            var l1 = new ListNode();
            l1.val = 2;
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);

            var l2 = new ListNode();
            //l2.val = 5;
            //l2.next = new ListNode(6);
            
            var l3 = a.AddTwoNumbers(l1, l2);

            Assert.Equal(2, l3.val);
            Assert.Equal(4, l3.next.val);
            Assert.Equal(3, l3.next.next.val);

        }


        [Fact]
        public void AddListsOfDifferentWithCarrySize()
        {
            Add a = new Add();
            var l1 = new ListNode();
            l1.val = 9;
            l1.next = new ListNode(9);
            l1.next.next = new ListNode(9);

            var l2 = new ListNode();
            l2.val = 9;
            
            var l3 = a.AddTwoNumbers(l1, l2);

            Assert.Equal(8, l3.val);
            Assert.Equal(0, l3.next.val);
            Assert.Equal(0, l3.next.next.val);
            Assert.Equal(1, l3.next.next.next.val);

        }
    }

}