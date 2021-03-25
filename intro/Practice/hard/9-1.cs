using System;

namespace _9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] passcodeNumbers = { 6, 2, 1, 9, 4, 7 };
            int passcodeLength = 6;
            int[] userInput = new int[6];

            for (int chance = 1; chance < 6; chance++)
            {
                for (int passcodeIndex = 0; passcodeIndex < passcodeLength; passcodeIndex++)
                {
                    Console.Write(passcodeIndex);
                    Console.WriteLine("번째 숫자를 넣어주세요.");
                    userInput[passcodeIndex] = int.Parse(Console.ReadLine());

                }

                bool isPasswordCorrect = true;

                for (int passcodeIndex = 0; passcodeIndex < passcodeLength; passcodeIndex++)
                {
                    if (userInput[passcodeIndex] != passcodeNumbers[passcodeIndex])
                    {
                        isPasswordCorrect = false;
                        Console.WriteLine("비밀번호가 틀렸습니다.");
                        break;

                    }

                }

                if (isPasswordCorrect)
                {
                    Console.WriteLine("문이 열렸습니다.");
                    break;

                }

                Console.Write("남은 시도가 ");
                Console.Write(5 - chance);
                Console.WriteLine("회 남았습니다.");

            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("모든 기회가 소진되었습니다.");
            Console.WriteLine("해당 좌물쇠는 영영 닫히게 되었습니다.");
            Console.WriteLine("가까운 서비스센터에 방문하여 지원을 받기 바랍니다.");

        }
    }
}

// 해당코드
// 비밀번호 다섯 번만 입력할 수 있도록 바꾸시오.
// while문 대신 for문으로 바꿔 쓰시오.