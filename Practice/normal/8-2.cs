using System;

namespace _8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("수업을 몇 과목 들었습니까?");
            int subjectCount = int.Parse(Console.ReadLine());

            int[] scores = new int[subjectCount];
            int index = 0;
            int total = 0;

            while(index < subjectCount)
            {
                Console.Write(index);
                Console.WriteLine("번째 과목의 성적을 입력하세요.");
                scores[index] = int.Parse(Console.ReadLine());
                total = total + scores[index];
                index++;
            }

            Console.Write("평균은 ");
            Console.Write(total / subjectCount);
            Console.WriteLine("점입니다.");
        }
    }
}

// 해당 코드내용 추가
// 평균쳤는데, int / int로 되서 정수부까지만 나옴,
// 추가 해결방안있는지?
// double average = total / subjectCount 하면 되긴하는데, 코드하나 추가해야됨