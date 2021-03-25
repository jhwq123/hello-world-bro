using System;

namespace _6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("등수를 입력하세요.");
            int rank = int.Parse(Console.ReadLine());
            Console.WriteLine("점수를 입력하세요.");
            int score = int.Parse(Console.ReadLine());

            if (rank < 10 || score > 90)
            {
                Console.WriteLine("A입니다.");
            }
        }
    }
}

// 10등 미만 또는 90점 초과 시 "A입니다." 출력 프로그램을 논리연산 이용하여 수정하시오.