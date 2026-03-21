using LeetCodeTests.Common;

namespace LeetCodeTests.Medium;

public class MergeKLists
{
    [Fact]
    public void Test1()
    {
        ListNode[] listNodes = [ListNode.GetListNode([1, 4, 5]), ListNode.GetListNode([1, 3, 4]), ListNode.GetListNode([2, 6])];

        var result = MergeKListstPQ(listNodes);

        Assert.Equal([1, 1, 2, 3, 4, 4, 5, 6], ListNode.GetArray(result));
    }

    public ListNode MergeKListstPQ(ListNode[] lists)
    {
        if (lists is null || lists.Length == 0)
            return null!;

        var dummy = new ListNode();
        var heap = new PriorityQueue<ListNode, int>();

        foreach (ListNode listNode in lists)
        {
            if (listNode is not null)
                heap.Enqueue(listNode, listNode.val);
        }

        var curr = dummy;

        while (heap.Count > 0)
        {
            var min = heap.Dequeue();
            curr.next = min;
            curr = curr.next;

            if (min.next is not null)
            {
                heap.Enqueue(min.next, min.next.val);
            }
        }

        return dummy.next;
    }
}
