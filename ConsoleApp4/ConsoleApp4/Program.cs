using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write , Writeline 차이
            /*
            int intergerNum = 10;
            float floatNum = 3.14f; // f는 대충 요정도다
            double doubleNum = 3.14159; //정밀하게 적기

            Console.Write(intergerNum); // 값 따닥따닥 붙여서 출력
            Console.Write(floatNum);
            Console.Write(doubleNum);

            Console.WriteLine(intergerNum); //WriteLine은 한칸 들여쓰기 됨
            Console.WriteLine(floatNum);
            Console.WriteLine(doubleNum);
            */

            //정수 데이터형식 : 소수점이 없는 숫자를 표현함
            /*
            int intValue = -100; // 4바이트 크기의 정수
            long longValue = 1234567890L; // 8바이트 크기의 정수

            Console.WriteLine(intValue); // 출력 : -100
            Console.WriteLine(longValue); // 출력 : 123456789
            */

            //부호있는 정수 : 음/양수 모두 표현 가능
            /*
            sbyte signedByte = -50; // 1바이트 크기
            short signedShort = -32000; // 2바이트 크기
            int signedInt = -200000000; // 4바이트 크기

            Console.WriteLine(signedByte);
            Console.WriteLine(signedShort);
            Console.WriteLine(signedInt);
            */

            //부호 없는 정수 데이터 형식
            /*
            // 양수만 되고 음수는 못적음. 메모리 이득
            byte unsignedByte = 255; // 1바이트 크기
            ushort unsignedShort = 65000; // 2바이트 크기
            uint unsignedInt = 400000000; // 4바이트 크기

            Console.WriteLine(unsignedByte);
            Console.WriteLine(unsignedShort);
            Console.WriteLine(unsignedInt);
            */

            //실수형 데이터 형식 : 소수점을 포함한 숫자를 표현
            /*
            float singlePrecision = 3.14f; // 단정밀도 실수
            double doublePrecision = 3.145926535; // 배정밀도 실수 (8바이트)
            decimal highPrecision = 3.14159265358979123123m; // 고정밀도 (16바이트)

            Console.WriteLine(singlePrecision);
            Console.WriteLine(doublePrecision);
            Console.WriteLine(highPrecision);
            */

            //숫자 형식의 리터럴 값에 접미사 붙이기
            /*
            int integerValue = 100;     // 기본 정수형 (int)
            long longValue = 100L;      // 정수형 (long)
            float floatValue = 3.14f;   // 실수형 (float)
            double doubleValue = 3.14;  // 기본 실수형 (double)
            decimal decimalValue = 3.14m; // 고정밀도 실수형 (decimal)

            Console.WriteLine(integerValue);
            Console.WriteLine(longValue);
            Console.WriteLine(floatValue);
            Console.WriteLine(doubleValue);
            Console.WriteLine(decimalValue);
            */

            //char형식 : 단일 문자를 표현
            /*
            char letter = 'A'; // 문자 'A' 저장
            char symbol = '#'; // 특수 기호 저장
            char number = '9'; // 숫자 형태의 문자 저장 (문자 '9', 숫자 9 아님)

            Console.WriteLine(letter);
            Console.WriteLine(symbol);
            Console.WriteLine(number);
            */

            //string형식 : 여러 문자를 저장
            /*
            string greeting = "Hello World"; //문자열 저장
            string name = "Alice"; // 이름 저장

            Console.WriteLine(greeting);
            Console.WriteLine(name);
            Console.WriteLine(greeting +" "+ name);
            */

            //bool형식 : 참(true) = 1 / 거짓(false) = 0
            /*
            bool isRunning = true; // 프로그램 실행 상태
            bool isFinished = false; // 프로그램 종료 상태

            Console.WriteLine(isRunning);
            Console.WriteLine(isFinished);
            */

            //닷넷 형식 : 기본형식의 닷넷 표현
            /*
            System.Int32 number = 123;
            System.String text = "Hello";
            System.Boolean flag = true;

            Console.WriteLine(number);
            Console.WriteLine(text);
            Console.WriteLine(flag);
            */

            //int 래퍼 형식의 매서드 활용
            //int를 string으로 변환
            int number = 123;
            string numberAsString = number.ToString(); // 정수를 문자열로 변환함

            //bool 래퍼형식
            bool flag = true;
            string flagAsString = flag.ToString(); // 논리값을 문자열로 변환함

            Console.WriteLine(numberAsString);
            Console.WriteLine(flagAsString);
        }
    }
}
