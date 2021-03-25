using System;

namespace _10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int PassNumber = random.Next(1, 101);
            int GuessNumber = 0;
            int chance = 1 + 1000;
            bool Pass = false;

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("연산중..... 수비수가 숫자를 골랐습니다.");
            Console.WriteLine("숫자는 1 ~ 100 사이의 숫자입니다.");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();

            for (int i = 1; i < chance; i++)
            {
                Console.WriteLine();
                Console.Write("숫자를 맞추십시오. 시도횟수가 ");
                Console.Write(chance-i);
                Console.WriteLine("회 남았습니다.");

                Console.Write("그 숫자는: ");
                GuessNumber = int.Parse(Console.ReadLine());

                if (GuessNumber > PassNumber)
                {
                    Console.WriteLine("더 작은 숫자입니다.");
                }

                else if (GuessNumber < PassNumber)
                {
                    Console.WriteLine("더 큰 숫자입니다.");
                }

                else if (GuessNumber == PassNumber)
                {
                    Console.WriteLine("정답입니다.");
                    Pass = true;
                    break;
                }

                else
                {
                    Console.WriteLine("올바른 형태를 입력해야 합니다.");
                }


            }

            if (Pass == false)
            {
                Console.WriteLine();
                Console.WriteLine("당신은 기회를 모두 소진하였습니다.");
                Console.WriteLine("처음부터 다시 시도하십시오.");
            }


        }
    }
}

// 숫자 맞추기 게임 만들기.
// 1. 수비수가 1이상 100이하 숫자 무작위로 고름.
// 2. 공격수가 숫자를 입력함.
// 3. 만약 입력숫자 수비수가 고른 숫자보다 크면 "더 작은 숫자입니다."를 출력함.
// 4. 만약 입력숫자 수비수가 고른 숫자보다 작으면 "더 큰 숫자입니다."를 출력함.
// 5. 만약 입력수자 수비수가 고른 숫자와 같으면 "정답입니다."를 출력, 프로그램 종료.
// 맞출 때까지 2~5를 반복. -> 걍 숫자 1000회 시도하는걸로 바꿈,
//                            아무리 바보라도 그안에는 끝날듯 (맞출때까지 반복된다는거지)