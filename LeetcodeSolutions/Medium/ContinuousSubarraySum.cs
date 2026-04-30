namespace LeetCodeTests.Medium;

public class ContinuousSubarraySum
{
    [Fact]
    public void Test1()
    {
        Assert.True(CheckSubarraySum([23, 2, 4, 6, 7], 6));
    }

    //O(N) O(N)
    public bool CheckSubarraySum(int[] nums, int k)
    {
        var prefix = new Dictionary<int, int>();

        prefix[0] = -1;
        
        var sum = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            sum += nums[i];

            var o = k == 0 ? sum : sum % k;

            if (prefix.ContainsKey(o))
            {
                if (i - prefix[o] >= 2)
                    return true;
            }
            else
            {
                prefix[o] = i;
            }
        }

        return false;
    }
}
