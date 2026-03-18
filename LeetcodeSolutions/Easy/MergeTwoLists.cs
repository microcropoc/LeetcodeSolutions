using LeetCodeTests.Common;

namespace LeetCodeTests.Easy;

public class MergeTwoLists
{
    [Fact]
    public void Test1()
    {
        var list1 = ListNode.GetListNode([1, 2, 4]);
        var list2 = ListNode.GetListNode([1, 3, 4]);

        var result = MergeTwoLists1(list1, list2);

        var arr = ListNode.GetArray(result);

        Assert.Equal([1, 1, 2, 3, 4, 4], arr);
    }

    public ListNode MergeTwoLists1(ListNode list1, ListNode list2)
    {
        if(list1 is null) return list2;
        if(list2 is null) return list1;

        ListNode head = null!;

        var curr1 = list1;
        var curr2 = list2;

        if(list1.val > list2.val)
        {
            head = list2;
            curr2 = list2.next;
        }
        else
        {
            head = list1;
            curr1 = list1.next;
        }

        var curr = head;

        while (curr1 is not null && curr2 is not null)
        {
            if(curr1.val > curr2.val)
            {
                curr.next = curr2;
                curr2 = curr2.next;
            }
            else
            {
                curr.next = curr1;
                curr1 = curr1.next;
            }

            curr = curr.next;
        }

        if (curr1 is not null)
            curr.next = curr1;
        else if (curr2 is not null)
            curr.next = curr2;

        return head;
    }
}
