using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class MyResource
    {
        //소멸자 클래스
        /*
        ~MyResource()
        {
            Console.WriteLine("삭제될 때 호출");
        }
        */


    }
    class Program
    {

        //re 포인터 개념 참조
        //매서드 ref, out
        static void Increase(ref int x)
        {
            x++;
        }

        //out
        //반환이 여러개일때 유용하다.
        static void OutfFunc(int a, int b, out int x, out int y) //두개 이상 리턴할 때 유용하다
        {
            x = a;
            y = b;
        }


        static void Main(string[] args)
        {
            //소멸자
            /*
            MyResource r = new MyResource(); // 호출됨
            // GC(Garbage Collector)에 의해 나중에 소멸자 호출
            // 가비지 컬렉션은 더이상 참조되지 않는 객체를 정리합니다.
            */

            //ref
            /*
            int a = 10;
            Increase(ref a); //ref 안넣으면

            Console.WriteLine("A의 값 : " + a);
            */

            //out
            //함수에서 전달해서 메인으로 바로 받아옴
            int a = 10;
            int b = 10;

            int x, y;
            OutfFunc(a, b, out x, out y);

            Console.WriteLine("x : " + x + " y : " + y);



        }
    }
}
