using LeetCodeTests.Common;

namespace LeetCodeTests.Easy;

public class LinkedListCycle
{
    [Fact]
    public void Test1()
    {
        var n1 = new ListNode(1);

        var n2 = new ListNode(2);

        n1.next = n2;

        n2.next = n1;

        var result = HasCycleSF(n1);

        Assert.True(result);
    }

    public bool HasCycleHash(ListNode head)
    {
        var set = new HashSet<ListNode>();

        var curr = head;

        while (curr is not null)
        {
            if (set.Contains(curr))
                return true;

            set.Add(curr);

            curr = curr.next;
        }

        return false;
    }

    public bool HasCycleSF(ListNode head)
    {
        ListNode fast = head.next;
        ListNode slow = head;

        while(fast is not null && slow is not null)
        {
            if (fast == slow)
                return true;

            fast = fast.next.next;
            slow = slow.next;
        }

        return false;
    }
}
