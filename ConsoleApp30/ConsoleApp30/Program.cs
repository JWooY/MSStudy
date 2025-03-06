using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    //업캐스팅(Upcasting)
    //자식 클래스->부모클래스로 변환하는것
    //암시적 변환이 가능(컴파일러가 자동변환)
    //안전: 데이터 손실 없이 변환가능

    //다운캐스팅
    //명시적 변환이 필요 (타입)
    //불완전함 -> 실행중 IncalidCastException 발생 가능
    //as is 키어드로 안전하게 변환가능
    class Animal
    {
        public void Speak()
        {
            Console.WriteLine("동물이 소리를 냅니다.");
        }
    }
    
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("멍멍!");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //업캐스팅
            /*
            Dog myDog = new Dog(); // 자식 클래스 객체 생성
            Animal myAnimal = myDog; // 업캐스팅(Dog -> animal)

            myAnimal.Speak(); //사용 가능
            //myAnimal.Bark(); 오류. 업캐스팅 후 자식 클래스의 매서드는 접근 불가능
            */

            //다운캐스팅

            Animal myAnimal = new Dog(); // 업캐스팅
            //Dog myDog = (Dog)myAnimal; //다운 캐스팅 (명시적 변환)

            Dog myDog = myAnimal as Dog;

            myDog.Bark(); // 실행

            //Animal myAnimal2 = new Dog(); //에러.
            //Dog myDog = (Dog)myAnimal2; //에러.

            if(myDog != null)
            {
                myDog.Bark();
            }
            else
            {
                Console.WriteLine("변환 실패!");
            }

            if (myAnimal is Dog myDog1)
            {
                myDog1.Bark();
            }
            else
            {
                Console.WriteLine("변환 할 수 없습니다.");
            }


        }
    }
}
