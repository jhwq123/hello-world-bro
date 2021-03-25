using System;

namespace _5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 시작
            Console.WriteLine("주머니에는 동전이 10개 들어 있습니다.");
            
            // 개수 정의
            Console.WriteLine("어머니는 몇 개의 동전을 주머니에 넣었나요?");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("아람이는 몇 개의 동전을 꺼냈나요?");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("우람이는 몇 개의 동전을 꺼냈나요?");
            int number3 = int.Parse(Console.ReadLine());

            // 해석
            int Total = 10 + number1 - number2 - number3;
            Console.WriteLine("주머니에 남아 있는 동전의 개수는 " + Total + "개입니다.");

        }
    }
}

// 아람이 우람이 동전문제 결과 화면
//
// 주머니에는 동전이 10개 들어 있습니다.
// 어머니는 몇 개의 동전을 주머니에 넣었나요?
// a
// 아람이는 몇 개의 동전을 꺼냈나요?
// b
// 우람이는 몇 개의 동전을 꺼냈나요?
// c
// 주머니에 남아 있는 동전의 개수는 N개입니다.