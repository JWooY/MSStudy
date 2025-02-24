using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 정수 <-> 진수 변환
            /*
            //이진수를 정수로 변환
            Console.Write("2진수를 입력하세요:");
            string binaryInput = Console.ReadLine(); // 문자열 입력 받기
            int decimalValue = Convert.ToInt32(binaryInput, 2); // 2진수 -> 10진수 변환

            //정수를 이진수로 변환
            string binaryOutput = Convert.ToString(decimalValue, 2); //10진수 -> 2진수

            Console.WriteLine($"입력한 이진수: {binaryInput}");
            Console.WriteLine($"10진수로 변환: {decimalValue}");

            Console.WriteLine($"다시 이진수로 변환: {binaryOutput}");
            */

            //var를 사용하여 변수 선언
            /*
            var name = "Alice"; // 문자열로 추론
            var age = 25; // 정수로 추론
            var isStudent = true; // 논리값으로 추론

            Console.WriteLine($"이름 : {name}, 나이 : {age}, 학생 여부 : {isStudent}");
            */

            //default 키워드를 사용한 기본값 설정
            /*
            int defaultInt = default; // 기본값 : 0
            string defaultString = default; // 기본값 : null
            bool defaultBool = default; // 기본값 : false

            Console.WriteLine($"정수 기본값 : {defaultInt}");
            Console.WriteLine($"문자열 기본값 : {defaultString}");
            Console.WriteLine($"논리값 기본값 : {defaultBool}");
            */

            //산술 연산자, bool 사용 
            /*
            int a = 5, b = 3;
            int sum, div, sls = 0;

            sum = a + b; // 산술 연산자 사용
            div = a / b;
            sls = a % b;

            Console.WriteLine($"합 : {sum}"); // +, -, *, /(몫), %(나머지)
            //ex
            Console.WriteLine($"몫 : {div}");
            Console.WriteLine($"나머지 : {sls}");

            // 보통 x와 2를 %로 나누어 0나오면 짝수 1나오면 홀수로 생각한다.
            
            bool isEqual = false; // 거짓 0
            int a = 5;
            int b = 5;

            //관계형 연산자
            isEqual = (a == b); // a랑 b가 같은가?

            Console.WriteLine("a와 b는 같은가? : " + isEqual); // 현재는 a와 b가 같기에, True 출력
            */


        }
    }
}
