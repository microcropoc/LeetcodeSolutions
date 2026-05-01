namespace LeetCodeTests.Easy;

public class SummaryRanges
{
    [Fact]
    public void Test1()
    {

        var result = SummaryRangesSol([0, 1, 2, 4, 5, 7]);

        //Assert

        Assert.True(new string[] { "0->2", "4->5", "7" }.SequenceEqual(result));
    }

    public IList<string> SummaryRangesSol(int[] nums)
    {
        if (nums.Length == 0)
            return [];

        var result = new List<string>();

        var start = nums[0];
        var end = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == end + 1)
                end = nums[i];
            else
            {
                result.Add(start == end ? start.ToString() : $"{start}->{end}");

                start = nums[i];
                end = nums[i];
            }
        }

        result.Add(start == end ? start.ToString() : $"{start}->{end}");

        return result;
    }
}
