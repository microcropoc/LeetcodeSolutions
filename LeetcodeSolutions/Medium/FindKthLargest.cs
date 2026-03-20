namespace LeetCodeTests.Medium;

public class FindKthLargest
{
    [Fact]
    public void Test1()
    {
        var result = FindKthLargestPQ([3, 2, 3, 1, 2, 4, 5, 5, 6], 4);

        Assert.Equal(4, result);
    }

    public int FindKthLargestSimple(int[] nums, int k)
    {
        Array.Sort(nums);

        return nums[nums.Length - k];
    }

    public int FindKthLargestPQ(int[] nums, int k)
    {
        var pq = new PriorityQueue<int, int>();

        foreach (var n in nums)
        {
            pq.Enqueue(n, n);

            if(pq.Count > k)
                pq.Dequeue();
        }

        return pq.Dequeue();
    }
}
