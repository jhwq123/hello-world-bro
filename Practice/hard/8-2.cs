using System;

namespace _8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] index = { "국어", "수학", "영어" };

            Console.Write("학생이 총 몇명인가요? : ");
            int Student = int.Parse(Console.ReadLine());

            int[] total = new int[Student];
            double[] average = new double[Student];
            int cnt1 = 0;
            int cnt2 = 0;

            Console.WriteLine("----------------------------");
            Console.WriteLine("학생 점수를 입력받겠습니다.");
            Console.WriteLine("");

            while (cnt1 < Student)
            {
                Console.Write(cnt1 + 1);
                Console.WriteLine("번째 학생의 점수를 입력하세요");

                while (cnt2 < 3)
                {
                    Console.Write(index[cnt2]);
                    Console.Write(" : ");
                    total[cnt1] += int.Parse(Console.ReadLine());
                    cnt2++;
                }

                average[cnt1] = total[cnt1] / cnt2;
                cnt1++;
                cnt2 = 0;
                
            }

            cnt1 = 0;

            Console.WriteLine("----------------------------");
            Console.WriteLine("학생 총점과 평균을 출력하겠습니다.");
            Console.WriteLine("");

            while (cnt1 < Student)
            {
                Console.Write(cnt1 + 1);
                Console.WriteLine("번째 학생");
                Console.Write("총점 : ");
                Console.WriteLine(total[cnt1]);
                Console.Write("평균 : ");
                Console.WriteLine(average[cnt1]);

                cnt1++;

            }

        }
    }
}

// 총학생 수 입력받음. _int Student
// 각 학생 국어, 영어, 수학 점수 입력받음. _string[] index {"국어"}....
// 입력받은 각 점수 계산.
// 각 학생 총점과 평균 구하는 프로그램 작성. _int[] total _double[] average
// 또 평균이 소숫점이 안나옴...