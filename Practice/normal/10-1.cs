using System;

namespace _10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int number1 = random.Next(3, 10); // 3 ~ 9 까지의 정수

            int number2 = random.Next(-2, 4); // -2 ~ 3 까지의 정수

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("random.Next(3, 10)을 하면 뭐가 나올까");

            for (int i = 0; i < 10; i++)
            {
                Console.Write(random.Next(3, 10) + " ");

            }
            Console.WriteLine();

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("random.Next(-2, 4)을 하면 뭐가 나올까");

            for (int i = 0; i < 10; i++)
            {
                Console.Write(random.Next(-2, 4) + " ");

            }

        }
    }
}

// 다음 랜덤에서 나올수 있는 숫자 전부 확인하기