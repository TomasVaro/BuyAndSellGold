// C# program to find best buying and selling days
using System;
using System.Collections.Generic;

// Solution structure
//class Interval
//{
//    public int buy, sell;
//}

public class StockBuySell
{
    public static void Main(String[] args)
    {
        StockBuySell stock = new StockBuySell();

        // stock prices on consecutive days
        int[] price = { 7, 1, 5, 3, 6, 4 };
        int n = price.Length;

        stock.stockBuySell(price, n);
    }
    // This function finds the buy sell schedule for maximum profit
    void stockBuySell(int[] price, int n)
    {
        int count = 0;
        int buy = 0;
        int sell = 0;

        // solution array
        //List<Interval> sol = new List<Interval>();

        // Traverse through given price array
        int i = 0;
        while (i < n - 1)
        {
            // Find Local Minima. Note that the limit is (n-2) as we are comparing present element to the next element.
            while ((i < n - 1) && (price[i + 1] <= price[i]))
                i++;

            // If we reached the end, break as no further solution possible
            if (i == n - 1)
                break;

            //Interval e = new Interval();
            // Store the index of minima
            buy = i;
            i++;

            // Find Local Maxima. Note that the limit is (n-1) as we are comparing to previous element
            while ((i < n) && (price[i] >= price[i - 1]))
                i++;

            // Store the index of maxima
            sell = i - 1;
            //sol.Add(e);

            // Increment number of buy/sell
            count++;
        }

        // print solution
        if (count == 0)
            Console.WriteLine("There is no day when buying the stock will make profit");
        else
            
            Console.WriteLine("Buy on day: " + buy + "     " + "Sell on day : " + sell);
        return;
    }
}