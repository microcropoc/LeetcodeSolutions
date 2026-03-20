namespace LeetCodeTests.Medium;

public class TopKFrequent
{
    [Fact]
    public void Test1()
    {
        var result = TopKFrequentPQ([1, 1, 1, 2, 2, 3], 2);

        Assert.Equal([1, 2], result);
    }

    public int[] TopKFrequentPQ(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>();

        foreach (int i in nums)
        {
            if(dict.ContainsKey(i))
                dict[i]++;
            else 
                dict[i] = 1;
        }

        var pq = new PriorityQueue<int, int>();

        foreach (var kv in dict)
        {
            pq.Enqueue(kv.Key, kv.Value);

            if(pq.Count > k)
                pq.Dequeue();
        }

        var result = new int[k];

        for(int i = k - 1; i >= 0; i--)
        {
            result[i] = pq.Dequeue();
        }

        return result;
    }
}
