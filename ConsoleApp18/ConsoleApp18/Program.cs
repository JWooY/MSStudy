using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        //C# 구조체
        // 클래스와 비슷하지만, 값 타입(Value Type)이며 가볍고 빠름
        // 주로 간단한 데이터 묶음을 만들 때 사용

        struct Point
        {
            public int X; //굳이 public 잡아주지 않아도 되지만 일단 적은것.
            public int Y;


            //셍성자 정의
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
            public void Print()
            {
                Console.WriteLine($"좌표 : {X},{Y}");

            }

        }
        //struct Point는 X, Y 좌표 값을 저장하는 구조체
        //구조체는 클래스와 다르게 new 없이 사용 가능





        static void Main(string[] args)
        {
            //구조체 사용
            /*
            Point p; // 구조체 선언(초기화 필요)

            p.X = 10;
            p.Y = 20;

            p.Print();
            */

            //생성자 정의 했을 때.
            Point p1 = new Point(5, 15);
            p1.Print();




        }
    }
}
