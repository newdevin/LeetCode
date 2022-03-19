using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    public class Remove
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode curr = head;
            ListNode pre = head;
            int i = 0;
            int len = 0;
            while (curr is not null)
            {
                if (i > n)
                    pre = pre.next;
                i++;
                len++;
                curr = curr.next;
            }

            if (len < n)
            {
                return head;
            }
            if (len == n)
            {
                return head.next;
            }

            if (pre.next != null)
                pre.next = pre.next.next;

            return head;
        }
    }
}
