using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest20250226
{
    class Program
    {

        static int Sum(int a, int b)
        {
            return a + b;
        } // 문제 7 함수

        static int GetStr(string str)
        {
            return str.Length;
        } // 문제 8 함수
        static int Maxnum(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        } // 뮨제 9 함수
        static void Main(string[] args)
        {
            // 문제1 >> 크기가 5인 정수 배열을 만들고, {10, 20, 30, 40, 50} 값을 저장한 후 출력하세요.
            // 예상출력 >> 10 20 30 40 50
            /*
            int[] num = new int[] { 10, 20, 30, 40, 50 };
            Console.Write("1번문제 >> ");
            for (int i=0; i<5; i++)
            {
                Console.Write(num[i] + " ");
            }
            */

            // 문제2 >> 사용자가 5개의 정수를 입력하면 배열에 저장하고, 모든 수의 합을 출력하세요.
            // 예상 입/출력 >> 숫자 입력 : 1 2 3 4 5 / 총 합 : 15
            /*
            int[] num = new int[5];
            int sum = 0;
            
            Console.WriteLine("숫자 입력 : ");
            for (int i = 0; i < 5; i++)
            {
                num[i] = int.Parse(Console.ReadLine());

                sum += num[i];
            }
            Console.WriteLine($"총 합 :  + {sum}");
            */

            // 문제3 >> 정수 배열 {3, 8, 15, 6, 2}에서 가장 큰 값을 찾아 출력하세요.
            // 예상 출력 : 최대값 : 15
            /*
            int[] num = new int[] { 3, 8, 15, 6, 2 };
            int max = num[0];

            for(int i =0; i<5; i++)
            {
                if (num[i] > max)
                {
                    max = num[i];
                }
            }
            Console.WriteLine($"최대값 : {max}");
            */

            // 문제4 >> for문을 사용하여 1부터 10까지 출력
            // 예상 출력 >> 1 2 3 4 5 6 7 8 9 10
            /*
            for(int i=1; i<11; i++)
            {
                
                Console.Write(i + " " );
            }
            */

            // 문제5 >> while문을 사용하여 1부터 10까지 중 짝수만 출력
            // 예상 출력 >> 2 4 6 8 10
            /*
            int num = 1;
            while(true)
            {
                Console.Write(num * 2 + " ");
                num++;
                if (num * 2 > 10) break;
            }
            */

            // 문제6 >> foreach문을 사용하여 배열 {1,2,3,4,5}를 출력하세요
            // 예상 출력 >> 1 2 3 4 5
            /*
            int[] num1 = new int[]{ 1, 2, 3, 4, 5 };

            //반복문
            foreach (int num in num1)
            {
                Console.Write(num+" ");
            }
            */

            // 문제7 >> 두 개의 정수를 입력받아 합을 반환하는 함수를 작성하세요.
            // 예상 출력 >> 3과 5의 합 : 8
            /*
            Console.Write("정수 1 : ");
            int input1 = int.Parse(Console.ReadLine());
            Console.Write("정수 1 : ");
            int input2 = int.Parse(Console.ReadLine());

            Console.Write($"{input1}과 {input2}의 합 : {sum(input1,input2)}");
            */

            // 문제8 >> 문자열을 입력받아 길이를 반환하는 함수를 작성하세요
            // 예상 출력 >> 문자열 입력 : Hello \n문자열 길이 : 5
            /*
            Console.Write("문자열 입력 : ");
            string input1 = Console.ReadLine();
            Console.Write("\n문자열 길이 : " + GetStr(input1));
            */

            // 문제9 >> 세 개의 정수를 입력받아 가장 큰 값을 반환하는 함수를 작성하세요.
            // 예상 출력 >> 가장 큰 수 : 7

            Console.Write("정수 1 : ");
            int input = int.Parse(Console.ReadLine());
            Console.Write("정수 2 : ");
            int input2 = int.Parse(Console.ReadLine());
            Console.Write("정수 3 : ");
            int input3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"가장 큰 수 : {Maxnum(input, input2, input3)}");

        }
    }
}
