using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Loading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("□□□□□□□□□□");
            Thread.Sleep(3000); // 1000 = 1초(1000밀리초) 멈췄다가 실행
            Console.Clear(); // 콘솔화면 지우기
            Console.WriteLine("                    ");
            Console.WriteLine("■□□□□□□□□□");

            // 응용
            Console.WriteLine("□□□□□□□□□□");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("■■□□□□□□□□");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("■■■□□□□□□□");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("■■■■□□□□□□");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("■■■■■□□□□□");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("■■■■■■□□□□");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("■■■■■■■□□□");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("■■■■■■■■□□");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("■■■■■■■■■□");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("■■■■■■■■■■");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("환영합니다!");
        }
    }
}
