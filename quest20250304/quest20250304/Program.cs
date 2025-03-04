using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace quest20250304
{
    //1번 문제 클래스
    /*
    public class Warrior
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }
    public class WarriorStr : Warrior
    {
        public int Strength { get; set; }
    }

    */



    class Program
    {
        static void Main(string[] args)
        {

            //실습 문제(쉬운 난이도)
            //1. 클래스와 상속
            //Warrior 클래스를 만들고 Name과 Score 속성을 추가하세요.
            //Warrior Strength 속성을 추가하세요.
            //Main 메서드에서 Warrior 객체를 생성하고, Name, Score, Strength 값을 설정한 후 출력하세요.
            /*
            WarriorStr warrior = new WarriorStr
            {
                Name = "James",
                Score = 100,
                Strength = 10
            };

            Console.WriteLine($"Name: {warrior.Name}");
            Console.WriteLine($"Score: {warrior.Score}");
            Console.WriteLine($"Strength: {warrior.Strength}");
            */


            //2. 예외 처리
            //사용자에게 정수를 입력받고, 이를 int로 변환하는 프로그램을 작성하세요.
            //숫자로 변환할 수 없는 경우 FormatException을 처리하여 "올바른 숫자를 입력하세요!"라는 메시지를 출력하세요.
            //변환이 성공하면 입력한 숫자를 출력하세요.
            /*
            Console.Write("숫자를 입력하세요 : ");
            string Input = string.Concat(Console.ReadLine());
            try
            {
                int num = int.Parse(Input);
                Console.WriteLine($"숫자 : {num}");

            }
            catch (FormatException)
            {
                Console.WriteLine("올바른 숫자를 입력하세요!");
            }
            */

            //3. 컬렉션(List, Queue, Stack) 활용
            //List<string> 을 생성하고 "사과", "바나나", "포도"를 추가하세요.
            //Queue<string> 을 생성하고 "첫 번째 작업", "두 번째 작업", "세 번째 작업"을 추가하세요.
            //Stack<int> 을 생성하고 10, 20, 30을 추가한 뒤 하나씩 출력하세요.
            /*
            List<string> Fruits = new List<string> { "사과", "바나나", "포도" };

            Queue<string> Works = new Queue<string>();
            Works.Enqueue("첫 번째 작업");
            Works.Enqueue("두 번째 작업");
            Works.Enqueue("세 번째 작업");

            Stack<int> Num = new Stack<int>();
            Num.Push(10);
            Num.Push(20);
            Num.Push(30);


            foreach (string i in Fruits)
            {
                Console.WriteLine(i);
            }

            while (Works.Count > 0)
            {
                Console.WriteLine(Works.Dequeue());
            }
            while (Num.Count > 0)
            {
                Console.WriteLine(Num.Pop()); 
            }
            */

            //4. 문자열 처리
            //사용자로부터 "Hello, C# World!" 같은 문자열을 입력받아, 다음을 수행하세요.
            //전체 문자열을 대문자로 변환
            //"C#"을 "CSharp"으로 변경
            //문자열의 길이 출력
            /*
            Console.Write("문자열을 입력하세요 : ");
            string Str = Console.ReadLine();


            Console.WriteLine($"대문자로 변환 : {Str.ToUpper()}");

            Console.WriteLine($"# -> Sharp 변환 : {Str.Replace("#","Sharp")}");

            Console.WriteLine($"문자열의 길이 : {Str.Length}");
            */

            //5. LINQ 활용
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; 배열이 주어질 때,
            //LINQ를 사용하여 짝수만 필터링하고 출력하세요.
            //LINQ를 사용하여 모든 숫자의 합을 구하고 출력하세요.
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var TwiceNumbers = numbers.Where(n => n % 2 == 0);
            var SumNumbers = numbers.Sum();

            foreach (var num in TwiceNumbers)
            {
                Console.WriteLine("짝수 출력 : " + num );
            }
            
            Console.Write("\n모든 숫자의 합 : "+SumNumbers);
            
            
        }

    }
    
}
