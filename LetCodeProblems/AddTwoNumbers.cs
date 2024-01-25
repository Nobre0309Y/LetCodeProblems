using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetCodeProblems
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class AddTwoNumbers
    {
        public ListNode AddTwoNumbersCode(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode(l1.val + l2.val);


            int sum = 0;
            int sobe1 = 0;

            while (l1.next != null || l2.next != null) 
            {
                if (l1.next != null)
                {
                    sum += l1.next.val;
                    l1= l1.next;
                }
                if (l2.next != null)
                {
                    sum += l2.next.val;
                    l2 = l2.next;
                }
                sum += sobe1;
                result = new ListNode(sum % 10);
                sobe1 = (l1.val + l2.val) / 10; 
                

            }
            return result;  
        }

    }
}
