using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            //배열
            // 0부터 시작한다.
            /*
            int[] num = new int[3]; // 3개의 메모리가 만들어진다.

            num[0] = 10;
            num[1] = 20;
            num[2] = 30;

            Console.WriteLine(num[0]);
            Console.WriteLine(num[1]);
            Console.WriteLine(num[2]);

            for(int i=0; i<3; i++)
            {
                Console.WriteLine(num[i]);
            }
            */

            //배열
            /*
            // 3개중 원하는 방식으로 써도 됨
            int[] number = { 1, 2, 3 }; // 간단한 선언과 초기화. 모든 값을 출력할 때 값이 하나라도 빠지면 에러남.
            int[] number2 = new int [3]; // 크기만 지정. 박스만 만든거기 때문에 값을 안넣고 돌려도 0으로 나온다.
            int[] number3 = new int [] { 1, 2, 3 }; // 초기화와 함께 선언

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(number3[i]);
            }

            string[] fruits = { "사과", "바나나", "오렌지" };

            for(int i=0; i<3; i++)
            {
                Console.WriteLine(fruits[i]);
            }
            */

            //배열 연습문제
            //국,영,수 점수 입력하고 총점과 평균 출력하기
            /*
            int[] iKor = new int[3];
            int[] iEng = new int[3];
            int[] iMath = new int[3];

            int[] sum = new int[3];
            float[] aver = new float[3];

            string[] student = { "민수", "철수", "영희" };

            Console.WriteLine("학생 성적을 입력하세요.");
            for(int i=0; i<3; i++)
            {
                Console.WriteLine($"이름 = {student[i]}");

                Console.Write("국어 : ");
                iKor[i] = int.Parse(Console.ReadLine());
                Console.Write("영어 : ");
                iEng[i] = int.Parse(Console.ReadLine());
                Console.Write("수학 : ");
                iMath[i] = int.Parse(Console.ReadLine());

                sum[i] = iKor[i] + iEng[i] + iMath[i];
                aver[i] = sum[i] / 3;

            }

            for(int i=0; i<3; i++)
            {

                Console.WriteLine($"이름 = {sum[i]}");
                Console.WriteLine($"국어 : {iKor[i]}, 영어 : {iEng[i]}, 수학 : {iMath[i]}");
                Console.WriteLine($"총점 : " + sum[i]);
                Console.WriteLine($"평균 : " + aver[i].ToString("F2"));
            }
            */

            //배열 + Length
            /*
            int[] scores = new int[3];

            scores[0] = 90;
            scores[1] = 85;
            scores[2] = 88;

            for(int i = 0; i < scores.Length; i++ ) // length = 배열의 총 갯수를 가져오기 떄문에 숫자를 셀 필요가 없다.
            {
                Console.WriteLine($"점수 {i + 1} : {scores[i]}");
            }
            */

            //소수점 출력 하는 여러가지 방식
            /*
            double value = 123.456789;

            Console.WriteLine(value.ToString("F2"));
            Console.WriteLine($"소수점 둘째 자리 : {value:F2} ");
            Console.WriteLine(String.Format("소수점 둘째 자리 : {0:F2}", value));

            // 소수점 없이 정수만 출력
            Console.WriteLine(value.ToString("F0"));
            */

            //정수 3자릿수 단위로 쉼표 찍는 법
            /*
            double value2 = 12123123142.789;
            Console.WriteLine(value2.ToString("N2")); // N자체가 3자릿수 단위로 끊어주는거고. 뒤에 숫자는 소수점 x번째까지 끊어주는거
            */

            //2차원 배열 선언
            /*
            int[,] matrix = new int[2, 3] // [y좌표, x좌표] 순서의 좌표값이라고 보면 됨
            {
                {1,2,3 }, // 한줄로 해도 되고 이건 그냥 직관적인 방법
                {4,5,6 }
            };
            */

            //이중 for문
            /*            
            for(int i=0; i<3; i++) // j를 모두 돌리면 한번 돈다. 
            {
                Console.WriteLine("i = " + i);
                for(int j = 0; j<3; j++) // j를 모두 돌고 나간다.
                {
                    Console.WriteLine("j = " + j);
                }
             }
            */

            //이중 for문 응용
            //위 2차원 배열 선언 코드 필요
            /*
            for (int i = 0; i < 2; i++) // j를 모두 돌리면 한번 돈다. 
            {
                for (int j = 0; j < 3; j++) // j를 모두 돌고 나간다.
                {
                    Console.Write($"{matrix[i,j]}");
                }
                Console.WriteLine();
            }
            */

            //이중 배열? 가변 배열? 암튼 그거 쓰고 이중 for문과 함께 사용함
            /*
            int[][] matrix = new int[2][];

            matrix[0] = new int[3];
            matrix[1] = new int[3];

            matrix[0][0] = 1;
            matrix[0][1] = 2;
            matrix[0][2] = 3;

            matrix[1][0] = 4;
            matrix[1][1] = 5;
            matrix[1][2] = 6;


            for(int i=0; i<matrix.Length; i++)
            {
                for(int j=0; j < matrix[i].Length; j++) // 이럼 코드가 돌아가면서  j<i의 i값이 증가함
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine(); // 엔터 한번 == \n
            }
            */

            //가변 배열
            /*
            Console.WriteLine("가변 배열");
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 3, 4, 5 };
            jaggedArray[2] = new int[] { 6 };

            for(int i=0; i<jaggedArray.Length; i++)// Langth를 쓰면 알아서 맞춰주기 때문에 위같은 배열도 일일이 지정할 필요가 없다.
            {
                for(int j=0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"{jaggedArray[i][j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("var 키워드 사용");
            var numbers = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine($"배열 타입 : {numbers.GetType()}"); // GetType를 쓰면 어떤 타입이든 다 찾아준다.
            */


        }
    }
}
