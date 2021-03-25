using System;

namespace _4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int CoinCount = 10;
            CoinCount = CoinCount / 2;
            CoinCount = CoinCount + 1;
            CoinCount = CoinCount / 2;
            CoinCount = CoinCount - 2;

            Console.Write("주머니에는 동전이 ");
            Console.Write(CoinCount);
            Console.WriteLine("개 남았고");

            Console.Write("아람이는 동전을 ");
            Console.Write(10 - CoinCount);
            Console.WriteLine("개 가져갔다.");

        }
    }
}

// 아람이 동전 문제