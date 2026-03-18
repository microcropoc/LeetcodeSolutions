namespace LeetCodeTests.Easy;

public class ClimbStairsTest
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(2, ClimbStairs(2));
        Assert.Equal(3, ClimbStairs(3));
    }


    public int ClimbStairs(int n)
    {
        if (n <= 2)
            return n;

        var prev1 = 1;
        var prev2 = 2;
        var curr = 0;

        for (var i = 2; i < n; i++)
        {
            curr = prev1 + prev2;
            prev1 = prev2;
            prev2 = curr;
        }

        return curr;
    }
}
