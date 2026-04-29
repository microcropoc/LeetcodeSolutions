namespace LeetCodeTests.Easy;

public class ValidAnagrams
{
    [Fact]
    public void Test1()
    {
        //Arrange

        var s = "anagram";
        var t = "nagaram";


        //Act

        var result = ValidAnagramsSort(s, t);

        //Assert

        Assert.Equal(true, result);
    }


    //O(n log n) space O(n)
    public bool ValidAnagramsSort(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        return string.Concat(s.Order()) == string.Concat(t.Order());
    }

    //O(n) space O(k)
    public bool ValidAnagramsHash(string s, string t)
    {
        if (s.Length != t.Length) return false;

        Dictionary<char, int> dict = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (dict.ContainsKey(c))
                dict[c]++;
            else
                dict[c] = 1;
        }

        foreach (char c in t)
        {
            if (!dict.ContainsKey(c))
                return false;

            dict[c]--;
            if (dict[c] == 0)
                dict.Remove(c);
        }

        return dict.Count == 0;
    }

    //O(n) space O(1)
    public bool ValidAnagramsArray(string s, string t)
    {
        if (s.Length != t.Length) return false;

        int[] count = new int[26];

        for (int i = 0; i < s.Length; i++)
        {
            count[s[i] - 'a']++;
            count[t[i] - 'a']--;
        }

        foreach (int val in count)
        {
            if (val != 0) return false;
        }

        return true;
    }

    //O(n) space O(1)
    public bool ValidAnagramsArray2(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        var m = new int[26];

        foreach (var i in s)
        {
            m[i - 'a']++;
        }

        foreach (var i in t)
        {
            m[i - 'a']--;

            if (m[i - 'a'] < 0)
                return false;
        }

        return true;
    }
}
