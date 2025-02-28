using System;
using System.Diagnostics;

namespace quest_1_20250227
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

    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            Console.CursorVisible = false;

            Player player = new Player(0, 12);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            long prevSecond = stopwatch.ElapsedMilliseconds;

            while (true)
            {
                long currentSecond = stopwatch.ElapsedMilliseconds;
                if (currentSecond - prevSecond >= 100)
                {
                    prevSecond = currentSecond;
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                        MovePlayer(ref player, keyInfo);
                    }

                    Console.Clear();
                    DrawPlayer(player);
                }
            }
        }

        static void DrawPlayer(Player player)
        {
            for (int i = 0; i < player.Shape.Length; i++)
            {
                Console.SetCursorPosition(player.X, player.Y + i);
                Console.WriteLine(player.Shape[i]);
            }
        }

        static void MovePlayer(ref Player player, ConsoleKeyInfo keyInfo)
        {
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    if (player.Y > 0) player.Y--;
                    break;
                case ConsoleKey.DownArrow:
                    if (player.Y < Console.WindowHeight - 1) player.Y++;
                    break;
                case ConsoleKey.LeftArrow:
                    if (player.X > 0) player.X--;
                    break;
                case ConsoleKey.RightArrow:
                    if (player.X < Console.WindowWidth - 1) player.X++;
                    break;
                case ConsoleKey.Spacebar:
                    Console.Write("미사일 키");
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
