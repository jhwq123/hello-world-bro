using System;


namespace _4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 20;
            int number2 = 5;
            int number3 = 3;
            int number4 = 13;
            int number5;

            number1 = number1 + number2; // n1 = 20 + 5 = 25
            number2 = number3 + number4; // n2 = 3 + 13 = 16
            number4 = number1 - number4; // n4 = 25 - 13 = 12
            number3 = number2 / number4; // n3 = 16 / 12 = 1
            number5 = number2 % number4; // n5 = 16 % 12 = 4

            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            Console.WriteLine(number4);
            Console.WriteLine(number5);

        }
    }
}

// 다음 코드 결과 출력내용?
//
// 25
// 16
// 1
// 12
// 4