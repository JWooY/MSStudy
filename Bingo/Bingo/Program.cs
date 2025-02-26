using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    class Program
    {
        static void Main(string[] args)
        {
            //스왑
            /*
            int[] iArray = new int[] { 0 };
            int a = 10;
            int b = 20;
            int t = 0;

            t = a;
            a = b;
            b = t;

            Console.Write("a : " + a + " b : " + b);
            */

            int[] iArray = new int[25];

            for (int i = 0; i<25; i++)
            {
                iArray[i] = i + 1;
            }


            for(int i=0; i<5; i++)// 빙고판 완성
            {
                for(int j=0; j<5; j++)
                {
                    Console.Write(iArray[i*5+j].ToString("D2") + " ");
                }
                Console.WriteLine();
            }

            //셔플
            Random rand = new Random();
            for(int i = 0; i<100; i++)
            {
                int iA = rand.Next(0, 25);
                int iB = rand.Next(0, 25);
                int iT = 0;

                iT = iArray[iA];
                iArray[iA] = iArray[iB];
                iArray[iB] = iT;
            }

            //빙고판 셔플
            /*
            for (int i = 0; i < 5; i++)// 빙고판 셔플 됐는지 확인
            {
                for (int j = 0; j < 5; j++)
                {

                    Console.Write(iArray[i * 5 + j].ToString("D2") + " ");
                }
                Console.WriteLine();
            }
            */

            int input = 0;
            int iBingo = 0; // 빙고 카운트 선언
            int iCount = 0; // 빙고 이전 별 갯수 카운트 선언

            while (true)
            {
                Console.Clear();

                for (int i = 0; i < 5; i++)// 빙고판 셔플 됐는지 확인
                {
                    for (int j = 0; j < 5; j++)
                    {

                        if (iArray[i * 5 + j] == 0) // 0일 경우 체크
                        {
                            Console.Write(" * ");
                        }
                        else
                        {
                            Console.Write(iArray[i * 5 + j].ToString("D2") + " ");
                        }
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("빙고 숫자 :  " + iBingo);
                Console.WriteLine("숫자를 입력하세요 : ");
                input = int.Parse(Console.ReadLine());
                iBingo = 0; // 빙고 카운트


                for (int i =0; i<25; i++)
                {
                    if (iArray[i] ==input)
                    {
                        iArray[i] = 0;
                        break;
                    }
                }


                //빙고 체크 로직

                //가로 체크
                for(int i =0; i<5; i++) // ++i 나 ++1 이나 for문에선 똑같음
                {
                    for(int j=0; j<5; j++)
                    {
                        if (iArray[i * 5 + j] == 0) // 가로에 별이 있나 확인. 있으면 카운트 업
                        {
                            ++iCount;
                        }
                        if(iCount == 5) // 5개 카운트 되면 빙고 추가
                        {
                            ++iBingo;
                        }
                    }
                    iCount = 0; // 카운트 0으로 초기화 시켜서 다시 셈
                }

                //세로 체크
                for(int i=0; i<5; i++)
                {
                    for(int j=0; j<5; j++)
                    {
                        if (iArray[i + 5 * j] == 0)
                        {
                            ++iCount;
                        }

                        if (iCount == 5)
                        {
                            ++iBingo;
                        }
                    }
                    iCount = 0;
                }

                //대각선 오른쪽 체크
                //00 01 02 03 04 //대각선으로 보면 4의 배수인걸 확인 가능
                //05 06 07 08 09
                //10 11 12 13 14
                //15 16 17 18 19
                //20 21 22 23 24
                for(int i =0; i<5; i++)
                {
                    if (iArray[i*4+4] == 0) // i가 0일 때 4되고 , i가 1일 때 8되고 ... 4의 배수 카운트
                    {
                        ++iCount;
                    }
                    if(iCount == 5)
                    {
                        ++iBingo;
                    }
                    iCount = 0;
                }

                //대각선 왼쪽 체크
                for (int i = 0; i < 5; i++)
                {
                    if (iArray[i * 6] == 0) // i가 0일 때 0이지만 첫번째 자리가 0이므로 성립. 이후 6의 배수부터 0과 대각선이 됨
                    {
                        ++iCount;
                    }
                    if (iCount == 5)
                    {
                        ++iBingo;
                    }
                    iCount = 0;
                }

                if(iCount >= 5 )
                {
                    Console.WriteLine("빙고 성공");
                    break;
                }




            }

        }
    }
}
