using System;

namespace BuySellGold4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] price = { 15, 12, 10, 9, 6, 4, 2};
            int end = price.Length - 1;
            int buyDay = 0;
            int sellDay = 0;
            int maxProfit = 0;

            for (int i = 0; i < end; i++)
            {
                // The day at which the gold must be sold
                for (int j = i + 1; j <= end; j++)
                {
                    // If byuing the gold at i'th day and selling it at j'th day is profitable
                    if (price[j] > price[i])
                    {
                        // Update the current buy and sell day
                        int currentProfit = price[j] - price[i];
                        if(currentProfit > maxProfit)
                        {
                            maxProfit = currentProfit;
                            buyDay = i;
                            sellDay = j;
                        }
                    }
                }
            }
            Console.WriteLine("Buy on day: " + buyDay + "     " + "Sell on day: " + sellDay + "      " + "Total gain " + maxProfit);

            // If no profit then count min loss
            if (buyDay == 0 && sellDay == 0)
            {
                Console.Clear();
                int minLoss = price[0] - price[1];
                buyDay = 0;
                sellDay = 1;
                for (int i = 1; i < end; i++)
                {
                    // Update the current buy and sell date
                    int currentLoss = price[i] - price[i + 1];
                    if(currentLoss < minLoss)
                    {
                        minLoss = currentLoss;
                        buyDay = i;
                        sellDay = i + 1;
                    }
                }
                Console.WriteLine("Buy on day: " + buyDay + "     " + "Sell on day: " + sellDay + "      " + "Minimum loss " + minLoss);
            }
        }
    }
}
