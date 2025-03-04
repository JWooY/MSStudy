using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{

    // get/set 방식의 함수
    class Person
    {
        private string name; //내부 변수

        //값 설정하기 (Setter)
        public void SetName(string newName)
        {
            name = newName;
        }

        //값 가져오기 (Getter)
        public string GetName()
        {
            return name;
        }

    }

    //C# 프로퍼티 property 
    class Person2
    {
        private string name; //내부 변수
        public string Name //프로퍼티
        {
            get { return name; }
            set { name = value; }
        }
    }

    //자동 구현 프로퍼티
    class Person3
    {
        private int count = 100;
        public string Name { get; set; } //자동 구현 프로퍼티
        public int Count
        {
            get { return count; } //읽기만 가능. 값을 넣을 수 없음. 그럼 왜 필요한겨;
        }

        public float Balance
        {
           get;  
           private set;  // 외부 변경 불가능
        }

        public void AddBal()
        {
            Balance += 100;
        }


    }

    class Marin
    {
        public string Name { get; private set; } = "마린";
        public int Mineral { get; set; } = 100;
    }


    class Program
    {
        static void Main(string[] args)
        {
            //C#에서 get/set 방식의 함수와 프로퍼티 비교
            //C#에서는 객체의 값을 읽고(get), 설정(set)하는
            //방식으로 함수(get/set 메서드) 또는
            //**프로퍼티(Property)**를 사용할 수 있습니다.

            // get/set 방식의 함수
            /*
            Person p = new Person();

            p.SetName("홍길동");


            Console.WriteLine("이름 : " + p.GetName());
            */

            //C# 프로퍼티 property 방식
            /*
            Person2 p = new Person2();

            p.Name = "홍길동";

            Console.WriteLine("이름 : " + p.Name);
            */

            //자동 구현 프로퍼티
            /*
            Person3 p = new Person3();

            p.Name = "홍길동";
            p.AddBal();
            // p.Balance = 100; // 당연히 에러남. 외부에서 변경 불가능 하기 떄문.
            Console.WriteLine("이름 : " + p.Name+" Count : "+p.Count+" Balance : "+p.Balance);
            */

            //마린 프로퍼티로 만들기
            //자질구레한거 신경쓰지말고 간단하게 생각해.
            Marin marin = new Marin();

            Console.WriteLine("이름 : " + marin.Name + " 미네랄 : " + marin.Mineral);







        }
    }
}