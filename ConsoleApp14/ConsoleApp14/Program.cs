using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static int num2 = 20;
        
        //1. 매개변수도 반환값도 없는 함수
        static void PrintHello()
        {
            Console.WriteLine("안녕하세요");

        }
        //2. 매개변수만 있는 함수
        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        //3. 반환값만 있는 함수
        static int GetNumber()
        {
            num2 = 30;
            return 42;
        }

        //4. 매개변수와 반환값이 있는 함수
        static int Add(int a, int b)
        {
            return a + b;
        }

        //5. 기본값을 가진 매개변수 (디폹트 매개변수)
        static void Greet(string name = "손님")
        {
            Console.WriteLine($"안녕하세요, {name}");
        }

        //6. 함수 오버로딩(Overloading)
        static int Multiplay(int a, int b)
        {
            return a * b;
        }

        static double Multiplay(double a, double b)
        {
            return a * b;
        }

        //7. out 키워드 (에러 값을 반환 할 때)
        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }

        //8. ref 키워드 (값을 참조하여 수정)
        static void Increase(ref int num)
        {
            num += 10;
        }

        static void Main(string[] args)
        {
            //1. 매개변수도 반환값도 없는 함수
            // PrintHello(); // 출력

            //2.매개변수만 있는 함수
            // PrintMessage("반갑습니다.");

            //3. 반환값만 있는 함수
            //로컬 변수
            //int num = GetNumber();
            //Console.WriteLine(num);

            //4. 매개변수와 반환값이 있는 함수
            //매개변수
            //int result = Add(3, 5);
            //Console.WriteLine(result);
            //Console.WriteLine(Add(3, 5)); // 위 코드를 이렇게 한줄로 줄일 수 있음

            //5. 기본값을 가진 매개변수(디폴트 매개변수)
            //Greet();
            //Greet("철수");

            //6. 함수 오버로딩(Overloading)
            //Console.WriteLine(Multiplay(3, 4)); //정수 곱하기
            //Console.WriteLine(Multiplay(2.5, 3.5)); //실수 곱하기

            //7. out 키워드 (에러 값을 반환 할 때)
            //int q, r;
            //Divide(10, 3, out q, out r);
            //Console.WriteLine($"몫: {q}, 나머지: {r}"); //출력 : 몫: 1, 나머지: 3

            //8. ref 키워드 (값을 참조하여 수정)
            int value = 5;
            Increase(ref value);
            Console.WriteLine(value);


        }


        //이쪽공간에 함수를 써도 메인 함수에 적용 가능. class 내부이기만 하면 적용 됨.

    }
}
