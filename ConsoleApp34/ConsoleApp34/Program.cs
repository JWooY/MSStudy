using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    
    class Unit
    {
        //부모클래스 (기본유닛
        public string Name;
        protected int Health;

        public Unit()
        {
            Name = "Unknown";
            Health = 0;
        }

        public virtual void Attack()
        {
            Console.WriteLine($"{Name}이 기본 공격을 합니다.");
        }

        public virtual void Heal(Unit target)
        {
            Console.WriteLine($"{Name}은 치료할 수 없습니다.");
        }

        public virtual void Move()
        {
            Console.WriteLine($"{Name}이 이동합니다.");
        }
    }

    //SCV유닛 (건설과 수리 가능)
    class SCV : Unit
    {
        public SCV()
        {
            Name = "SCV";
            Health = 60;
        }

        public override void Attack()
        {
            Console.WriteLine("SCV가 용접기로 공격합니다! (공격력이 약함)");
        }
        public override void Heal(Unit target)
        {
            Console.WriteLine($"SCV가 {target.Name}을 수리합니다. (기계 유닛만 가능)");
        }

    }

    //Marine 유닛 (총기 공격)
    class Marine : Unit
    {
        public Marine()
        {
            Name = "Marine";
            Health = 40;
        }

        public override void Heal(Unit target)
        {
            Console.WriteLine($"Medic이 {target.Name}을 치료합니다. (생명유닛만가능)");
        }
    }

    //Medic 유닛 (회복 유닛)
    class Medic : Unit
    {
        public Medic()
        {
            Name = "Medic";
            Health = 50;
        }

        public override void Heal(Unit target)
        {
            Console.WriteLine($"Medic이 {target.Name}을 치료합니다. (생명 유닛 만 가능");
        }
    }

    //Tank 유닛 (강력한 공격)
    class Tank : Unit
    {
        public Tank()
        {
            Name = "Tank";
            Health = 150;
        }

        public override void Attack()
        {
            Console.WriteLine("Tank가 시즈 모드로 강력한 포격!");
        }
        public override void Move()
        {
            Console.WriteLine("Tank가 천천히 움직입니다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Unit> units = new List<Unit>(); // List 활용해서 유닛 하나로 통합해서 불러오기
            //Unit units = new SCV(); // 원래는 이렇게 하나하나 불러와야함. 백그라운드에서 돌아는 가고 있고, 이 절차를 간소화 시킴

            units.Add(new SCV()); //하나하나 안불러와도 이렇게 출력가능
            units.Add(new Marine());
            units.Add(new Medic());
            units.Add(new Tank());

            //모든 유닛을 순회하며 다형성 적용
            foreach(var unit in units)
            {
                unit.Move(); // 모든 유닛 이동 (존재하는 경우만)
                unit.Attack(); // 모든 유닛 공격 (존재하는 경우만)
                Console.WriteLine();
            }

            //SCV가 탱크 수리 시도
            SCV scv = new SCV(); // SCV 불러오기
            scv.Heal(units[3]); // 탱크 수리

            //Medic이 Marine 치료 시도
            Medic medic = new Medic();
            medic.Heal(units[1]);

        }
    }
}
