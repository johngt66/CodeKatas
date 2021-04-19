using System;
using System.Collections.Generic;
using System.Linq;

namespace JT.CodeKataClasses
{
    public class MarketQueue
    {
        public static long QueueTime(int[] customers, int n)
        {
            if (customers.Length == 0)
                return 0;                   // zero wait if no customers
            if (customers.Length <= n)
                return customers.Max();     // max customer if more tills than customers

            List<int> tills = new List<int>(customers.Take(n));  // seed the tills
            List<int> q = new List<int>(customers.Skip(n));      // queue of remaining customers

            foreach (int customer in q)
            {
                int nextTill = tills.IndexOf(tills.Min());
                tills[nextTill] += customer;                    // add the next customer to the shortest till
            }
            return tills.Max();             // return the till that took the longest to clear
        }
    }
}