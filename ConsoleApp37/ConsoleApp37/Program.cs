using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{

    class Person
    {
        public string Name;
        public int Age;

        public Person() // 생성자
        {
            Name = "Unknown";
        }
        public Person(string name)
        {
            Name = name;
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // p = new Person(); // Unknown 출력
            Person p = new Person("엘리스"); // 엘리스 출력
            Console.WriteLine(p.Name);


            Person p1 = new Person("Bob");//1개짜리 매개변수있는 생성자
            Person p2 = new Person("카타리나", 20); //2개짜리 매개변수있는 생성자

            Console.WriteLine(p.Name + "," + p.Age); // 입력 안됐으니 0 출력
            Console.WriteLine(p1.Name + "," + p1.Age); // 입력 안됐으니 0 출력
            Console.WriteLine(p2.Name + "," + p2.Age); // 20 출력



        }
    }
}
