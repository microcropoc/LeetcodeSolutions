namespace LeetcodeSolutions.Medium;

public class Subsets
{
    [Fact]
    public void Test1()
    {
    }

    //O(n × 2^n) O(1)
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

    //O(n × 2^n) O(n)
    public IList<IList<int>> SubsetsBT(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();

        void BT(int[] nums, int start, List<int> current, IList<IList<int>> result)
        {
            result.Add(current.ToList());

            for (int i = start; i < nums.Length; i++)
            {
                current.Add(nums[i]);
                BT(nums, i + 1, current, result);
                current.RemoveAt(current.Count - 1);
            }
        }

        BT(nums, 0, [], result);

        return result;
    }
}
