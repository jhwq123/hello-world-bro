using System;

namespace _9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }

                Console.Write("<");
                Console.Write(i);
                Console.WriteLine("단>");

                for (int j = 1; j <= 9; j++)
                {
                    Console.Write(i);
                    Console.Write(" * ");
                    Console.Write(j);
                    Console.Write(" = ");
                    Console.WriteLine(i * j);

                }
                        
            }

        }
    }
}
