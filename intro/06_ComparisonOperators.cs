﻿using System;

namespace ComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("10 > 10 은 ");
            Console.WriteLine(10 > 10);     // 0

            Console.Write("10 >= 10 은 ");
            Console.WriteLine(10 >= 10);    // 1

            Console.Write("5 < 10 은 ");
            Console.WriteLine(5 < 10);      // 1

            Console.Write("5 <= 10 은 ");
            Console.WriteLine(5 <= 10);     // 1

            Console.Write("5 == 4 은 ");
            Console.WriteLine(5 == 4);      // 0

            Console.Write("5 != 4 은 ");
            Console.WriteLine(5 != 4);      // 1

        }
    }
}