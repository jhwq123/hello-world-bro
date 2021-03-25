using System;

namespace _6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력해보세요 : ");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput > 20 && (userInput % 3 == 0))
            {
                Console.WriteLine("해당 숫자는 20보다 큰 3의 배수입니다.");
            }

            else
            {
                Console.WriteLine("해당 숫자는 그냥 숫자입니다.");
            }

        }
    }
}

// 정수형 변수 userInput에 사용자 입력받아
// userInput이 20보다 크고 3의 배수이면
// "20보다 큰 3의 배수입니다." 출력하는 프로그램 작성.