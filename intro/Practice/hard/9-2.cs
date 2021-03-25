using System;

namespace _9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] slot = new int[5];
            int[] sum = new int[5];
            double[] average = new double[5];
            int[] students = new int[10];

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("-------------------------------");
                Console.Write(i+1);
                Console.WriteLine("반 학생의 성적을 입력하세요");

                for (int j = 0; j < 10; j++)
                {
                    Console.Write(j+1);
                    Console.Write("번째 학생 성적 : ");
                    students[j] = int.Parse(Console.ReadLine());
                    sum[i] += students[j];

                }

                average[i] = sum[i] / 10;

            }

            Console.WriteLine("-------------------------------");
            Console.WriteLine("입력받은 정보로 산출한 반별 평균입니다.");
            Console.WriteLine("-------------------------------");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("< ");
                Console.Write(i + 1);
                Console.WriteLine("반 >");
                Console.Write("평균 : ");
                Console.WriteLine(average[i]);
                // Console.WriteLine(sum[i]); // 테스트용이요
            }

        }
    }
}

// 3학년 5개의 반, 한 반에는 10명
// 각 반의 학생들의성적을 입력받아, 반별로 평균 구하기