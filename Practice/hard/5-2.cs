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

// 해당 내용에서 나누기 분모 0되는 값 넣으면?
// 실수 / 실수 이기때문에, 결과값도 실수로 소숫점으로 나올 것.