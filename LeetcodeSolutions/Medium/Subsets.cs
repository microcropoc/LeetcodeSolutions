namespace LeetcodeSolutions.Medium;

public class Subsets
{
    [Fact]
    public void Test1()
    {
    }

    //O(n × 2ⁿ)	O(1)
    public IList<IList<int>> SubsetsIter(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();

        result.Add([]);

        foreach (var n in nums)
        {
            var c = result.Count;
            for (int i = 0; i < c; i++)
            {
                var ns = new List<int>(result[i]);
                ns.Add(n);
                result.Add(ns);
            }
        }

        return result;
    }
}
