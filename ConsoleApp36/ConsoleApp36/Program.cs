using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Person
    {
        //public string name; //필드 클래스의 데이터를 저장하는 멤버입니다.
        //private string name; // private 쓰면 외부에서 못씀. 

        private string name = "홍길동"; // 여기에 초기로 값 설정도 가능
        public void SetName(string n) // 대신 이런식으로 값을 받아와서
        {
            name = n;
        }
        public string GetName() // 사용은 가능하다
        {
            return name;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person(); //객체로 만들기  인스턴스
            // p.name = "Alice"; //필드에 값넣기
            // Console.WriteLine(p.name);

            Console.WriteLine(p.GetName());
            p.SetName("Bob");
            Console.WriteLine(p.GetName());

        }
    }
}
