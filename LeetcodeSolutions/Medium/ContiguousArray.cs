namespace LeetCodeTests.Medium;

public class ContiguousArray
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(6, FindMaxLength([0, 1, 1, 1, 1, 1, 0, 0, 0]));
    }

    public int FindMaxLength(int[] nums)
    {
        var p = new Dictionary<int, int>();
        p[0] = -1;
        var m = 0;
        var s = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            s += nums[i] == 0 ? -1 : 1;

            if (p.ContainsKey(s))
            {
                m = Math.Max(m, i - p[s]);
            }
            else
            {
                p.Add(s, i);
            }
        }

        return m;
    }
}
