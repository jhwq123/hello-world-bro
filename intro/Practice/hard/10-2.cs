using System;

namespace _10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] Positions = { "0", "가위", "바위", "보" };
            int PassNumber = 0;
            int GuessNumber = 0;
            int chance = 6;
            int same_count = 0;

            Console.WriteLine("--------------------------------");
            Console.WriteLine("사기치는 가위바위보 게임");
            Console.WriteLine("--------------------------------");

            for (int i = 0; i < chance; i++)
            {
                Console.WriteLine();
                Console.WriteLine("연산중.............");
                PassNumber = random.Next(1, 4);
                Console.WriteLine("상대방이 무엇을 낼지 정했습니다.");
                Console.WriteLine();

                Console.WriteLine("< 1. 가위 / 2. 바위 / 3. 보 >");
                Console.WriteLine("무엇을 낼지 결정하시오. : ");
                GuessNumber = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("결과 : 상대가 낸 것[");
                Console.Write(Positions[PassNumber]);
                Console.Write("] / 내가 낸 것[");
                Console.Write(Positions[GuessNumber]);
                Console.WriteLine("]");

                if (GuessNumber == 1) // 가위
                {
                    if (PassNumber == 1) // 가위
                    {
                        Console.WriteLine("비겼습니다.");
                        Console.WriteLine();
                    }

                    else if (PassNumber == 2) // 바위
                    {
                        Console.WriteLine("졌습니다.");
                        Console.WriteLine();
                        break;
                    }

                    else if (PassNumber == 3) // 보
                    {
                        Console.WriteLine("이겼습니다.");
                        Console.WriteLine();
                        break;
                    }

                }

                if (GuessNumber == 2) // 바위
                {
                    if (PassNumber == 1) // 가위
                    {
                        Console.WriteLine("이겼습니다.");
                        Console.WriteLine();
                        break;
                    }

                    else if (PassNumber == 2) // 바위
                    {
                        Console.WriteLine("비겼습니다.");
                        Console.WriteLine();
                    }

                    else if (PassNumber == 3) // 보
                    {
                        Console.WriteLine("졌습니다.");
                        Console.WriteLine();
                        break;
                    }

                }

                if (GuessNumber == 3) // 보
                {
                    if (PassNumber == 1) // 가위
                    {
                        Console.WriteLine("졌습니다.");
                        Console.WriteLine();
                        break;
                    }

                    else if (PassNumber == 2) // 바위
                    {
                        Console.WriteLine("이겼습니다.");
                        Console.WriteLine();
                        break;
                    }

                    else if (PassNumber == 3) // 보
                    {
                        Console.WriteLine("비겼습니다.");
                        Console.WriteLine();
                    }

                }

                same_count++;
            }

            if (same_count == 6)
            {
                Console.WriteLine("결판이 나지 않습니다.");
            }

        }
    }
}

// 가위바위보 게임 만들기, 규칙은 다음과 같음
//
// 1. 1은 가위, 2는 바위, 3은 보 입니다.
// 2. 프로그램에서 1 이상 3 이하인 숫자를 무작위로 고름
// 3. 사용자가 1, 2, 3중에 하나 숫자를 고른다.
// 4. 사용자가 졌으면 "졌습니다."를 출력한다.
// 5. 사용자가 이기면 "이겼습니다."를 출력한다.
// 6. 비겼다면 "비겼습니다."를 출력한다.
// 7. 비기면, 2~6을 반복한다.