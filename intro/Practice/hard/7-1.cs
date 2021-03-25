using System;

namespace StudentList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("학생 숫자를 입력하세요.");
            int studentCount = int.Parse(Console.ReadLine());

            int[] ages = new int[studentCount];
            string[] names = new string[studentCount];
            double[] heights = new double[studentCount];
            double[] weights = new double[studentCount];

            Console.WriteLine("몇 번째 학생의 정보를 추가할까요?");
            int studentNumber = int.Parse(Console.ReadLine());

            if (studentNumber >= 0 && studentNumber <= studentCount - 1)
            {
                Console.WriteLine("나이를 입력하세요.");
                ages[studentNumber] = int.Parse(Console.ReadLine());

                Console.WriteLine("이름을 입력하세요.");
                names[studentNumber] = Console.ReadLine();

                Console.WriteLine("키를 입력하세요.");
                heights[studentNumber] = double.Parse(Console.ReadLine());

                Console.WriteLine("몸무게를 입력하세요.");
                weights[studentNumber] = double.Parse(Console.ReadLine());

                Console.WriteLine("");
                Console.Write(studentNumber);
                Console.WriteLine("번째 학생");
                Console.Write("이름: ");
                Console.WriteLine(names[studentNumber]);
                Console.Write("나이: ");
                Console.Write(ages[studentNumber]);
                Console.WriteLine("세");
                Console.Write("키: ");
                Console.Write(heights[studentNumber]);
                Console.WriteLine("cm");
                Console.Write("몸무게: ");
                Console.Write(weights[studentNumber]);
                Console.WriteLine("kg");

            }

            else
            {
                Console.Write("0에서 ");
                Console.Write(studentCount - 1);
                Console.WriteLine("사이에 숫자를 입력하세요.");
            }

        }
    }
}

// 해당 코드에 몸무게 weights 배열도 추가하시오