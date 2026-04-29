namespace LeetCodeTests.Easy;

public class LongestCommonPrefix
{
    [Fact]
    public void Test1()
    {
        //Arrange

        string[] data = ["flower", "flow", "flight"];

        //Act

        var result = LongestCommonPrefixVer(data);

        //Assert

        Assert.Equal("fl", result);
    }

    //O(n × m) space O(1)
    public string LongestCommonPrefixVer(string[] strs)
    {
        for (int i = 0; i < strs[0].Length; i++)
        {
            var c = strs[0][i];
            for (int j = 1; j < strs.Length; j++)
            {
                if (i >= strs[j].Length || c != strs[j][i])
                {
                    return strs[0][..i];
                }

            }
        }

        return strs[0];
    }

    //O(n × m) space O(1)
    public string LongestCommonPrefixHor(string[] strs)
    {
        var s1 = strs[0];
        int pos = s1.Length - 1;

        for (int i = 1; i < strs.Length; i++)
        {
            pos = Math.Min(pos, strs[i].Length - 1);
            for (int j = 0; j <= pos; j++)
            {
                if (s1[j] != strs[i][j])
                {
                    pos = j - 1;
                    break;
                }

            }
        }

        var l = pos + 1;

        return s1[..l];
    }
}
