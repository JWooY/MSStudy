using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo2
{
    class Program
    {
        static void Main(string[] args)
        {

            //    2차원 배열     //

            int[,] board = new int[5, 5]; // 5x5 빙고판 
            bool[,] marked = new bool[5, 5]; // 선택된 숫자 체크

            int bingoCount = 0;

            Random random = new Random();
            //빙고판 초기화
            int[] numbers = new int[25];

            for (int i = 0; i < 25; i++) numbers[i] = i + 1; //1줄짜리 for문이라 그냥 이렇게 씀
            
            // 랜덤 섞기(Fisher-Yates Shuffle)
            for (int i = 0; i<100; i++)
            {
                int a = random.Next(25);
                int b = random.Next(25);

                // C#의 튜플(Tuple) 문법을 활용하여 두 변수의 값을 교환(Swap) 하는 방법
                (numbers[a], numbers[b]) = (numbers[b], numbers[a]);
            }

            //2차원 배열로 변환
            int index = 0;
            for(int i=0; i<5; i++)
            {
                for(int j=0; j<5; j++)
                {
                    board[i, j] = numbers[index++];
                }
            }

            //게임 시작
            while(bingoCount<5)
            {
                Console.Clear();

                //빙고판 출력
                Console.WriteLine("현재 빙고판");

                for(int i=0; i<5; i++)
                {
                    for(int j=0; j<5; j++)
                    {
                        if (marked[i, j])
                            Console.Write(" X ");
                        else
                            Console.Write($"{board[i, j],2} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"현재 빙고 개수 : {bingoCount}");
                Console.Write("숫자를 입력하세요 (1~25) : ");
                int number = int.Parse(Console.ReadLine());

                /*
                if(int.TryParse(Console.ReadLine(), out int number)) Try파서 이용하면 숫자 오류나도 잡아주는데 일단 보류. 나도 자세히 모르겠음.
                {

                }
                */

                bool found = false; // 추가된거 
                for (int i =0; i<5; i++)
                {
                    for(int j=0; j<5; j++)
                    {
                        if (board[i,j] == number)
                        {
                            marked[i, j] = true; // 숫자를 X로 변경
                            found = true; // 추가된거 
                            break;
                        }
                    }
                    if (found) break; // 추가된거 
                }

                bingoCount = 0;

                //가로체크 Bingo 1이랑 같은데 코드가 다름. 훨씬 수월해짐.
                for(int i=0; i<5; i++)
                {
                    bool rowBingo = true;
                    for (int j = 0; j < 5; j++)
                        if (!marked[i, j]) rowBingo = false;

                    if (rowBingo) bingoCount++;
                }

                //세로체크
                for (int j = 0; j < 5; j++)
                {
                    bool colBingo = true;

                    for (int i = 0; i < 5; i++)
                        if (!marked[i, j]) colBingo = false;

                    if (colBingo) bingoCount++;
                }

                //대각선체크 왼위->오아
                // 00 01 02 03 04
                // 10 11 12 13 14
                // 20 21 22 23 24
                // ... 이런식으로 감
                bool diaglBingo = true;

                for(int i =0; i<5; i++)
                {
                    if (!marked[i, i]) diaglBingo = false;
                }
                if (diaglBingo) bingoCount++;


                //대각선 오위->왼아
                bool diagl2Bingo = true;

                for (int i = 0; i < 5; i++)
                {
                    if (!marked[i, 4 - i]) diagl2Bingo = false;
                }
                if (diagl2Bingo) bingoCount++;
            }

            Console.WriteLine("빙고 5개 완성! 게임 종료");
        }
    }
}
