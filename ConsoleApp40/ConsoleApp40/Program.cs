using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{

    class Parent
    {
        public Parent(string message)
        {
            Console.WriteLine("부모 생성자" + message); // 실행 순서 2
        }
    }


    class Child : Parent
    {
        public Child() : base("하하하하성공") // 부모 생성자 호출. 실행 순서 1
        {
            Console.WriteLine("자식 생성자 호출"); // 실행 순서 3
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child(); // 순서 0 객체 시작



        }
    }
}
