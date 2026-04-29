namespace LeetCodeTests.Medium;

public class _3Sum
{
    [Fact]
    public void Test1()
    {
        int[] nums = [-1, 0, 1, 2, -1, -4];
        List<List<int>> r = [[-1, -1, 2], [-1, 0, 1]];

        var result = ThreeSumTP(nums);

        Assert.Equal(r, result);
    }

    public IList<IList<int>> ThreeSumTP(int[] nums)
    {
        var result = new List<IList<int>>();

        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++)
        {

            //перемотка дублей
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            var l = i + 1;
            var r = nums.Length - 1;

            while (l < r)
            {
                var sum = nums[i] + nums[l] + nums[r];

                if (sum == 0)
                {
                    result.Add([nums[i], nums[l], nums[r]]);

                    //перемотка дублей
                    while (l < r && nums[l] == nums[l + 1])
                        l++;

                    //перемотка дублей
                    while (l < r && nums[r] == nums[r - 1])
                        r--;

                    l++;
                    r--;
                }
                else
                if (sum > 0)
                    r--;
                else
                    l++;
            }
        }

        return result;
    }
}
