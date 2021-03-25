using System;

namespace _5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 변수1
            Console.WriteLine("첫번째 숫자를 입력하시오.");
            string userInput1 = Console.ReadLine();
            double number1 = double.Parse(userInput1);
            
            // 변수2
            Console.WriteLine("두번째 숫자를 입력하시오.");
            string userInput2 = Console.ReadLine();
            double number2 = double.Parse(userInput2);

            // 더하기
            Console.Write(number1);
            Console.Write(" + ");
            Console.Write(number2);
            Console.Write(" = ");
            Console.WriteLine(number1 + number2);

            // 빼기
            Console.Write(number1);
            Console.Write(" - ");
            Console.Write(number2);
            Console.Write(" = ");
            Console.WriteLine(number1 - number2);

            // 곱하기
            Console.Write(number1);
            Console.Write(" * ");
            Console.Write(number2);
            Console.Write(" = ");
            Console.WriteLine(number1 * number2);

            // 나누기
            Console.Write(number1);
            Console.Write(" / ");
            Console.Write(number2);
            Console.Write(" = ");
            Console.WriteLine(number1 / number2);

        }
    }
}

// 문자열 userInput1, userInput2 입력받아
// 실수 number1, number2 변환하여
// 사칙연산(+, -, *, /)의 결과
// 화면 출력 프로그램 작성