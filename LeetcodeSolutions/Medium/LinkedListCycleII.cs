using LeetCodeTests.Common;

namespace LeetCodeTests.Medium;

public class LinkedListCycleII
{
    [Fact]
    public void Test1()
    {
        var n1 = new ListNode(1);

        var n2 = new ListNode(2);

        n1.next = n2;

        n2.next = n1;

        Assert.Equal(n1, DetectCycleLQ(n1));
    }

    //O(N) O(1)
    public ListNode DetectCycle(ListNode head)
    {
        if (head == null || head.next == null)
            return null;

        ListNode slow = head;
        ListNode fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;

            if (slow == fast)
            {
                slow = head;
                while (slow != fast)
                {
                    slow = slow.next;
                    fast = fast.next;
                }
                return slow;
            }
        }

        return null;
    }

    //O(N) O(1)
    public ListNode DetectCycleLQ(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;

        do
        {
            slow = slow?.next;
            fast = fast?.next?.next;

            if (slow == null || fast == null)
                return null;

        } while (slow != fast);

        slow = head;

        while (slow != fast)
        {
            slow = slow.next;
            fast = fast.next;
        }

        return slow;
    }
}
