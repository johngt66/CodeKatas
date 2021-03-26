using System;
using System.Linq;
using System.Collections.Generic;

namespace JT.Console
{
    class Program
    {
        public static void Main(string[] args)
        {

            var cmds = args.Where(s=>s.)
            if(args.Contains())
        }
        public static void RunNextNumber(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine("Next number using same digits as:");

                foreach (var num in args)
                {
                    if (long.TryParse(num, out long n))
                    {
                        long nextNum = NextBiggerNumber(n);
                        Console.WriteLine($" {n:10} -> {nextNum:10}");
                    }
                    else
                        Console.WriteLine($"  Not a number: {num}");
                }
            }
            else
            {
                Console.WriteLine($"Enter numbers to test on command line separated by spaces.\n   $ ./{System.AppDomain.CurrentDomain.FriendlyName} 123 456 987");
            }
        }
    }
}
