using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("먹은 사과의 개수를 입력하세요.");
            int eatenAppleCount = int.Parse(Console.ReadLine());
            if (eatenAppleCount > 3)
            {
                Console.WriteLine("사과를 많이 먹었습니다.");
            }
            else if (eatenAppleCount < 3)
            {
                Console.WriteLine("사과를 조금 먹었습니다.");
            }
            else
            {
                Console.WriteLine("사과를 적절히 먹었습니다.");
            }

        }
    }
}

// 출력 결과 예상
//
// 먹은 사과의 개수를 입력하세요.
// _(입력부)
// 분기점 3개보다 많을 때 -> 사과를 많이 먹었습니다.
// 분기점 3개보다 적을 때 -> 사과를 조금 먹었습니다.
// 분기점 그외일때 -> 사과를 적절히 먹었습니다.