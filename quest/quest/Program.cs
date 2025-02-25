using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest
{
    class Program
    {
        static void Main(string[] args)
        {
            //문제1 : 세 정수의 최대값 구하기
            Console.WriteLine(">>>>>>>>문제1<<<<<<<<");

            Console.Write("정수 a : ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("정수 b : ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("정수 c : ");
            int c = int.Parse(Console.ReadLine());

            if (a >= b && a >= c)
            {
                Console.WriteLine($"최대값 : {a}");
            }
            else if (b >= a && b >= c)
            {
                Console.WriteLine($"최대값 : {b}");
            }
            else
            {
                Console.WriteLine($"최대값 : {c}");
            }


            //문제 2 : 점수에 따른 학점 평가

            Console.WriteLine(">>>>>>>>문제2<<<<<<<<");

            Console.Write("학생의 점수 : ");
            int score = int.Parse(Console.ReadLine());

            if (score >= 90)
            {
                Console.WriteLine("A학점");
            }
            else if (score >= 80 && score < 90)
            {
                Console.WriteLine("B학점");
            }
            else if (score >= 70 && score < 80)
            {
                Console.WriteLine("C학점");
            }
            else if (score >= 60 && score < 70)
            {
                Console.WriteLine("D학점");
            }
            else
            {
                Console.WriteLine("F학점");
            }

            //문제 3 : 간단한 사칙연산 계산기
            Console.WriteLine(">>>>>>>>문제3<<<<<<<<");

            double sum, sub, mul, div = 0;
            bool valid = true;


            Console.Write("숫자 1 : ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("숫자 2 : ");
            int y = int.Parse(Console.ReadLine());

            Console.Write("연산자 : ");
            string oper = string.Concat(Console.ReadLine());

            if (oper == "+")
            {
                sum = x + y;
                Console.WriteLine($"결과 : {sum}");
            }
            else if (oper == "-")
            {
                sub = x - y;
                Console.WriteLine($"결과 : {sub}");
            }
            else if (oper == "*")
            {
                mul = x * y;
                Console.WriteLine($"결과 : {mul}");
            }
            else if (oper == "/")
            {
                if (x == 0 || y == 0)
                {
                    Console.WriteLine("ERROR! 0으로는 나눌 수 없습니다.");
                    Environment.Exit(0);
                }

                div = x / y;
                Console.WriteLine($"결과 : {div}");

            }

            else
            { 
                Console.WriteLine("연산자 입력이 잘못되었습니다.");
            }
            
        }
    }
}
