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

        for (var i = 0; i < nums.Length; i++)
        {
            var c = target - nums[i];

            if (hash.ContainsKey(c))
                return [hash[c], i];

            hash[nums[i]] = i;
        }

        return [];
    }

    //n^2
    public int[] TwoSumN2(int[] nums, int target)
    {
        for (var i = 0; i < nums.Length; i++)
            for (var j = i + 1; j < nums.Length; j++)
                if (nums[i] + nums[j] == target && i != j)
                    return [i, j];
        return [];
    }
}
