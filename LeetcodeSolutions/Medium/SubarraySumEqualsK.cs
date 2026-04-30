namespace LeetCodeTests.Medium;

public class SubarraySumEqualsK
{
    [Fact]
    public void Test1()
    {
        var result = SubarraySum([1, 1, 1], 2);

        Assert.Equal(2, result);
    }

    public int SubarraySum(int[] nums, int k)
    {
        var prefix = new Dictionary<int, int>();

        prefix[0] = 1;
        var sum = 0;
        var count = 0;

        foreach (var n in nums)
        {
            sum += n;

            var t = sum - k;

            if (prefix.ContainsKey(t))
            {
                count += prefix[t];
            }

            if (prefix.ContainsKey(sum))
            {
                prefix[sum]++;
            }
            else
            {
                prefix[sum] = 1;
            }
        }

        return count;
    }

    //O(N) O(1)
    public int SubarraySumLQ(int[] nums, int k)
    {
        var c = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            var sum = 0;

            for (int j = i; j < nums.Length; j++)
            {
                sum += nums[j];
                if (sum == k)
                    c++;
            }
        }

        return c;
    }
}
