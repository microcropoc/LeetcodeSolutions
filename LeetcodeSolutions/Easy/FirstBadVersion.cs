namespace LeetCodeTests.Easy;

public class FirstBadVersionTest
{
    int badVersion;
    int calls;

    [Fact]
    public void Test1()
    {
        badVersion = 4;
        calls = 0;

        Assert.Equal(4, FirstBadVersion(5));
        Assert.Equal(3, calls);
    }

    public int FirstBadVersion(int n)
    {
        var left = 1;
        var right = n;

        while (left <= right)
        {
            var pos = left + (right - left) / 2;

            if (IsBadVersion(pos))
            {
                if(pos == 1 || !IsBadVersion(pos - 1))
                    return pos;

                right = pos - 1;
            }
            else
            {
                left = pos + 1;
            }
        }

        return -1;
    }

    bool IsBadVersion(int version)
    {
        calls++;
        return version >= badVersion;
    }
}
