using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShootingGame1
{
    class Program
    {
        static void Main(string[] args)
        {
            //움직일 수 있는 총 창의 크기 설정
            Console.SetWindowSize(80, 25); // 콘솔 창 크기 설정 (가로 80, 세로 25)
            Console.SetBufferSize(80, 25); // 버퍼 크기도 동일하게 설정 (스크롤 방지)

            //플레이어 좌표 받고 움직이기
            /*
            Console.WriteLine("콘솔 창 크기가 80x25로 설정되었습니다.");
            Console.ReadKey(); // 키 입력 대기

            int x = 10, y = 10;

            ConsoleKeyInfo keyInfo;

            Console.CursorVisible = false;

            while (true)
            {
                Console.Clear();

                Console.SetCursorPosition(x, y);

                Console.Write("●"); // 현재 위치 출력

                keyInfo = Console.ReadKey(true); // 키 입력 받기(화면 출력 X)

                // 방향키 입력에 따른 좌표 변경
                switch(keyInfo.Key)
                {
                    case ConsoleKey.UpArrow: if (y > 0) y--; break;
                    case ConsoleKey.DownArrow: if (y < Console.WindowHeight - 1) y++; break;
                    case ConsoleKey.LeftArrow: if (x > 0) x++; break;
                    case ConsoleKey.RightArrow: if (x < Console.WindowWidth - 1) x++; break;
                    case ConsoleKey.Spacebar: Console.Write("미사일 키"); break;
                    case ConsoleKey.Escape: return; // ESC키로 종료
                }
                */

            string[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            }; //배열 문자열로 그리기

            int playerX = 0;
            int playerY = 12;

            ConsoleKeyInfo keyInfo;

            Console.CursorVisible = false; // 마우스 커서 비 활성화

            //시간 1초 루프
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long prevSecond = stopwatch.ElapsedMilliseconds; // 1/1000 1000일때 1초가 되는 것


            while (true)
            {
                //Console.Clear();

                //
                long currentSecond = stopwatch.ElapsedMilliseconds; // 현재시간 가져오기
                if (currentSecond - prevSecond >= 1000)
                {
                    keyInfo = Console.ReadKey(true); // 키 입력 받기(화면 출력 X)

                    Console.Clear();

                    //Console.WriteLine("1초 루프"); // 루프 되는지 확인
                    prevSecond = currentSecond; // 이전 시간 업데이트

                    // 방향키 입력에 따른 좌표 변경
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.UpArrow: if (playerX > 0) playerY--; break;
                        case ConsoleKey.DownArrow: if (playerY < Console.WindowHeight - 1) playerY++; break;
                        case ConsoleKey.LeftArrow: if (playerX > 0) playerX--; break;
                        case ConsoleKey.RightArrow: if (playerX < Console.WindowWidth - 1) playerX++; break;
                        case ConsoleKey.Spacebar: Console.Write("미사일 키"); break;
                        case ConsoleKey.Escape: return; // ESC키로 종료
                    }

                    for (int i = 0; i < player.Length; i++) // 콘솔좌표 설정. 플레이서 x, y 좌표
                    {
                        //콘솔좌표 설정. 플레이어 X 플레이어 Y
                        Console.SetCursorPosition(playerX, playerY + i);
                        //문자열 배열 출력
                        Console.WriteLine(player[i]);
                    }
                    // Thread.Sleep(100);
                    prevSecond = currentSecond;//이전 시간 업데이트
                }

            }


        }
    }
}
