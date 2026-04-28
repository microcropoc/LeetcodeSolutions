namespace LeetCodeTests.Bank;

public class BrockenKeyboard
{
    [Fact]
    public void Test1()
    {
        //Arrange

        var data = "abcd";

        //Act

        var result = UnEscape("abcd");

        //Assert

        Assert.Equal("cd", new string(result.ToArray()));
    }

    public IEnumerable<char> UnEscape(string a)
    {
        var upper = new Stack<(int, char)>();
        var lower = new Stack<(int, char)>();

        for (int i = 0; i < a.Length; i++) 
        {
            if (a[i] == 'B')
                upper.TryPop(out var _);
            else if (a[i] == 'b')
                lower.TryPop(out var _);
            else if (char.IsUpper(a[i]))
                upper.Push((i, a[i]));
            else if (char.IsLower(a[i]))
                lower.Push((i, a[i]));
        }

        var result = new Stack<char>();

        while (upper.Any() || lower.Any())
        {
            if (!upper.Any())
            {
                result.Push(lower.Pop().Item2);
                continue;
            }

            if (!lower.Any())
            {
                result.Push(upper.Pop().Item2);
                continue;
            }

            var c1 = upper.Peek().Item1;
            var c2 = lower.Peek().Item1;

            if (c1 > c2)
            {
                result.Push(lower.Pop().Item2);
            }
            else
            {
                result.Push(upper.Pop().Item2);
            }
        }

        return result.ToArray();
    }
}
