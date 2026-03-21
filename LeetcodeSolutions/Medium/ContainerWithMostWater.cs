namespace LeetCodeTests.Medium;

public class ContainerWithMostWater
{
    [Fact]
    public void Test1()
    {
        int[] height = [1, 8, 6, 2, 5, 4, 8, 3, 7];

        var result = MaxArea(height);

        Assert.Equal(49, result);
    }

    public int MaxArea(int[] height)
    {
        var left = 0;
        var right = height.Length - 1;

        var maxArea = 0;

        while (left < right)
        {
            maxArea = Math.Max(Math.Min(height[left], height[right]) * (right - left), maxArea);

            if (height[left] < height[right])
                left++;
            else
                right--;
        }

        return maxArea;
    }
}
