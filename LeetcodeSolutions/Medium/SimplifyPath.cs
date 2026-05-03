namespace LeetcodeSolutions.Medium;

public class SimplifyPath
{
    [Fact]
    public void Test1()
    {
    }

    public string SimplifyPathSol(string path)
    {
        var st = new Stack<string>();

        foreach (var s in path.Split('/'))
        {
            if (s == string.Empty)
                continue;
            if (s == ".")
                continue;
            if (s == "..")
            {
                st.TryPop(out var _);
                continue;
            }

            st.Push(s);
        }

        var result = new string[st.Count];

        for (int i = result.Length - 1; i >= 0; i--)
        {
            result[i] = st.Pop();
        }

        return $"/{string.Join('/', result)}";
    }
}
