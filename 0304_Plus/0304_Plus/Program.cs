using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0304_Plus
{
    class Program
    {
        static void Main(string[] args)
        {

            //Case문
            /*
            int season = int.Parse(Console.ReadLine());

            switch(season)
            {
                case 12 :
                case 1:
                case 2:  Console.WriteLine("겨울"); break;
                case 3:
                case 4:
                case 5: Console.WriteLine("봄"); break;
                case 6:
                case 7:
                case 8: Console.WriteLine("여름"); break;
                case 9:
                case 10:
                case 11: Console.WriteLine("가을"); break;
                default: Console.WriteLine("잘 못 입력되었습니다."); break;
            }
            */

            // 조건문이 끝났어요
            // 반복문
            // for 문 -> ~을 위한 -> 목적을 가지고, 어떤 대상에 대해
            // 어떤 특정 목적이나 대상을 정해놓고 그것을 위해 무언가를 수행하는 과정
            // 정해진 횟수가 특정 조건을 만족하는 범위의 대상을 반복하는 구조
            // for(초기화; 조건; 증감식;
            // {반복될 내용}


            // for문을 이용해서 1에서 10부터 숫자를 출력해보세요.
            /*
            for(int i=1; i<11; i++ )
            {
                Console.Write(i + " ");
            }
            */

            // 1에서 10까지 합을 구하시오 -> 1 + 2 + 3 + 4 ... + 10
            /*
            int sum = 0;

            for (int i = 1; i < 11; i++)
            {
                sum +=  i;
            }
            Console.Write(sum);
            */

            // 숫자를 입력받고 그 숫자의 구구단 단수를 출력하시오
            /*
            Console.Write("숫자 : ");
            int num = int.Parse(Console.ReadLine());

            for (int i=1; i<10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num*i}");
            }
            */

            // * 찍기.
            //*
            //**
            //***
            //****
            //*****


            for(int x= 1; x<6; x++)
            {
                for (int y = 1; y <= x; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            string s = "*";
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(s);
                s += "*";
            }



        }
    }
}
