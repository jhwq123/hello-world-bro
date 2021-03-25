using System;

namespace _8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];
            int StuNumber = 0;

            while (StuNumber < 5)
            {
                Console.Write(StuNumber);
                Console.WriteLine("번째 과목의 성적을 입력하세요.");
                scores[StuNumber] = int.Parse(Console.ReadLine());

                StuNumber++;
            }

            Console.Write("총점은 ");
            Console.Write(scores[0] + scores[1] + scores[2] + scores[3] + scores[4]);
            Console.WriteLine("점입니다.");
        }
    }
}

// 해당 코드를 while문 사용하여 바꾸시오