using System;

namespace _10_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int randomNumber = random.Next(8, 51);

            Console.Write("고른 숫자: ");
            Console.WriteLine(randomNumber);

        }
    }
}

// 8이상 50미만 숫자 무작위로 골라 출력하는 코드 작성