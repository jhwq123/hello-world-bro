using System;

namespace _7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] weights = new double[3];
            weights[0] = double.Parse(Console.ReadLine());
            weights[1] = double.Parse(Console.ReadLine());
            weights[2] = double.Parse(Console.ReadLine());

            Console.Write("첫 번재 무게:  ");
            Console.WriteLine(weights[0]);
            Console.Write("두 번재 무게:  ");
            Console.WriteLine(weights[1]);
            Console.Write("세 번재 무게:  ");
            Console.WriteLine(weights[2]);

        }
    }
}

// 배열 이용 코드 수정