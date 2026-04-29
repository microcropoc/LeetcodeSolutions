namespace LeetCodeTests.Medium;

public class MaxConsecutiveOnesIII
{
    [Fact]
    public void Test1()
    {
        var result = LongestOnes([1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0], 2);

        Assert.Equal(6, result);
    }

    public int LongestOnes(int[] nums, int k)
    {
        var left = 0;
        var zc = 0;
        var maxLen = 0;

        for (var right = 0; right < nums.Length; right++)
        {
            if (nums[right] == 0)
                zc++;

            while (zc > k)
            {
                if (nums[left] == 0)
                    zc--;
                left++;
            }

            maxLen = Math.Max(maxLen, right - left + 1);
        }

        return maxLen;
    }

}
