using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //단항 연산자
            /*
            int number = 5;
            bool flag = true;

            Console.WriteLine(+number); // 양수 출력 : 5
            Console.WriteLine(-number); // 음수 출력 : -5

            Console.WriteLine(!flag); // 논리부정 : false 출력 
            */

            //비트 반전 ~
            /*
            // 10 1010
            //    0101   4바이트    0000 0000 0000 0000 0000 0000 0000 1010

            int num = 10;
            int result = ~num; // 모든 비트 반전 : 1111 0101

            Console.WriteLine("원래 값 : " + num); // 10
            Console.WriteLine("~연산자 적용 후 값 : " + result); // -11
            */

            //캐스팅 (연산자 변환)
            /*
            double pi = 3.14;
            int intergerPi = (int)pi; // 실수형 -> 정수형으로 변환
            Console.WriteLine(intergerPi); // 소수점이 짤려서 3출력
            
            //ex
            int iKor = 90;
            int iEng = 75;
            int iMath = 58;

            int sum = 0;
            float average = 0.0f;

            sum = iKor + iEng + iMath;

            average = (float)sum / 3 ; // 평균 구하기
            //average = sum / 3f; // 또는 이것
            
            Console.WriteLine("총점 : " +sum);
            Console.WriteLine("평균 : " +average);
            */

            //문자열 연결 연산자
            /*
            string firstName = "Alice";
            string lastName = "Smith";

            Console.WriteLine(firstName + " " + lastName); 
            */

            // (a += 5) = (a = a + 5) 둘은 같은 연산이다.
            // -=, *=, /=, %= 모두 응용 가능

            //문제 1: 학점 평균 계산 프로그램
            /*
            Console.WriteLine("국어 성적을 입력하세요 : ");
            int Kor = int.Parse(Console.ReadLine());

            Console.WriteLine("영어 성적을 입력하세요 : ");
            int Eng = int.Parse(Console.ReadLine());

            Console.WriteLine("수학 성적을 입력하세요 : ");
            int Math = int.Parse(Console.ReadLine());
            
            double average = (Kor + Eng + Math) / 3f;

            Console.WriteLine(average.ToString("F2"));
            */

            //문제 2: 비트 반전(~) 연산자 활용 프로그램
            /*
            Console.WriteLine("정수를 입력하세요 : ");
            int a = int.Parse(Console.ReadLine());
            int result = ~a;

            Console.WriteLine($"정수의 기존 비트 값 :{a}");
            Console.WriteLine($"반전된 비트 값 :{result}");
            */

            //전위 (연산자가 앞에 붙이는거)
            /*
            int a = 3;

            ++a;
            Console.WriteLine("a의 값은 : " + a);

            ++a;
            Console.WriteLine("a의 값은 : " + a);
            */

            //후위 (연산자가 뒤에 붙이는거)
            /*
            int b = 3;

            b++;
            Console.WriteLine("b의 값은 : " + b);

            b++;
            Console.WriteLine("b의 값은 : " + b);
            */

            //전위 후위 주의사항
            int c = 3;
            Console.WriteLine("c의 값은 : " + c++); // 후위는 콘솔 라인에서 연산자가 적용이 안된다.
            
            Console.WriteLine("c의 값은 : " + +c); // 전위에 붙어야 적용되는 모습. 연산자 한개당 한번 적용

            // Console.WriteLine(++i) vs Console.WriteLine(i++) 차이점
            /*
            ++i 설명.

            i += 1;
            Console.WriteLine(i);

            i++설명.

            Console.WriteLine(i)
            i += 1;
            */


        }
    }
}
