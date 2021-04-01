using System;
using System.Collections.Generic;

namespace JT.CodeKataClasses
{
    public class TheElder
    {
        public static List<List<int>> BuildMagicRectangle(int r, int c)
        {
            List<List<int>> A = new List<List<int>>();
            var w = r.ToString().Length + 1;

            for (var y = 0; y < r; y++)
            {
                A.Add(new List<int>());
                for (var x = 0; x < c; x++)
                {
                    A[y].Add(x ^ y);
                    Console.Write($"{A[y][x],4}");
                }
                Console.WriteLine();
            }
            return A;
        }
    }
}