using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//네임스페이스
//클래스, 함수, 변수 이름이 충돌하는 것을 방지하기 위하여 사용한다.
// 네임스페이스 사용
/*
namespace 개발1부
{
    class MyClass
    {
        public static void SayHello()
        {
            Console.WriteLine("안녕하세요! MyNamespace의 MyClass입니다.");
        }
    }
}
*/



namespace ConsoleApp16
{
    class Program
    {
        // 네임스페이스 사용 도중 함수 사용
        /*
        static void SayHello()
        {
            Console.WriteLine("ㅎㅎㅎ");
        }
        */



        //C# 화살표 함수 (람다 표현식)
        // C#에서 화살표 함수 => 람다 표현식이라고도 하며
        // 간결한 방식으로 함수를 정의 할 수 있다.
        /*
        //일반적인 함수
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int AddArrow(int a, int b) => a + b;
        // {} 괄호 생략 가능

        //일반적인 함수
        static void PrintMessage()
        {
            Console.WriteLine("안녕하세요");
        }

        //화살표 함수
        static void PrintMessageArrow() => Console.WriteLine("안녕하세요!");
        */

        static void Main(string[] args)
        {
            //네임스페이스 사용
            /*
            SayHello();
            개발1부.MyClass.SayHello();
            */

            //화살표 함수 (람다 표현식)
            /*
            Console.WriteLine(Add(3, 5));
            Console.WriteLine(AddArrow(4, 6));

            PrintMessage();
            PrintMessageArrow();
            */






        }





    }



}
