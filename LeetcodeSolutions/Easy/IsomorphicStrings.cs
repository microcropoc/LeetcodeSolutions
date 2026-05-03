namespace LeetCodeTests.Easy;

public class IsomorphicStrings
{
    [Fact]
    public void Test1()
    {
    }

    //O(n) O(n)
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        var ds = new Dictionary<char, char>();
        var dt = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++)
        {
            var cs = s[i];
            var ct = t[i];

            if (ds.ContainsKey(cs))
            {
                if (ds[cs] != ct)
                    return false;
            }
            else
            {
                ds[cs] = ct;
            }

            if (dt.ContainsKey(ct))
            {
                if (dt[ct] != cs)
                    return false;
            }
            else
            {
                dt[ct] = cs;
            }
        }

        return true;
    }
}
