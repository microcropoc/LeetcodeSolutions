namespace LeetCodeTests.Easy;

public class MaximumAverageSubarrayI
{
    [Fact]
    public void Test1()
    {
        //Arrange

        int[] data = [1, 12, -5, -6, 50, 3];
        var k = 4;

        //Act

        var result = FindMaxAverage(data, k);

        //Assert

        Assert.Equal(12.75000, result);
    }

    //O(n)	O(1)
    public double FindMaxAverage(int[] nums, int k)
    {
        double sum = 0;

        for (var i = 0; i < k; i++)
        {
            sum += nums[i];
        }

        double maxSum = sum;

        for (var i = k; i < nums.Length; i++)
        {
            sum += nums[i] - nums[i - k];
            maxSum = Math.Max(maxSum, sum);
        }

        return maxSum / k;
    }

    //O(n × k)	O(k)
    public double FindMaxAverageLQ(int[] nums, int k)
    {
        var left = 0;
        var maxAvg = 0.0;

        for (var right = k - 1; right < nums.Length; right++)
        {
            var len = right + 1;

            maxAvg = Math.Max(maxAvg, nums[left..len].Average());

            left++;
        }

        return maxAvg;
    }
}
