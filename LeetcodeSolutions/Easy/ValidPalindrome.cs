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

    public bool IsPalindrome(string s)
    {
        if (s.Length == 1)
            return true;

        var left = 0;
        var right = s.Length - 1;

        while (left < right)
        {
            if (!char.IsLetter(s[left]) && !char.IsDigit(s[left]))
            {
                left++;
                continue;
            }

            if (!char.IsLetter(s[right]) && !char.IsDigit(s[right]))
            {
                right--;
                continue;
            }

            if(char.ToLower(s[left]) != char.ToLower(s[right]))
                return false;

            left++;
            right--;
        }

        return true;
    }
}
