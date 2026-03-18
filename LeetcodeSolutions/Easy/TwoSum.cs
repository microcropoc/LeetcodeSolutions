namespace LeetCodeTests.Easy;

public class TwoSum
{
    [Fact]
    public void Test1()
    {
        //Arrange

        var nums = new int[] { 2, 7, 11, 15 };

        var target = 9;

        //Act

        var result = TwoSumHash(nums, target);

        //Assert

        Assert.Equal([0, 1], result);
    }

    //O(n+m) space O(n)
    public int[] TwoSumHash(int[] nums, int target)
    {
        var hash = new Dictionary<int, int>();

        for(var i = 0; i < nums.Length; i++)
        {
            hash[nums[i]] = i;
        }

        for (var i = 0; i < nums.Length; i++)
        {
            var t = target - nums[i];

            if(hash.TryGetValue(t, out var j))
            {
                if (i != j)
                    return [i, j];
            }
        }

        return [];
    }

    //O(n logN) space O(n)
    public int[] TwoSumTP(int[] nums, int target)
    {
        //O(n logN) space O(n)
        Array.Sort(nums);

        var left = 0;
        var right = nums.Length - 1;

        while (left < right)
        {
            var cur_sum = nums[left] + nums[right];

            if (cur_sum == target)
                return [left, right];

            if(target > cur_sum)
                left++;
            else right--;
        }

        return [];
    }

    //n^2
    public int[] TwoSumN2(int[] nums, int target)
    {
        for (var i = 0; i < nums.Length; i++)
            for (var j = i + 1; j < nums.Length; j++)
                if (nums[i] + nums[j] == target)
                    return [i, j];
        return [];
    }
}
