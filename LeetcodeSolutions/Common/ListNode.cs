namespace LeetCodeTests.Common;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }

    public static ListNode GetListNode(int[] values)
    {
        ListNode head = new ListNode(values[0]);

        if (values.Length == 1)
            return head;

        ListNode curr = head;

        for (int i = 1; i < values.Length; i++)
        {
            var next = new ListNode(values[i]);

            curr.next = next;

            curr = next;
        }

        return head;
    }

    public static int[] GetArray(ListNode head)
    {
        var list = new List<int>();

        var curr = head;

        while(curr is not null)
        {
            list.Add(curr.val);
            curr = curr.next;
        }

        return list.ToArray();
    }
}
