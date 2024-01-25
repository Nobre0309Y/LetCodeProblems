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
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var List1 = new List<int>();
            var List2 = new List<int>();
             
            while (l1.next != null)
            {
                List1.Add(l1.next.val);
            }
            while(l2.next != null)
            {
                List2.Add(l2.next.val);
            }

            var sum1 = List1[0];
            int aux = 0;
            while (List1.Count() < aux)
            {
                sum1 +=  10 ^ aux * List1[aux] + sum1;
                aux++;
            }

            int sum2 = List2[0];
            aux = 0;
            while (List2.Count() < aux)
            {
                sum2 += 10 ^ aux * List2[aux] + sum2;
                aux++;
            }
            var sumTotal = sum1 + sum2; 

            var result = new ListNode();
            while(sumTotal / 10 > 0)
            {
                result.val = 
            }

            return new ListNode();
        }

    }
}
