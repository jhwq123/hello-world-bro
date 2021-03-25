using System; // System밖에 쓰지 않는다. 가장 기초적임.

namespace UltimateBaseball_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+------------------------------------------------------+"); // console에 출력문 추가하는 방법
            Console.WriteLine("|                 궁극의 숫자야구 게임                 |");
            Console.WriteLine("+------------------------------------------------------+");
            Console.WriteLine("| 컴퓨터가 수비수가 되어 세 자릿수를 하나 골랐습니다.  |");
            Console.WriteLine("| 각 숫자는 0~9중에 하나며 중복되는 숫자는 없습니다.   |");
            Console.WriteLine("| 모든 숫자와 위치를 맞히면 승리합니다.                |");
            Console.WriteLine("| 숫자와 순서가 둘 다 맞으면 스트라이크입니다.         |");
            Console.WriteLine("| 숫자만 맞고 순서가 틀리면 볼입니다.                  |");
            Console.WriteLine("| 숫자가 틀리면 아웃입니다.                            |");
            Console.WriteLine("+------------------------------------------------------+");

            Random random = new Random(); // C# 자체 랜덤 함수를 가져와서 씀

            int[] numbers = new int[3]; // int형 배열 만드는 법

            int index = 0;

            while (index < 3) // while 반복문, 타 언어와 용법 동일
            {
                numbers[index] = random.Next(0, 10); // 랜덤 값 설정방법, 0 ~ 9까지 받음

                bool hasduplicate = false; // 참 거짓형 변수

                for (int j = 0; j < index; j++) // for 반복문, 타 언어와 용법 동일
                {
                    if (numbers[index] == numbers[j])
                    {
                        hasduplicate = true;
                        break;
                    }

                }

                if (!hasduplicate)
                {
                    index++;
                }

            }

            int[] guesses = new int[3];
            string[] inputMessages = { "> 첫 번째 숫자를 입력하세요.", "> 두 번째 숫자를 입력하세요.", "> 세 번째 숫자를 입력하세요." }; // string형 배열 설정 방법

            while(true) // while 무한 반복문, 메인 코드실행문
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(inputMessages[i]);
                    guesses[i] = int.Parse(Console.ReadLine()); // 사용자로부터 입력받은 값의 정수값만 긁어옴
                }

                Console.WriteLine("> 공격수가 고른 숫자");

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(guesses[i]); 
                }

                if (guesses[0] == guesses[1] || guesses[1] == guesses[2] || guesses[0] == guesses[2]) // 비교문 타 언어와 동일
                {
                    Console.WriteLine("같은 숫자는 입력하면 안됩니다.");
                    continue; // continue를 쓰면, 해당 줄 코드내용 다 무시되고 처음으로 다시 돌아감. 타 언어와 동일
                }

                int strikeCount = 0;
                int ballCount = 0;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (guesses[i] == numbers[j])
                        {
                            if (i == j)
                            {
                                strikeCount++;
                            }

                            else
                            {
                                ballCount++;
                            }

                        }

                    }

                }

                Console.Write("스트라이크: ");
                Console.WriteLine(strikeCount);
                Console.Write("볼: ");
                Console.WriteLine(ballCount);
                Console.Write("아웃: ");
                Console.WriteLine(3 - strikeCount - ballCount);

                if (strikeCount == 3)
                {
                    Console.WriteLine("정답입니다!");
                    break; // break를 쓰면, 해당 줄 코드내용 다 무시되고 빠져나옴. 타 언어와 동일
                }

            }              
        }
    }
}

// 이후 내용은 배운내용을 바탕으로 추가하도록 하겠네요
// 필요내용 : 랜덤 숫자 정하기 (0~9 중 3개 랜덤), 내가 입력한 숫자 인식 방법, 입력후의 해석, 상품?