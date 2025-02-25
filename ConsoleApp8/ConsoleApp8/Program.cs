using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //두 값을 비교하여 관계를 평가한다.
            /*
            // == 같다, != 같지 않다. a<=b b보다 작거나 같다, a>=b b보다 크거나 같다.
            int x = 5, y = 10;

            Console.WriteLine(x < y); // true
            Console.WriteLine(x > y); // false
            Console.WriteLine(x >= y); // false
            Console.WriteLine(x <= y); // true
            Console.WriteLine(x == y); // false
            Console.WriteLine(x != y); // true, x랑 y랑 같지 않니? 라고 물어보는 것, 이 경우는 같지 않으므로 true
            */

            //논리 연산자
            /*
            bool a = true;
            bool b = false;

            Console.WriteLine(a && b); 
            // AND  :   1 : 1   t
            //          1 : 0   f
            //          0 : 1   f
            //          0 : 0   f

            Console.WriteLine(a || b);
            // OR  :    1 : 1   t
            //          1 : 0   t
            //          0 : 1   t
            //          0 : 0   f

            Console.WriteLine(!a);
            // NOT : T와 F 반전
            //ex) b = !a; Console.WriteLine(b); // true
            */

            //비트연산자
            /*
            int x = 5; // 0101
            int y = 3; // 0011

            Console.WriteLine(x & y); // AND : 1 (0001) , 비트연산자는 기호 하나만써야함. 계산기로 프로그래머 용 쓰면 자세히 확인 가능
            // 0101
            // 0011
            // 0001 (세로로 AND 연산 결과)

            Console.WriteLine(x | y); // OR : 7 (0111)
            // 0101
            // 0011
            // 0111 (결과)

            Console.WriteLine(x ^ y); // XOR : 6 (0110)
            // 0101
            // 0011
            // 0110 (결과)

            Console.WriteLine(~x); // NOT : -6

            int value = 4; // 0100

            Console.WriteLine(value << 1); // 왼쪽이동 : 8 (1000)
            Console.WriteLine(value << 2); // 왼쪽이동 : 16 (0001 0000)
            Console.WriteLine(value >> 1); // 오른쪽이동 : 2 (0010)
            */

            //삼항 연산자
            /*
            int a = 10, b = 20;

            int max;

            max = (a > b) ? a : b; // (a > b) 결과가 true이면 a 쓰고 false이면 b를 쓰는 것. a는 b보다 작으므로 F이다. 그러므로 b의 값을 적용시키니 20이 출력된다.
            max = (a < b) ? a : b; // a가 b보다 작은게 맞으니 T. 고로 10이 출력된다.
            // (비교) ? 참 : 거짓; , if문과 유사함
            Console.WriteLine(max);
            */

            //삼항 연산자 예시문제
            /*
            int key = 1;

            string str1, str2;

            str1 = (key == 1) ? "문이 열렸습니다." : "문을 못 열었습니다.";
            str2 = (key == 2) ? "문이 열렸습니다." : "문을 못 열었습니다.";

            Console.WriteLine(str1); // True. 문을 열었습니다.
            Console.WriteLine(str2); // False. 문을 못 열었습니다.
            */

            //제어문 if, else, else if
            /*
            int score = 85;

            if(score >= 90)
            {
                Console.WriteLine("A 학점");

            }
            else
            {
                Console.WriteLine("B 학점");
            }


            if(true)
            {
                Console.WriteLine("트루");
            }
            else
            {
                Console.WriteLine("팔스");
            }


            string GameID = "멋사검존1";

            if(GameID == "멋사검존1")
            {
                Console.WriteLine("아이디가 일치합니다.");
            }
            else
            {
                Console.WriteLine("아이디가 일치하지 않습니다.");
            }


            int score2 = 75;

            if (score2 >= 90)
            {
                Console.WriteLine("A 학점");

            }
            else if (score2 >= 80)
            {
                Console.WriteLine("B 학점");
            }
            else if (score2 >= 70)
            {
                Console.WriteLine("C 학점");
            }
            else
            {
                Console.WriteLine("F 학점");
            }
            */

            //1단계
            // 가지고 있는 소지금을 입력하세요 : 
            // 0~100 무한의대검 공 : 1
            // 101~200 카타나 공 : 2
            // 201~300 진은검 공 : 3
            // 301~400 집판검 공 : 4
            // 401~500 엑스칼리버 공 : 5
            // 501~600 유령검 공 : 6
            // 601 이상 전설의검 공 : 7

            //2단계
            // 아래 처럼 출력시키기
            // 캐릭터 이름
            // 무기 : 이름 표시
            // 공격력 : 100 + 1

            int plsdmg = 100;
            string mysord;

            Console.Write("캐릭터 이름을 정해주세요 : ");
            string name = string.Concat(Console.ReadLine());

            Console.Write("가지고 있는 소지금을 입력하세요 : ");
            int mygold = int.Parse(Console.ReadLine());

            if (mygold < 100 && mygold > 0)
            {
                mysord = "무한의대검";
                plsdmg = 1;

            }
            else if (mygold < 200 && mygold > 101)
            {
                mysord = "카타나";
                plsdmg = 2;
            }
            else if (mygold < 300 && mygold > 201)
            {
                mysord = "진은검";
                plsdmg = 3;
            }
            else if (mygold < 400 && mygold > 301)
            {
                mysord = "집판검";
                plsdmg = 4;
            }
            else if (mygold < 500 && mygold > 401)
            {
                mysord = "엑스칼리버";
                plsdmg = 5;
            }

            else if (mygold < 600 && mygold > 501)
            {
                mysord = "유령검";
                plsdmg = 6;
            }
            else
            {
                mysord = "전설의 검";
                plsdmg = 7;
            }


            Console.WriteLine($"캐릭터 이름 : {name}");
            Console.WriteLine($"무기 : {mysord}");
            Console.WriteLine($"공격력 : 100 + {plsdmg}");




        }
    }
}
