using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp20
{
    //클래스와 기본 생성자, 매개변수 생성자
    class Person
    {
        public string Name;
        public int Age;

        //기본생성자 
        //클래스가 객체로 생성될때 자동으로 실행되는 특별한 메서드
        //클래스와 같은이름가지며, 반환형이 없다 (void도 사용하지않음)
        //객체를 만들때 필요한 초기값을 설정할대 사용많이한다.

        //1. 기본 생성자
        /*
        public Person()
        {
            Name = "이름 없음";
            Age = 0;
            Console.WriteLine("기본 생성자가 실행됨");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 나이 : {Age}");
        }
        */

        //매개변수가 있는 생성자
        /*
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("매개변수있는 생성자가 실행됨");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 나이 : {Age}");
        }
        */

        //마린 클래스를 만드세요
        //이름, 미네랄
        //기본생성자, 인자 있는 생성자

    }

    //클래스와 기본 생성자, 매개변수 생성자
    //스타크래프트 유닛 및 건물 클래스 만들기
    //마린
    class Marin
    {
        public string Name;
        public int Mineral;
        public Marin()
        {
            Name = "마린";
            Mineral = 50;
        }
        public Marin(string _name, int _mineral)
        {
            Name = _name;
            Mineral = _mineral;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
        }

    }

    //SCV
    class SCV
    {
        public string Name;
        public int Mineral;
        public SCV()
        {
            Name = "SCV";
            Mineral = 50;
        }

        
        public SCV(string _name, int _mineral)
        {
            Name = _name;
            Mineral = _mineral;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
        }

        //배력
        class Marin
        {
            public string Name;
            public int Mineral;
            public Marin()
            {
                Name = "마린";
                Mineral = 50;
            }
            public Marin(string _name, int _mineral)
            {
                Name = _name;
                Mineral = _mineral;
            }
            public void ShowInfo()
            {
                Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
            }

        }


    }

    //배력
    class Barrack
    {
        public string Name;
        public int Mineral;
        public Barrack()
        {
            Name = "배럭";
            Mineral = 150;
        }
        public Barrack(string _name, int _mineral)
        {
            Name = _name;
            Mineral = _mineral;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
        }

    }

    //this 포인터를 이용한 배럭 생성
    //this 포인터 쓰면 같은거 쓸 수 있음. 근데 왜 쓰는거지
    class Barrack2
    {
        public string Name;
        public int Mineral;
        public Barrack2()
        {
            Name = "배럭";
            Mineral = 150;
        }
        public Barrack2(string Name, int Mineral)
        {
            this.Name = Name;
            this.Mineral = Mineral;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
        }

    }

    //미네랄 클래스를 만드시오
    //미네랄 기본 1500
    //7개가 기본으로 있습니다.
    class Mineral
    {
        public int MineralCount;

        public Mineral()
        {
            MineralCount = 1500;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"현재 미네랄 갯수 : {MineralCount}");
        }
    }

    //Game 클래스를 만들어보자
    class Game
    {
        public static int mineral;
        public static int gas;
        public static int CharCount;

        public static void ShowInfo()
        {
            Console.WriteLine($"미네랄 {mineral} 가스 {gas} 인구수 {CharCount}");
        }


    }



    class Program
    {
        static void Main(string[] args)
        {
            //클래스
            //1. 기본 생성자
            /*
            Person p1 = new Person(); //객체 생성  instance 
            p1.ShowInfo();
            */

            //2. 매개변수가 있는 생성자
            /*
            Person p1 = new Person("철수", 25); //객체 생성  instance 
            p1.ShowInfo();

            Person p2 = new Person("영희", 30);
            p2.ShowInfo();
            */

            //3. 응용) 스타크래프트 마린 생성
            /*
            //Marin marin = new Marin();
            //SCV scv = new SCV();

            //이렇게 변경도 가능
            Marin marin = new Marin("불꽃마린", 80); 
            SCV scv = new SCV("불꽃SCV", 80);
            
            marin.ShowInfo();
            scv.ShowInfo();
            */


            //배력 클래스 생성
            /*
            Barrack barrack = new Barrack();

            barrack.ShowInfo();

            //this 포인터를 이용한 배럭 생성
            Barrack2 barrack2 = new Barrack2(); // 여기다 위에 마린이나 SCV 처럼 값 변경도 가능
            
            barrack2.ShowInfo();
            */


            //미네랄 클래스
            // 클래스의 배열 7개 생성
            Mineral[] mineral = new Mineral[7]; // 배열을 이용해서 미네랄 데이터가 들어갈 공간 만들기

            // 각 배열에 new 객체화
            for(int i=0; i<mineral.Length; i++)
            {
                mineral[i] = new Mineral(); // 이럼 미네랄 7개 생성
                mineral[i].ShowInfo();
            }
            Game.mineral = 50;
            Game.gas = 0;
            Game.CharCount = 4;
            Game.ShowInfo();
        }
    }
}