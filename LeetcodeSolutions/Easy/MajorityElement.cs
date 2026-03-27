namespace LeetCodeTests.Easy;

public class MajorityElement
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(2, MajorityElementBest([2, 2, 1, 1, 1, 2, 2]));
    }

    public int MajorityElementLINQ(int[] nums)
    {
        return nums.GroupBy(i => i).MaxBy(i => i.Count())!.Key;
    }

    public int MajorityElementSorted(int[] nums)
    {
        Array.Sort(nums);

        return nums[nums.Length / 2];
    }

    public int MajorityElementHash(int[] nums)
    {
        Array.Sort(nums);

        return nums[nums.Length / 2];
    }

    public int MajorityElementBest(int[] nums)
    {
        var curr = 0;
        var count = 0;

        foreach (var item in nums)
        {
            if (count == 0)
            {
                curr = item;
                count = 1;
            }
            else
            {
                if (curr == item)
                    count++;
                else
                    count--;
            }
        }

        return curr;
    }
}
