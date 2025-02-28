using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace quest_1_20250227
{
    class Program
    {
        struct Player
        {
            public int X;
            public int Y;
            public string[] Shape;

            public Player(int x, int y)
            {
                X = x;
                Y = y;
                Shape = new string[]
                {
                    "->",
                    ">>>",
                    "->"
                };
            }
        }

        static void DrawPlayer(Player player)
        {
            // 방향키 입력에 따른 좌표 변경
            for (int i = 0; i < player.Shape.Length; i++) // 콘솔좌표 설정. 플레이서 x, y 좌표
            {
                //콘솔좌표 설정. 플레이어 X 플레이어 Y
                Console.SetCursorPosition(player.X, player.Y + i);
                //문자열 배열 출력
                Console.WriteLine(player.Shape[i]);
            }
        }

        static void MovePlayer(ref Player player, ConsoleKeyInfo keyInfo)
        {
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow: if (player.X > 0) player.Y--; break;
                case ConsoleKey.DownArrow: if (player.Y < Console.WindowHeight - 1) player.Y++; break;
                case ConsoleKey.LeftArrow: if (player.X > 0) player.X--; break;
                case ConsoleKey.RightArrow: if (player.X < Console.WindowWidth - 1) player.X++; break;
                case ConsoleKey.Spacebar: Console.Write("미사일 키"); break;
                case ConsoleKey.Escape:Environment.Exit(0); break; // ESC키로 종료
            }
        }


        static void Main(string[] args)
        {
            //움직일 수 있는 총 창의 크기 설정
            Console.SetWindowSize(80, 25); // 콘솔 창 크기 설정 (가로 80, 세로 25)
            Console.SetBufferSize(80, 25); // 버퍼 크기도 동일하게 설정 (스크롤 방지)
            Console.CursorVisible = false; // 마우스 커서 비 활성화

            Player player = new Player(0, 12);

            //ConsoleKeyInfo keyInfo; // 왜 뺌? 아니 왜 저기 들감?




            //시간 1초 루프

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long prevSecond = stopwatch.ElapsedMilliseconds; // 1/1000 1000일때 1초가 되는 것


            while (true)
            {
                long currentSecond = stopwatch.ElapsedMilliseconds; // 현재시간 가져오기

                if (currentSecond - prevSecond >= 100)
                {
                    prevSecond = currentSecond;//이전 시간 업데이트
                    if (Console.KeyAvailable) // 키가 눌렸을 때 true
                    {
                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                        MovePlayer(ref player, keyInfo);

                    }
                    Console.Clear();
                    DrawPlayer(player);
                }
            }
        }
    }
}
