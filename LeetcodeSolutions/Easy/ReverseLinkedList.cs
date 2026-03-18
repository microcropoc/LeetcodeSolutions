using LeetCodeTests.Common;

namespace LeetCodeTests.Easy;

public class ReverseLinkedList
{
    [Fact]
    public void Test1()
    {
        var list = ListNode.GetListNode([1, 2, 3, 4, 5]);

        var result = ReverseList(list);

        var arr = ListNode.GetArray(result);

        Assert.Equal([5, 4, 3, 2, 1], arr);
    }

    [Fact]
    public void Test2()
    {
        var list = ListNode.GetListNode([1,2]);

        var result = ReverseList(list);

        Assert.Equal([2, 1], ListNode.GetArray(result));
    }


    [Fact]
    public void Test3()
    {
        var list = ListNode.GetListNode([1, 2]);

        Assert.Equal([1, 2], ListNode.GetArray(list));
    }



    public ListNode ReverseList(ListNode head)
    {
        if(head.next is null)
            return head;

        var prev = head;

        var curr = head.next;

        prev.next = null!;

        while(curr is not null)
        {
            var next = curr.next;

            curr.next = prev;

            prev = curr;

            curr = next;
        }

        return prev;
    }

}
