namespace LeetCodeTests.Medium;

public class DailyTemperatures
{
    [Fact]
    public void Test1()
    {
        int[] temperatures = [73, 74, 75, 71, 69, 72, 76, 73];

        var result = DailyTemperaturesStack(temperatures);

        Assert.Equal([1, 1, 4, 2, 1, 1, 0, 0], result);
    }

    public int[] DailyTemperaturesStack(int[] temperatures)
    {
        var result = new int[temperatures.Length];
        var s = new Stack<int>();

        for(var i = 0; i < temperatures.Length; i++)
        {
            while(s.Count > 0 && temperatures[i] > temperatures[s.Peek()])
            {
                var prev = s.Pop();

                result[prev] = i - prev;
            }
                
            s.Push(i);
        }
        
        return result;
    }
}
