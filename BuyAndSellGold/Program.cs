using System;

namespace BuyAndSellGold
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] price = {7, 1, 5, 3, 10, 4 };
            int n = price.Length;
            int start = 0;
            int end = price.Length - 1;

            Console.Write(maxProfit(price, start, end));
        }
        static int maxProfit(int[] price, int start, int end)
        {
            int profit = 0;

            // The day at which the stock must be bought
            for (int i = start; i < end; i++)
            {
                // The day at which the stock must be sold
                for (int j = i + 1; j <= end; j++)
                {
                    // If byuing the stock at ith day and selling it at jth day is profitable
                    if (price[j] > price[i])
                    {
                        // Update the current profit
                        int currentProfit = price[j] - price[i];

                        // Update the maximum profit so far
                        profit = Math.Max(profit, currentProfit);
                    }
                }
            }
            return profit;
        }
    }
}
