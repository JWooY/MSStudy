using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {

            //switch 문
            /*
            int day = 1;

            switch(day)
            {
                case 1:
                    Console.WriteLine("월요일");
                    break;
                case 2:
                    Console.WriteLine("화요일");
                    break;
                case 3:
                    Console.WriteLine("수요일");
                    break;
                case 4:
                    Console.WriteLine("목요일");
                    break;
                case 5:
                    Console.WriteLine("금요일");
                    break;
                default:
                    Console.WriteLine("주말입니다.");
                    break;
            }
            */

            // alt+드래그 하면 // 표시 된거 여러줄 드래그 가능

            //스위치문 사용 예제
            /*
            //캐릭터를 선택하세요 (1.검사 2.마법사 3.도적) :

            //검사
            //공격력 100
            //방어력 90

            //마법사
            //공격력 110
            //방어력 80

            //도적
            //공격력 115
            //방어력 70

            
            Console.Write("캐릭터를 선택하세요 (1.검사 2.마법사 3.도적) : ");
            int charnum = int.Parse(Console.ReadLine());

            switch (charnum)
            {
                case 1:
                    Console.WriteLine("검사를 선택하셨습니다.");
                    Console.WriteLine("공격력 100");
                    Console.WriteLine("방어력 90");
                    break;

                case 2:
                    Console.WriteLine("마법사를 선택하셨습니다.");
                    Console.WriteLine("공격력 110");
                    Console.WriteLine("방어력 80");
                    break;

                case 3:
                    Console.WriteLine("도적을 선택하셨습니다.");
                    Console.WriteLine("공격력 115");
                    Console.WriteLine("방어력 70");
                    break;

                default:
                    Console.WriteLine("잘 못 입력하셨습니다.");
                    break;
            }
            */

            //반복문 for
            /*
            for(int i = 1; i <=5; i++)
            {
                Console.WriteLine("숫자 : " + 1);
            }
            */

            //무한반복 for문
            /*
            for (; ; )
            {
                Console.WriteLine("중꺾마");
            }
            */

            //0부터 9까지 출력하기. for문 활용 예제1
            /*
            for(int i = 1; i <= 9; i++)
            {
                Console.WriteLine("숫자 : " + i);
            }
            */

            //1부터 10까지의 합 구하기. for문 활용 예제2
            /*
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine("1~10까지 숫자의 합 : " + sum);
            */

            //조건문 while
            /*
            int count = 1; //초기화

            while (count <= 5) //조건식
            {
                Console.WriteLine("Count : " + count);

                count++; // 증가 or 감소

                if(count == 3)
                {
                    Console.WriteLine("3일때 반복문 탈출");
                    break;
                }
            }

            Console.WriteLine("Count : " + count);
            */

            //랜덤
            //Random rand = new Random(); // Random 객체를 생성한다.

            // 0 이상 10 미만의 랜덤 정수 생성
            /*
            int randomNumber = rand.Next(0, 10); // 0~9
            Console.WriteLine("0 이상 10 미만의 랜덤 정수"+ randomNumber);
            */

            // 0 이상 10 미만의 랜덤 정수 생성 반복
            /*
            for(int i = 0; i <10; i++)
            {
                int randomNumber = rand.Next(0, 10); // 0~9
                Console.WriteLine("0 이상 10 미만의 랜덤 정수" + randomNumber);
            }
            */

            // 0 이상 10 미만의 랜덤 실수 반복
            /*
            for (int i = 0; i < 10; i++) // 여긴 최대 범위 조절
            {
                double randomNumber = rand.NextDouble(0, 10); // 0~9 여기서 세부 범위 조절
                Console.WriteLine("0 이상 10 미만의 랜덤 실수" + randomNumber);
            }
            */

            //대장장이 키우기
            //도끼등급 SSS  10%
            //도끼등급 SS   40%
            //도끼등급 S    50%
            /*
            Random rand = new Random();

            int rnd = 0;

            for (int i = 0; i < 20; i++)
            {
                rnd = rand.Next(1, 101); //1~100%까지 범위 지정
                
                if (rnd >= 1 && rnd <= 10)
                {
                    Console.WriteLine("도끼등급 SSS");
                }
                else if (rnd >= 11 && rnd <= 40)
                {
                    Console.WriteLine("도끼등급 SS");
                }
                else
                {
                    Console.WriteLine("도끼등급 S");
                }
                Thread.Sleep(500); // 0.5초정도 멈췄다 뽑아라.
            }
            */

            //do while
            //1회 무조건 실행하고 while 문과 같이 조건 진행
            /*
            int x = 5;

            do
            {
                Console.WriteLine("최소 한번은 실행됩니다.");
                x--;
            } while (x > 0);
            */

            //break문
            //반복문을 탈출할 수 있다.
            /*
            for(int i=1; i<=10; i++)
            {
                if (i ==5)
                { 
                    break; 
                }

                Console.WriteLine(i);
            }
            */

            //continue
            //현재 반복을 건너뛰고 다음 반복으로 넘어간다.
            /*
            for(int i = 1; i <= 10; i++)
            {
                if ( i % 2 == 0)
                {
                    continue;
                }

                Console.WriteLine(i); // 홀수만 출력
            }
            */

            //goto
            //반복문이지만 코드가 길어지면 찾기 힘들어 잘 안씀. 비추천이지만 알아는 둬라.
            /*
            int n = 1;

            start:

            if (n <= 5)
            {
                Console.WriteLine(n);
                n++;

                goto start; //레이블로 이동
            }
            */


        }
    }
}
