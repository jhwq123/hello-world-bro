using System;

namespace Break
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = 0;

            while(true)
            {
                Number = Number + 1;

                if (Number >= 20)
                {
                    Number = 100;
                    break;
                }

            }

        }
    }
}

// 예상, Number 변수가 항상 참의값인 while 반복문을 계속 돌면서
// Number 변수값 변화 -> 1, 2, 3, ... , 19, 20, 100 이후 종료