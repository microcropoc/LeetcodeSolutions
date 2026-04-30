namespace LeetCodeTests.Medium;

public class GroupAnagrams
{
    [Fact]
    public void Test1()
    {
        var strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
        List<List<string>> r = [["bat"], ["nat", "tan"], ["ate", "eat", "tea"]];

        var result = GroupAnagramsMas(strs);

        Assert.Equal(r, result);
    }


    //O(n × L) O(n × L)
    public IList<IList<string>> GroupAnagramsMas(string[] strs)
    {
        var result = new Dictionary<string, IList<string>>();

        foreach (var str in strs)
        {
            var cs = new int[26];

            foreach (var c in str)
            {
                cs[c - 'a']++;
            }

            var key = string.Join(',', cs);

            if (result.ContainsKey(key))
            {
                result[key].Add(str);
            }
            else
            {
                result[key] = new List<string>() { str };
            }
        }

        return result.Values.ToList();
    }
}
