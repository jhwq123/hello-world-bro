using System;

namespace _6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("3 <= 5 는 ");
            Console.WriteLine(3 <= 5);              // 1

            Console.Write("!(5 == 5) 는 ");
            Console.WriteLine(!(5 == 5));           // 0

            Console.Write("!(3 < 2) 는 ");
            Console.WriteLine(!(3 < 2));            // 1

            Console.Write("1 > 0 은 ");
            Console.WriteLine(1 > 0);               // 1

        }
    }
}

// 다음 조건식의 참 거짓?
//
// 1. 3 <= 5
// 2. !(5 == 5)
// 3. !(3 < 2)
// 4. 1 > 0