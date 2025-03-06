using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace quest20250305
{

    class Unit
    {
        //부모클래스 (기본유닛)
        public string Name;
        public int Health;
        public int Mana;
        public int AttackDamage;
        public int Armor;
        public double AttackSpeed;
        public int AbilityPower;
        public int MagicResistance;

        public bool IsBuffActive = false; //스킬 ON/OFF용.
        public int Cooldown; // 재사용 대기 시간(밀리초)
        public int LastUsedTime; // 마지막 사용 시간 (TickCount 기준)


        public Unit()
        {
            Name = "Unknown";
            Health = 0;
            AttackDamage = 0;
            Armor = 0;
            AttackSpeed = 0.000;
            AbilityPower = 0;
            MagicResistance = 0;

        }

        public virtual void Attack()
        {
            Console.WriteLine($"{Name}의 기본공격!");
        }
        public virtual void AttackQ(Unit target) { }
        public virtual void AttackW(Unit target) { }
        public virtual void AttackE(Unit target) { }
        public virtual void AttackR(Unit target) { }
        public virtual void Move()
        {
            Console.WriteLine($"{Name}이 이동합니다.");
        }
    }
    class Skill
    {
        public string SkillName; // 스킬 이름
        public int ManaCost; // 마나 소모량
        public int Cooldown; // 재사용 대기 시간(밀리초)
        public int LastUsedTime; // 마지막 사용 시간 (TickCount 기준)

        public Skill(string name, int manaCost, int cooldown)
        {
            SkillName = name;
            ManaCost = manaCost;
            Cooldown = cooldown * 1000; // 초를 밀리초로 변환
            LastUsedTime = 0; // 처음엔 사용하지 않은 상태
        }

        //스킬 사용 가능 여부 확인
        public bool CanUse(int playerMana)
        {
            int currentTime = Environment.TickCount;

            if (playerMana < ManaCost)
            {
                Console.WriteLine($"마나가 부족합니다! (필요 MP : {ManaCost})");
                return false;
            }

            if (currentTime - LastUsedTime < Cooldown)
            {
                int remainingTime = (Cooldown - (currentTime - LastUsedTime)) / 1000;
                Console.WriteLine($"{SkillName} 스킬은 아직 사용할 수 없습니다.(남은 시간 : {remainingTime}초");
                return false;
            }
            return true;
        
        }

    }

    // 가렌
    class Garen : Unit
    {
        private Skill Q;
        private Skill W;
        private Skill E;
        private Skill R;

        public Garen()
        {
            Name = "Garen";
            Health = 690;
            AttackDamage = 69;
            AttackSpeed = 0.625;
            Armor = 38;
            Mana = 0;
            MagicResistance = 32;

            Q = new Skill("결정타", 0, 8);
            W = new Skill("용기", 0, 23);
            E = new Skill("심판", 0, 9);
            R = new Skill("데마시아의 정의", 0, 120);
        }

        public override void Attack()
        {
            Console.WriteLine($"가렌 : 악행과 싸워라!");
        }
        public override void AttackQ(Unit target)
        {
            Console.WriteLine($"가렌 : 전진! (기본 공격 강화)");
            AttackDamage += 30;
        }
        public override void AttackW(Unit target)
        {
            IsBuffActive = true;
            Console.WriteLine($"가렌 : 확고한 의지로! (방/마저 상승)");
            LastUsedTime = Environment.TickCount;
            Armor += Armor/1;
            MagicResistance += MagicResistance/10;
            
            IsBuffActive = false;


        }
        public override void AttackE(Unit target)
        {
            Console.WriteLine($"가렌 : 눈도 깜짝 안한다! (물리 피해)");
        }
        public override void AttackR(Unit target)
        {
            Console.WriteLine($"가렌 : 정의를 위해! (막대한 물리 피해 및 고정 피해)");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Unit> units = new List<Unit>(); // List 활용해서 유닛 하나로 통합해서 불러오기

            units.Add(new Garen());

            int playerMana = units[0](Mana)

            //스킬 목록 (배열 사용)
            Skill[] skills = new Skill[]
            {
                Garen
            };

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"현재 MP : {playerMana}");
                Console.WriteLine("사용 가능한 스킬");
                for (int i = 0; i < skills.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {skills[i].Name} (MP{skills[i].ManaCost} " +
                        $", 쿨다운 {skills[i].Cooldown / 1000}s)");
                }
                Console.WriteLine("0. 종료");
                Console.Write("사용할 스킬 번호를 입력하세요 : ");

                try
                {
                    int skillIndex = int.Parse(Console.ReadLine());

                    if (skillIndex == 0) break;

                    if (skillIndex > 0 && skillIndex <= skills.Length)
                    {
                        skills[skillIndex - 1].Use(ref playerMana);
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다.");
                    }
                }
                catch
                {
                    Console.WriteLine("숫자를 입력하세요!");
                }

                Thread.Sleep(500); // CPU과부화 방지

            }
            Console.WriteLine("게임 종료");


        }
    }
}