using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusStudy0306
{
    class Program
    {
        static void Main(string[] args)
        {

            //2차원 배열
            //배열을 출력하는 프로그램을 만들어주세요
            /*
            int[,] array =
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };
            //출력
            
            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    Console.Write(array[y, x]);
                }
                Console.WriteLine();
            }
            */


            //2차원 배열
            //각 행과 열의 합을 따로 출력하는 프로그램을 만들어주세요
            //1~9까지.
            //x축 123, 456, 789 합
            //y축 147, 258, 369 합
            /*
            //각 행과 열의 길이를 받아오는 함수
            int y = array.GetLength(0);
            int x = array.GetLength(1);

            //행의 합
            for (int i = 0; i < y; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < x; j++)
                {
                    rowSum += array[i, j];
                }
                Console.WriteLine($"각 행의 합 : {rowSum}");
            }

            //열의 합
            for (int i = 0; i < x; i++)
            {
                int highSum = 0;
                for (int j = 0; j < y; j++)
                {
                    highSum += array[j, i];
                }
                Console.WriteLine($"각 행의 합 : {highSum}");
            }
            */

            //
            /*
            int[,] array2 =
            {
                {1,2,3 },
                {4,5,6 }
            };

            int y = array2.GetLength(0);
            int x = array2.GetLength(1);

            for(int i = 0; i < y; i++)
            {
                for(int j = 0; j < x; j++)
                {
                    Console.Write(array2[i,j] + " ");

                }
                Console.WriteLine();
            }
            */
            //빙고게임
            //3x3 빙고게임. 대각선 제외하고 가로세로 중 한줄만 완성되면 빙고
            // 추가로 해도 ㄱㅊ

            int[,] Bingo =
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };

            int x = Bingo.GetLength(1);
            int y = Bingo.GetLength(0);

            int BingoCount = 0;

            for(int i = 0; i > x; i++)
            {

            }

        }
    }
}
