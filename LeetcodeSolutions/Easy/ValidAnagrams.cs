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


    //O(n) space O(n)
    public bool ValidAnagramsSort(string s, string t)
    {
        if(s.Length != t.Length) 
            return false;

        return new string(s.OrderBy(i => i).ToArray()) == new string(t.OrderBy(i => i).ToArray());
    }

    //O(n) space O(n)
    public bool ValidAnagramsHash(string s, string t)
    {
        if (s.Length != t.Length) return false;

        Dictionary<char, int> dict = new Dictionary<char, int>();

        // Подсчитываем символы из первой строки
        foreach (char c in s)
        {
            if (dict.ContainsKey(c))
                dict[c]++;
            else
                dict[c] = 1;
        }

        // Вычитаем символы из второй строки
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
}
