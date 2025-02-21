using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //문자열
            string greeting; // 문자열 변수를 선언
            greeting = "Hello World!"; // 변수에 값을 저장

            //변수의 값 사용
            Console.WriteLine(greeting); // 출력 : Hello World!
            */

            /*
            //변수 선언과 초기화를 한번에 수행
            int score = 100; // 정수형 변수 선언과 동시에 100으로 초기화
            double temperature = 36.5; // 실수형 변수 선언과 초기화
            string city = "Seoul"; // 문자열 변수 선언과 초기화

            //변수 출력
            Console.WriteLine(score); // 출력 : 100
            Console.WriteLine(temperature); // 출력 : 
            Console.WriteLine(city); // 출력 : Seoul
            */

            /*
            //같은 데이터 타입의 변수를 쉼표로 구분해서 선언
            int x = 10, y = 20, z = 30; // 정수형 변수 x,y,z를 선언하고 초기화

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            */

            /*
            // const : 값 고정
            const double Pi = 3.14159; //상수 pi 선언 및 초기화
            const int MaxScore = 100; // 정수형 상수 선언

            Console.WriteLine("Pi : "+Pi);
            Console.WriteLine("Max score : "+MaxScore);
            */

            int att = 16755;
            int maxhp = 78103;
            int cri = 36;
            int major = 1017;
            int supp = 41;
            int speed = 611;
            int endure = 22;
            int exp = 39;

            Console.WriteLine("기본특성");
            Console.WriteLine("공격력 : " + att);            
            Console.WriteLine("공격력 : " + maxhp);

            Console.WriteLine("전투특성");
            Console.WriteLine("공격력 : " + cri);
            Console.WriteLine("공격력 : " + major);
            Console.WriteLine("공격력 : " + supp);
            Console.WriteLine("공격력 : " + speed);
            Console.WriteLine("공격력 : " + endure);
            Console.WriteLine("공격력 : " + exp);



        }
    }
}
