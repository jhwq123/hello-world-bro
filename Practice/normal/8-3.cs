using System;

namespace _8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("몇 명의 친구들에게 사과를 나눠줄까요?");
            int friendCount = int.Parse(Console.ReadLine());

            int[] appleNumbers = new int[friendCount];
            int index = 0;
            int total = 0;

            while (index < friendCount)
            {
                Console.Write(index);
                Console.WriteLine("번째 친구가 가져갈 사과는 몇 개인가요?");
                appleNumbers[index] = int.Parse(Console.ReadLine());
                total = total + appleNumbers[index];
                index++;
            }

            Console.Write("친구들에게 ");
            Console.Write(total);
            Console.WriteLine("개의 사과를 나눠줬습니다.");

        }
    }
}

// 해당 코드의 버그를 찾아서 전부 수정하시오.
// 1. total이 무슨 자료형인지 선언되어있지 않다.
// 2. while문 안에 index값이 상승해야한다.
// 3. 그리고 index가 1부터 선언되있는데, 이럴거면 1개가 누락되니까, 0부터 시작해야됨