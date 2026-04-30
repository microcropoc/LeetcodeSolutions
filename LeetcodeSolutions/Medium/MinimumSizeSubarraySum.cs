namespace LeetCodeTests.Medium;

public class MinimumSizeSubarraySum
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(2, MinSubArrayLen(7, [2, 3, 1, 2, 4, 3]));
    }

    public int MinSubArrayLen(int target, int[] nums)
    {
        var left = 0;
        var sum = 0;
        int minLength = int.MaxValue;

        for (int right = 0; right < nums.Length; right++)
        {
            sum += nums[right];

            while (sum >= target)
            {
                minLength = Math.Min(minLength, right - left + 1);
                sum -= nums[left];
                left++;
            }
        }

        return minLength == int.MaxValue ? 0 : minLength;
    }
}
