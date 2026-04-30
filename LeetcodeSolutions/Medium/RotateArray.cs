namespace LeetCodeTests.Medium;

public class RotateArray
{
    [Fact]
    public void Test1()
    {
        int[] nums = [1, 2, 3, 4, 5, 6, 7];

        Rotate(nums, 3);

        Assert.Equal([5, 6, 7, 1, 2, 3, 4], nums);
    }

    //O(N) O(1)
    public void Rotate(int[] nums, int k)
    {
        k = k % nums.Length;
        if (k == 0)
            return;

        void rotate(int[] nums, int start, int end)
        {
            while (start < end)
            {
                (nums[start], nums[end]) = (nums[end], nums[start]);

                start++;
                end--;
            }
        }

        rotate(nums, 0, nums.Length - 1);
        rotate(nums, 0, k - 1);
        rotate(nums, k, nums.Length - 1);
    }

    //O(N) O(N)
    public void RotateLQ(int[] nums, int k)
    {
        k = k % nums.Length;
        if (k == 0)
            return;

        // 7- 3 = 4
        var d = nums.Length - k;

        var head = nums[..d];
        var tail = nums[d..];

        var i = 0;

        foreach (var t in tail)
        {
            nums[i] = t;
            i++;
        }

        foreach (var h in head)
        {
            nums[i] = h;
            i++;
        }
    }
}
