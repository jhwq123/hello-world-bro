using System;

namespace _4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 2;
            number = number * 3;
            number = number - 4;
            number = number % 2;

            Console.WriteLine(number);

        }
    }
}

// 중단점, 자동 창, 로컬 창, 조사식 창 이용, 해당 코드 변수 number의 값 변화 추적, 총 4번 변함
// 9번째줄 직전 -> 0
// 9번째줄 직후 -> 2
// 10번째줄 직후 -> 6
// 11번째줄 직후 -> 2
// 12번째줄 직후 -> 0