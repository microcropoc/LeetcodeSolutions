namespace LeetCodeTests.Easy;

public class BinarySearch
{
    [Fact]
    public void Test1()
    {
        var nums = new int[]{-1, 0, 3, 5, 9, 12};
        var target = 9;

        var result = SearchR(nums, target);

        Assert.Equal(4, result);
    }

    //O(log n) O(1)
    public int Search(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;

        while (left <= right)
        {
            var pos = left + (right - left) / 2;
            if (nums[pos] == target)
                return pos;

            if (nums[pos] > target)
            {
                right = pos - 1;
            }
            else
            {
                left = pos + 1;
            }

        }

        return -1;
    }

    //O(log n) O(log n)
    public int SearchR(int[] nums, int target)
    {
        int R(int[] nums, int target, int left, int right)
        {
            if (left > right)
                return -1;

            var pos = left + (right - left) / 2;

            if (nums[pos] == target)
                return pos;

            if (nums[pos] > target)
            {
                return R(nums, target, left, pos - 1);
            }
            else
            {
                return R(nums, target, pos + 1, right);
            }
        }

        return R(nums, target, 0, nums.Length - 1);
    }
}
