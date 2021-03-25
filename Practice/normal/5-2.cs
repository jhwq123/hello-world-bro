using System;

namespace _5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("첫 번째 숫자를 입력하세요.");
            string userInput1 = Console.ReadLine();
            Console.WriteLine("두 번째 숫자를 입력하세요.");
            string userInput2 = Console.ReadLine();
            int number1 = int.Parse(userInput1);
            int number2 = int.Parse(userInput2);

            Console.WriteLine(number1 - number2);

        }
    }
}

// 버그 찾아 고치기
//
// 14번째줄, 문자열을 정수형태로 변환해야 읽어짐