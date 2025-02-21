using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 리터럴 : 코드에서 고정된 값
            int number = 10; // 정수형 리터럴
            double pi = 3.14; // 실수형 리터럴
            char letter = 'A'; // 문자 리터럴
            string name1 = "Alice"; //문자열 리터럴

            Console.WriteLine(number);  // 출력 : 10
            Console.WriteLine(pi);      // 출력 : 3.14
            Console.WriteLine(letter);  // 출력 : A
            Console.WriteLine(name1);    // 출력 : Alice

            int hp = 100; // 정수형 리터럴
            double att = 56.7; // 실수형 리터럴
            char rank = 'S'; // 문자 리터럴
            string name = "Jake"; //문자열 리터럴

            Console.WriteLine("hp : " + number);  // 출력 : 10
            Console.WriteLine("att : " + att);      // 출력 : 3.14
            Console.WriteLine("캐릭터이름 : " + letter);  // 출력 : A
            Console.WriteLine("등급 : " + name);    // 출력 : Alice


        }
    }
}
