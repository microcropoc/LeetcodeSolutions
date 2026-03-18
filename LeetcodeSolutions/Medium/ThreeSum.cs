namespace LeetCodeTests.Medium;

public class ThreeSum
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
            //перемотка дубликатов
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            var left = i + 1;
            var right = nums.Length - 1;

            while (left < right)
            {
                var sum = nums[i] + nums[left] + nums[right];

                if(sum == 0)
                {
                    result.Add(new List<int>() { nums[i], nums[left], nums[right] });

                    //перемотка дубликатов
                    while (left < right && nums[left] == nums[left + 1])
                        left++;

                    //перемотка дубликатов
                    while (left < right && nums[right] == nums[right - 1])
                        right--;

                    left++;
                    right--;
                }
                else if(sum < 0)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }

        return result.Select(i => (IList<int>)i.OrderBy(j => j).ToArray()).OrderBy(i => i.Count).ToList();
    }
}
