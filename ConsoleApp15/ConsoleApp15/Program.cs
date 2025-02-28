using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {

        //params 키워드 (가변 매개변수)
        static int Sum(params int[] numbers)
        {
            int total = 0;

            foreach(int num in numbers)
            {
                total += num;
            }
            return total;
        }

        //재귀함수 (자기 자신을 호출) ,사실상 반복문
        static void Print()
        {
            Console.WriteLine("나는 재귀함수다.");
            Print(); // 본인을 호출하니깨문에 무한 반복중
        }
        static int Factorial(int n)
        {
            if (n <= 1)
                return 1; //출력 겸 탈출

            Console.WriteLine("*" + n); // 돌아가는거 확인용

            return n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            //params 키워드 (가변 매개변수)
            /*
            Console.WriteLine(Sum(1, 2, 3)); // 출력 6
            Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10)); // 갯수 상관없이 다 더해줌
            */

            //재귀함수 (자기 자신을 호출)
            //Print(); // 무한반복
            //응용하여 팩토리얼 사용
            Console.WriteLine(Factorial(5)); // 5팩토리얼 출력


        }
    }
}
