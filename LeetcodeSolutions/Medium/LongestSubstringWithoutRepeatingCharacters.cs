namespace LeetCodeTests.Medium;

public class LongestSubstringWithoutRepeatingCharacters
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(3, LengthOfLongestSubstring("pwwkew"));
    }
    public int LengthOfLongestSubstring(string s)
    {
        var hash = new HashSet<char>();
        var maxLenght = 0;
        var left = 0;

        for (int i = 0; i < s.Length; i++)
        {
            while (hash.Contains(s[i]))
            {
                hash.Remove(s[left]);
                left++;
            }

            hash.Add(s[i]);

            maxLenght = Math.Max(maxLenght, i - left + 1);
        }

        return maxLenght;
    }
}
