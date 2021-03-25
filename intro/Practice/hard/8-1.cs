using System;

namespace _8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] passcodeNumbers = { 6, 2, 1, 9, 4, 7 };
            int[] userInput = new int[6];
            int cnt = 0;

            while (userInput[0] != passcodeNumbers[0] || userInput[1] != passcodeNumbers[1] ||
                     userInput[2] != passcodeNumbers[2] || userInput[3] != passcodeNumbers[3] ||
                        userInput[4] != passcodeNumbers[4] || userInput[5] != passcodeNumbers[5])
            {
                while(cnt < 6)
                {
                    Console.Write(cnt+1);
                    Console.WriteLine("번째 숫자를 넣어주세요.");
                    userInput[cnt] = int.Parse(Console.ReadLine());
                    cnt++;
                }

                cnt = 0;

                if (userInput[0] == passcodeNumbers[0] && userInput[1] == passcodeNumbers[1] &&
                    userInput[2] == passcodeNumbers[2] && userInput[3] == passcodeNumbers[3] &&
                    userInput[4] == passcodeNumbers[4] && userInput[5] == passcodeNumbers[5])
                {
                    Console.WriteLine("문이 열렸습니다.");
                }

                else
                {
                    Console.WriteLine("비밀번호가 틀렸습니다.");
                }

            }
        }
    }
}

// 비밀번호 입력부를 while문 사용하도록 수정할 것 (16 ~ 27번 줄)