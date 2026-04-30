namespace LeetCodeTests.Medium;

public class FruitIntoBaskets
{
    [Fact]
    public void Test1()
    {
        var result = TotalFruit([0, 1, 2, 2]);

        Assert.Equal(3, result);
    }

    //O(n) O(1)
    public int TotalFruit(int[] fruits)
    {
        var left = 0;
        var max = 0;
        var dict = new Dictionary<int, int>();

        for (var right = 0; right < fruits.Length; right++)
        {
            if (dict.ContainsKey(fruits[right]))
                dict[fruits[right]]++;
            else
                dict[fruits[right]] = 1;

            while (dict.Count > 2)
            {
                dict[fruits[left]]--;
                if (dict[fruits[left]] == 0)
                    dict.Remove(fruits[left]);

                left++;
            }

            max = Math.Max(max, right - left + 1);
        }

        return max;
    }

}
