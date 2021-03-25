using System;

namespace _8_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";

            while (true)
            {
                Console.WriteLine("아무 글자나 입력하세요. 끝내려면 '끝'을 입력하세요.");
                userInput = Console.ReadLine();
                Console.WriteLine(userInput);
                
                if(userInput == "끝")
                {
                    break;
                }

            }
        }
    }
}

// 다음코드 11번 줄 while(userInput !="끝") 대신 while(true)를 사용하게 바꿀것.