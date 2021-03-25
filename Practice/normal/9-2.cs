using System;

namespace _9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];
            
            for (int index = 0; index < 5; index++)
            {
                Console.Write(index);
                Console.WriteLine("번째 과목의 성적을 입력하세요.");
                scores[index] = int.Parse(Console.ReadLine());
            }

            Console.Write("총점은 ");
            Console.Write(scores[0] + scores[1] + scores[2] + scores[3] + scores[4]);
            Console.WriteLine("점입니다.");

        }
    }
}

// 다음 내용을 for문을 사용해 수정하시오.