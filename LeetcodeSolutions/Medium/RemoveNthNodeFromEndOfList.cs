using LeetCodeTests.Common;

namespace LeetCodeTests.Medium;

public class RemoveNthNodeFromEndOfList
{
    [Fact]
    public void Test1()
    {
        var result = RemoveNthFromEndPQ(ListNode.GetListNode([1, 2, 3, 4, 5]), 2);

        Assert.Equal([1, 2, 3, 5], ListNode.GetArray(result));
    }

    public ListNode RemoveNthFromEndPQ(ListNode head, int n)
    {
        var dummy = new ListNode();

        dummy.next = head;

        var fast = dummy;
        var slow = dummy;

        for(int i = 0; i < n; i++)
            fast = fast.next;

        while(fast.next is not null)
        {
            slow = slow.next;
            fast = fast.next;
        }

        slow.next = slow.next.next;

        return dummy.next;
    }
}
