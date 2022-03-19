using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    public class Add
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode list = new ListNode();
            ListNode cur1 = l1, cur2 = l2;
            int carry = 0;
            int i = 0;
            ListNode curr = list;
            while (cur1 != null && cur2 != null)
            {
                int sum = (cur1.val + cur2.val + carry);
                int result = sum % 10;
                carry = (sum >= 10) ? 1 : 0;

                if (i == 0)
                {
                    curr = new ListNode(result, null);
                    list = curr;
                }
                else
                {
                    curr.next = new ListNode(result, null);
                    curr = curr.next;
                }
                i++;
                cur1 = cur1.next;
                cur2 = cur2.next;
            }
            ListNode c = null;
            if (cur1 != null)
                c = cur1;
            else if (cur2 != null)
                c = cur2;

            while(c != null)
            {
                int sum = c.val + carry;
                int result = sum % 10;
                carry = sum >= 10 ? 1 : 0;

                curr.next = new ListNode(result);
                curr = curr.next;
                c = c.next;
            }
            if( carry> 0)
            {
                curr.next = new ListNode(carry);
            }

            return list;

        }
    }
}
