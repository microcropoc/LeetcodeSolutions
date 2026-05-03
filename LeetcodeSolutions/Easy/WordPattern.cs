namespace LeetCodeTests.Easy;

public class WordPattern
{
    [Fact]
    public void Test1()
    {
    }

    public bool WordPatternSol(string pattern, string s)
    {
        var words = s.Split(' ');

        if (words.Length != pattern.Length)
            return false;

        var wordToChar = new Dictionary<string, char>();
        var charToWord = new Dictionary<char, string>();

        for (int i = 0; i < pattern.Length; i++)
        {
            var c = pattern[i];
            var word = words[i];

            if (charToWord.ContainsKey(c))
            {
                if (charToWord[c] != word)
                    return false;
            }
            else
            {
                charToWord[c] = word;
            }

            if (wordToChar.ContainsKey(word))
            {
                if (wordToChar[word] != c)
                    return false;
            }
            else
            {
                wordToChar[word] = c;
            }
        }

        return true;
    }
}
