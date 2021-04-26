using System;

namespace BuyAndSellGold2
{
    class Program
    {
        public static void Main(string[] args)
        {
            // gold prices on consecutive days
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            Console.Write(MaxProfit(prices));
        }

        public static int MaxProfit(int[] prices)
        {
            int n = prices.Length;
            int cost = 0;
            int maxProfit = 0;

            if (n == 0)
            {
                return 0;
            }

            // store the first element of array in a variable
            int minPprice = prices[0];

            for (int i = 0; i < n; i++)
            {
                // now compare first element with all the element of array and find the Minimum element
                minPprice = Math.Min(minPprice, prices[i]);

                // since minPrice is smallest element of the array so subtract with every element of the array and return the maxProfit
                cost = prices[i] - minPprice;

                maxProfit = Math.Max(maxProfit, cost);
            }
            return maxProfit;
        }
    }
}