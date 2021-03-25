using System;

namespace _7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 90, 85, 73, 100 };

            Console.WriteLine(scores[0]);
            Console.WriteLine(scores[1]);
            Console.WriteLine(scores[2]);
            Console.WriteLine(scores[3]);
        }
    }
}

// 다음 코드 버그 수정
// int뒤에 [] 가 빠져있음, 배열부호 써줘야됨