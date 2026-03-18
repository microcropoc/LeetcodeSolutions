using LeetCodeTests.Common;

namespace LeetCodeTests.Medium;

public class AddTwoNumbers
{
    [Fact]
    public void Test1()
    {
        var l1 = ListNode.GetListNode([1, 2, 3]);
        var l2 = ListNode.GetListNode([3, 2, 1]);

        var result = AddTwoNumbersR(l1, l2);

        Assert.Equal([4, 4, 4], ListNode.GetArray(result));
    }

    public ListNode AddTwoNumbersR(ListNode l1, ListNode l2)
    {
        ListNode result = null;
        ListNode cur = null;
        var os = 0;

        while (l1 is not null || l2 is not null || os != 0)
        {
            var sum = os;

            if(l1 is not null)
            {
                sum += l1.val;
                l1 = l1.next;
            }

            if (l2 is not null)
            {
                sum += l2.val;
                l2 = l2.next;
            }

            os = sum / 10;
            sum %= 10;

            var node = new ListNode(sum);

            if(result is null)
            {
                result = node;
                cur = result;
            }
            else
            {
                cur.next = node;
                cur = cur.next;
            }
        }

        return result;
    }

}
