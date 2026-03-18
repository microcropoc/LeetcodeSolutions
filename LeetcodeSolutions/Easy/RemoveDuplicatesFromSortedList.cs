using LeetCodeTests.Common;

namespace LeetCodeTests.Easy;

public class RemoveDuplicatesFromSortedList
{
    [Fact]
    public void Test1()
    {
        var list = ListNode.GetListNode([1, 1, 2, 3, 3]);

        var result = DeleteDuplicates(list);

        var arr = ListNode.GetArray(result);

        Assert.Equal([1, 2, 3], arr);
    }


    public ListNode DeleteDuplicates1(ListNode head)
    {
        if (head?.next is null)
            return head!;

        var curr = head;

        while(curr is not null && curr.next is not null)
        {
            if (curr.val == curr.next.val)
            {
                var n = curr.next.next;
                curr.next = n;
            }
            else
            {
                curr = curr.next;
            }
        }

        return head;
    }

    public ListNode DeleteDuplicates(ListNode head)
    {
        void DD(ListNode node)
        {
            if(node is null)
                return;

            if(node.next is not null)
            {
                if(node.val == node.next.val)
                {
                    var n = node.next.next;
                    node.next = n;
                    DD(node);
                }
                else
                {
                    DD(node.next);
                }
            }
        }

        DD(head);

        return head;
    }
}
