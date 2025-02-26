using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {

        //static
        //메모리 영역
        //스택    (stack)
        //힙      (heap)
        //정적 메모리 (static memory)
        /*
        static int count = 0; // 정적 메모리에 저장됨
        //프로그램 종료전까지 유지됨

        int instan = 200;
        */

        //1단계함수
        //반환형 함수이름 (매개변수)
        static void Loading() // static을 붙이지 않으면 에러 나는 모습. 유니티는 내부적으로 처리해주기에 안써도 괜찮다.
        {
            Console.WriteLine("로딩중.");
            Thread.Sleep(1000);
            Console.WriteLine("로딩중.");
            Thread.Sleep(1000);
            Console.WriteLine("로딩중.");
            Thread.Sleep(1000);
        }


        //2단계
        //입력
        static void AttackFunction(int _Attack)
        {
            Console.WriteLine("공격력은 : " + _Attack);
        }

        //3단계
        //출력
        static int BaseAttack()
        {
            //기본 공격력 10
            int attack = 10;

            return attack;
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            /*
            //static
            *//*
            int instan = 10;

            count++;
            Console.WriteLine(count);
            Console.WriteLine(instan); // static 에 없는 함수는 적용되지 않음. 그래서 메인 함수 밖에서 함수를 쓸때는 static을 붙여주자. 
            *//*

            // Console.WriteLine("로딩화면");
            // 뭐 줄줄줄 여기에 지저분하게 쓸 필요 없음. 바로 위 로딩 함수로 이동

            //1단계
            Loading(); // 함수를 받아오면 바로 추출됨

            Console.WriteLine("게임이 시작됩니다.");
            Console.ReadLine();





            //2단계
            int Attack = 0;
            int BAttack = 0; //3단계 함수 호출
            Console.WriteLine("캐릭터의 공격력을 입력 : ");
            Attack = int.Parse(Console.ReadLine());

            AttackFunction(Attack); // Attack을 함수로 이동시켜서 _Attack로 대입. 그리고 함수를 진행시키고 반환시킨 값을 이곳에 대체시키면 된다.

            //3단계
            //기본공격력 
            BAttack = BaseAttack();

            AttackFunction(BAttack + Attack);
            */

            //두 수를 더하는 함수 만들어서 오류를 해결하세요.
            /*
            int result = Add(10, 20);
            Console.WriteLine($"10 + 20 = {result}");
            */
            string[] fruits = { "사과", "바나나", "체리" };

            //반복문
            foreach(string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

        }
    }
}
