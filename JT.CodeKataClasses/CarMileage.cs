using System;
using System.Linq;
using System.Collections.Generic;

namespace JT.CodeKataClasses
{
    public class CarMileage
    {
        public static int IsInteresting(int number, List<int> awesomePhrases)
        {
            if (number < 100 || number >= 1000000000 || awesomePhrases == null)
                return 0;

            List<Func<string, bool>> rules = new List<Func<string, bool>>
            {
                n => n.Trim('0').Length == 1,
                n => n.All(c => c == n[0]),
                n => "1234567890".Contains(n),
                n => "9876543210".Contains(n),
                n =>
            };

            foreach (var r in rules)
            {
                Console.WriteLine(r(number.ToString()));
            }
            return 0;
        }
    }
}