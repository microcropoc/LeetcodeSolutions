namespace LeetCodeTests.Easy;

public class RansomNote
{
    [Fact]
    public void Test1()
    {
        Assert.True(CanConstruct("aa", "aab"));
    }

    public bool CanConstruct(string ransomNote, string magazine)
    {
        var lit = new int[26];

        foreach (var item in magazine)
        {
            lit[item - 'a']++;
        }

        foreach(var item in ransomNote)
        {
            lit[item - 'a']--;

            if(lit[item - 'a'] < 0)
                return false;
        }

        return true;
    }
}
