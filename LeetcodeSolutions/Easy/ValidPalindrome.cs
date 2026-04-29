namespace LeetCodeTests.Easy;

public class ValidPalindrome
{
    [Fact]
    public void Test1()
    {
        var s = "A man, a plan, a canal: Panama";

        Assert.Equal(true, IsPalindrome(s));


        var s2 = "race a car";

        Assert.Equal(false, IsPalindrome(s2));

        var s3 = "0P";

        Assert.Equal(false, IsPalindrome(s3));
    }

    //O(n) space O(n)
    public bool IsPalindromeLowQuality(string s)
    {
        var s1 = s.Where(char.IsLetterOrDigit).Select(char.ToLower);

        return s1.SequenceEqual(s1.Where(char.IsLetterOrDigit).Reverse());
    }

    //O(n) space O(1)
    public bool IsPalindrome(string s)
    {
        var left = 0;
        var right = s.Length - 1;

        while (left < right)
        {
            if (!char.IsLetterOrDigit(s[left]))
            {
                left++;
                continue;
            }

            if (!char.IsLetterOrDigit(s[right]))
            {
                right--;
                continue;
            }

            if (char.ToLower(s[left]) != char.ToLower(s[right]))
                return false;

            left++;
            right--;
        }

        return true;
    }
}
