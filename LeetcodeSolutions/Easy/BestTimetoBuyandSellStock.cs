namespace LeetCodeTests.Easy;

public class BestTimetoBuyandSellStock
{
    [Fact]
    public void Test1()
    {
        //Arrange

        int[] data = [7, 1, 5, 3, 6, 4];

        //Act

        var result = MaxProfit(data);

        //Assert

        Assert.Equal(5, result);
    }

    //O(N) space O(1)
    public int MaxProfit(int[] prices)
    {
        int minPrice = int.MaxValue;
        int maxProfit = 0;

        foreach (var p in prices)
        {
            if (minPrice > p)
            {
                minPrice = p;
            }
            else if (p - minPrice > maxProfit)
            {
                maxProfit = p - minPrice;
            }
        }

        return maxProfit;
    }

    //O(N) space O(1)
    public int MaxProfit1(int[] prices)
    {
        int minPrice = prices[0];
        int maxProfit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if (minPrice > prices[i])
            {
                minPrice = prices[i];
            }
            else if (prices[i] - minPrice > maxProfit)
            {
                maxProfit = prices[i] - minPrice;
            }
        }

        return maxProfit;
    }

    //O(N) space O(1)
    public int MaxProfit2(int[] prices)
    {
        int minPrice = int.MaxValue;
        int maxProfit = 0;

        foreach (int price in prices)
        {
            minPrice = Math.Min(minPrice, price);
            maxProfit = Math.Max(maxProfit, price - minPrice);
        }

        return maxProfit;
    }

    //O(N^2) space O(1)
    public int MaxProfitLQ(int[] prices)
    {
        int maxProfit = 0;

        for (int i = 0; i < prices.Length; i++)
        for (int j = i + 1; j < prices.Length; j++)
        {
            int p = prices[j] - prices[i];
            maxProfit = Math.Max(maxProfit, p);
        }

        return maxProfit;
    }
}
