using System;

namespace _7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Subjects = { "국어", "영어", "수학", "과학", "사회" };
            int[] scores = new int[5];

            Console.Write(Subjects[0]);
            Console.Write(" 점수를 입력하세요: ");
            scores[0] = int.Parse(Console.ReadLine());

            Console.Write(Subjects[1]);
            Console.Write(" 점수를 입력하세요: ");
            scores[1] = int.Parse(Console.ReadLine());

            Console.Write(Subjects[2]);
            Console.Write(" 점수를 입력하세요: ");
            scores[2] = int.Parse(Console.ReadLine());

            Console.Write(Subjects[3]);
            Console.Write(" 점수를 입력하세요: ");
            scores[3] = int.Parse(Console.ReadLine());

            Console.Write(Subjects[4]);
            Console.Write(" 점수를 입력하세요: ");
            scores[4] = int.Parse(Console.ReadLine());

            int sum = scores[0] + scores[1] + scores[2] + scores[3] + scores[4];
            double average = sum / 5;

            Console.WriteLine("");
            Console.Write("총점 : ");
            Console.WriteLine(sum);
            Console.Write("평균 : ");
            Console.WriteLine(average);

        }
    }
}

// 국, 영, 수 ,과, 사 점수 받아 총점, 평균 구하는 프로그램 작성