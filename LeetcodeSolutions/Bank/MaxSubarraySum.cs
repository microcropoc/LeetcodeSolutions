namespace LeetCodeTests.Bank;

public class MaxSubarraySum
{
    [Fact]
    public void Test1()
    {
        //Arrange

        int[] data = [1, 2, 3, 4, 10, 10, 4, 10, 5, 5, 5];

        //Act

        var result = MaxSubarraySum1(data);

        //Assert

        Assert.Equal(38, result);
    }

    public int MaxSubarraySum1(int[] mas)
    {
        if (mas.Length <= 2)
            return mas.Sum();

        var left = 0;
        var sum = 0;
        var maxSum = 0;
        var dict = new Dictionary<int, int>();

        for (int right = 0; right < mas.Length; right++) {

            if(dict.ContainsKey(mas[right]))
                dict[mas[right]]++;
            else
                dict[mas[right]] = 1;

            sum += mas[right];

            while (dict.Count > 2)
            {
                dict[mas[left]]--;

                if (dict[mas[left]] == 0)
                    dict.Remove(mas[left]);

                sum -= mas[left];
                left++;
            }

            maxSum = Math.Max(maxSum, sum);
        }

        return maxSum;
    }
}
