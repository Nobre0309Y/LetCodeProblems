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
    public ListNode AddTwoNumbersCOde(ListNode l1, ListNode l2)
    {
        ListNode result = new ListNode(0);
        ListNode test = result;

        int sum = 0;
        int sobe1 = 0;


        while (l1 != null || l2 != null)
        {

            if (l1 != null)
            {
                sum += l1.val;
                l1 = l1.next;
            }
            if (l2 != null)
            {
                sum += l2.val;
                l2 = l2.next;
            }
            test.next = new ListNode(sum % 10);
            test = test.next;
            sobe1 = sum / 10;
            sum = 0;

        }
        if (sobe1 > 0)
        {
            test.next = new ListNode(sobe1);
        }
        return result.next;
    }
}
