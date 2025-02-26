using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace 콘솔좌표
{
    class Program
    {
        static void Main(string[] args)
        {
            //콘솔 창 크기 설정
            Console.SetWindowSize(80, 25); // x = 80, y = 25

            //콘솔 버퍼 크기도 설정 (스크롤 없이 고정된 창 유지)
            Console.SetBufferSize(80, 25);

            Console.CursorVisible = false; // 실행시 마우스 커서 숨기기

            //예시 타이틀
            /*
            Console.Clear(); // 화면 지우기
            Console.SetCursorPosition(40, 12);
            Console.Write("대장장이 키우기");
            Thread.Sleep(1000);
            */

            Console.Clear(); // 화면 지우기
            Console.SetCursorPosition(0, 0); //좌표는 지정해놓으면 그 위치로 무조건 강제함
            Console.Write("□□□■■■■■■■□□□□□□■□□□□■□□□□□□□□□□□□□□□■□□□□■■■■■■■□□□□□□□□□□□□■");
            Console.SetCursorPosition(0, 1);
            Console.Write("□□■■■□□□■■■□□□□□■□□□□■□□□□□□■■■■■■□□□■□□□■■■□□□■■■□□■■■■■■□□□■");
            Console.SetCursorPosition(0, 2);
            Console.Write("□□■■□□□□□■■□□□□□■□□□□■□□□□□□□□□□□■□□□■□□□■■□□□□□■■□□□□□□□■□□□■");
            Console.SetCursorPosition(0, 3);
            Console.Write("□□■■■■■■■■□□□□□□■□□□□■□□□□□□□□□□□■□□□■□□□■■□□□□□■■□□□□□□■■□□□■");
            Console.SetCursorPosition(0, 4);
            Console.Write("□□□□■■■■■□□□□□□■■□□□□■■■■□□□■■■■■■□□□■□□□■■■■■■■■□□□□□□□■■□□□■");
            Console.SetCursorPosition(0, 5);
            Console.Write("□□□□■□□□■□□□□□□■■■□□□■■■■□□□□□□□■■□□□■□□□□■■■■■■□□□□□□□□■■□□□■");
            Console.SetCursorPosition(0, 6);
            Console.Write("■■■■■■■■■■■■□□■■■■■□□■□□□□□□□□□■■■□□□■□□□□□□□□□□□□□□□□□■■□□□□■");
            Console.SetCursorPosition(0, 7);
            Console.Write("□□□■■■■■■■□□□■■□□■■■□■□□□□□□□□■■■□□□□■□■■■■■■■■■■■■□□■■■□□□□□■");
            Console.SetCursorPosition(0, 8);
            Console.Write("□□■■■■■■■■□□■■□□□□■■□■□□□□□□■■■□□□□□□■□□□□□□□■□□□□□□■■■□□□□□□■");
            Console.SetCursorPosition(0, 9);
            Console.Write("□□■■□□□□□■■□□□□□□□□□□■□□□□□□■□□□□□□□□■□□□□□□□■□□□□□□■□□□□□□□□■");
            Console.SetCursorPosition(0, 10);
            Console.Write("□□■■■□□□■■■□□□□□□□□□□■□□□□□□□□□□□□□□□■□□□□□□□■□□□□□□□□□□□□□□□■");
            Console.SetCursorPosition(0, 11);
            Console.WriteLine("□□□■■■■■■■□□□□□□□□□□□■□□□□□□□□□□□□□□□■□□□□□□□■□□□□□□□□□□□□□□□■");
/*            for (int x = 0; x < 64; x++) //0 ~ 63 이동, 로딩 바
            {
                Console.SetCursorPosition(x, 19);
                Console.WriteLine("●◎");
                Thread.Sleep(100);
            }*/
            Console.WriteLine("PRESS⏎ TO PLAY");
            Console.ReadLine();

            //Thread.Sleep(3000);
            Console.Clear(); // 3초 뒤 타이틀 삭제

            Console.OutputEncoding = System.Text.Encoding.UTF8; // 이모티콘 적용 시키는 코드

            // 게임 시작
            Random rand = new Random();

            int gold = 10000;
            int health = 100;
            int maxHealth = 100;
            int mp = 100;
            int maxMp = 100;
            int power = 10;
            int fame = 1;
            int input;

            string equippedWeapon = "없음"; // 현재 장착한 무기
            string equippedArmor = "없음"; // 현재 장착한 갑옷

            string NewWeapon = "없음"; // 뽑은 무기
            string NewArmor = "없음"; // 뽑은 갑옷

            // 무기 스탯
            int GetWeaponPower(string weapon)
            {
                switch (weapon)
                {
                    case "SSS급 전설의 성검": return 200;
                    case "SS급 타락한 마검": return 100;
                    case "S급 서리검": return 50;
                    case "A급 기사단장의 검": return 30;
                    case "B급 질 좋은 철검": return 20;
                    case "C급 단단한 검": return 15;
                    case "D급 평범한 검": return 10;
                    case "F급 녹슨 철검": return 5;
                    default: return 0;
                }
            }

            // 갑옷 스탯
            int GetArmorHealth(string armor)
            {
                switch (armor)
                {
                    case "SSS급 신위의 갑주": return 500;
                    case "SS급 어둠의 전신 갑주": return 300;
                    case "S급 빛의 수호 갑옷": return 200;
                    case "A급 용사의 갑옷": return 120;
                    case "B급 튼튼한 전투복": return 80;
                    case "C급 질긴 가죽 갑옷": return 50;
                    case "D급 낡은 사슬 갑옷": return 30;
                    case "F급 해진 천옷": return 15;
                    default: return 0;
                }
            }

            int normalMob;

            string mytitle = "인지도 없는 신출내기 용사"; // 첫 칭호, 이후 확장

            bool isAlive = true;

            while (isAlive)
            {
                Console.Clear();
                Console.WriteLine("┌─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"    스테이터스  |   체력 {maxHealth}/{health} | 마나 {mp} | 공격력 {power}");
                Console.WriteLine("├─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"    현재 상태   |   골드 {gold} | 명성 {fame}");
                Console.WriteLine("├─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"    나의 장비   |   {equippedWeapon} | {equippedArmor}" );
                Console.WriteLine("├─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"      칭호      |   {mytitle}");
                Console.WriteLine("└─────────────────────────────────────────────────────────────────┘");
                // Console.WriteLine($"현재 의뢰 : 없음 "); // 추후 구현

                Console.WriteLine("\n1. 탐험하기 🏕️");
                Console.WriteLine("2. 장비뽑기 🎲 (1000골드)");
                Console.WriteLine("3. 휴식하기 🌿 ( 체력 / 마나 + 20  |  -100골드 )");
                Console.WriteLine("4. 게임 종료");
                Console.Write("입력 : ");

                input = int.Parse(Console.ReadLine());

                if (input == 1) //탐험하기
                {
                    Console.Clear();
                    Console.WriteLine("탐험을 떠납니다...");
                    Thread.Sleep(500);
                    Console.WriteLine("탐험을 떠납니다...");
                    Thread.Sleep(500);
                    Console.WriteLine("탐험을 떠납니다...\n");
                    Thread.Sleep(500);

                    int eventChance = rand.Next(1, 101); // 1~100 랜덤 이벤트 발생

                    if (eventChance <= 30) // 30%, 전투 이벤트
                    {
                        int sltMob = rand.Next(0, 3);
                        if (sltMob == 0)
                        {

                        }

                        Console.WriteLine(" ⚔️ 몬스터를 만났습니다! ⚔️ ");
                        Thread.Sleep(1500);
                        Console.Clear();
                        Console.WriteLine("▶ 개체 : 슬라임 (체력 : 30 | 공격력 : 5)\n");
                        Thread.Sleep(1000);
                        Console.WriteLine("▶ 무엇을 할까?");
                        Console.WriteLine("─────────────────────────────────────────────");
                        Console.WriteLine("▶ 1. 싸운다 | 2. 도망간다");
                        Console.WriteLine("─────────────────────────────────────────────");
                        Console.Write("▶ 입력 : ");
                        input = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (input == 1)
                        {
                            Console.WriteLine("▶ 전투 시작!");
                            
                        }

                        else if (input == 2)
                        {
                            Console.WriteLine("▶ 전속력으로 도망쳤다!");
                        }

                        else
                        {
                            Console.WriteLine("▶ 잘 못 입력하셨습니다.");
                        }
                        //health -= damage;

                    } // 30%, 전투 이벤트
                    else if (eventChance <= 50) // 20%, 아이템 획득 이벤트
                    {
                        int getItem = rand.Next(1, 101); // 아이템 획득 확률
                        if (getItem == 1)
                        {
                            Console.WriteLine("▶ 멀리 보이는 절벽 틈새가 빛나고 있는걸 보았다.");
                            Thread.Sleep(800);
                            Console.WriteLine("...");
                            Thread.Sleep(800);
                            Console.WriteLine("...");
                            Thread.Sleep(800);
                            Console.WriteLine("...");
                            Thread.Sleep(800);
                            Console.WriteLine("▶ 절벽 틈새로 들어가니 숨겨진 공간이 드러났다. (enter로 진행)");
                            Console.ReadLine();
                            Console.WriteLine("▶ 거대한 동공 내부에는 거대한 석상들이 서있었다. ");
                            Console.ReadLine();
                            Console.WriteLine("▶ 무식하게 커다란 크기와는 다르게 정교하게 조각된 석상들은, 마치 왕을 섬기든 한곳을 향해 무릎을 꿇고 있었다.");
                            Console.ReadLine();
                            Console.WriteLine("▶ 동공 중앙에 왕 처럼 보이는 석상 앞으로 다가가니 석상 가슴 부분에 칼이 꽂혀있는걸 보았다. ");
                            Console.ReadLine();
                            Console.WriteLine("▶ 가슴에 칼이 찔린것과는 다르게 석상의 얼굴은 기뻐보였다. ");
                            Console.ReadLine();
                            Console.WriteLine("▶ 석상 가슴부분을 자세히 살펴보니 자그마한 고대 문자가 써져 있었다. ");
                            Console.ReadLine();
                            Console.WriteLine("▶  - 이번에도, 똑같구나 - ");
                            Console.ReadLine();
                            Console.WriteLine("▶ 칠흑같은 문자와 비례하듯 검에서 불길한 기운이 솟구쳐 오르기 시작한다. ");
                            Console.ReadLine();
                            Console.WriteLine("▶ 나는 무언가에 홀린듯 석상으로 다가가 그 무기를 뽑아들었다. ");
                            Console.ReadLine();
                            Console.WriteLine("▶ 알 수 없는 힘이 흘러들어온다... ");
                            Console.ReadLine();
                            Console.WriteLine("▶ 이런 말도 안되는 행운이! SS급 장비 타락한 마검을 획득하셨습니다! ");
                            Console.ReadLine();
                            NewWeapon = "SS급 타락한 마검";
                            if (equippedWeapon != NewWeapon)
                            {
                                Console.WriteLine("\n장비를 교체하시겠습니까?");
                                Console.WriteLine("1. 예 | 2. 아니요");
                                Console.Write("입력: ");
                                int choice = int.Parse(Console.ReadLine());

                                if (choice == 1)
                                {
                                    // 장비 교체
                                    power -= GetWeaponPower(equippedWeapon); // 기존 무기 공격력 제거
                                    equippedWeapon = "SS급 타락한 마검";
                                    NewWeapon = equippedWeapon;
                                    power += GetWeaponPower(NewWeapon);
                                    Console.WriteLine($"{equippedWeapon}으로 장비가 교체되었습니다!");
                                    Thread.Sleep(1000);
                                }
                                else if (choice == 2)
                                {
                                    Console.WriteLine("기운을 거부할 수 없습니다.");
                                    Thread.Sleep(800);
                                    power -= GetWeaponPower(equippedWeapon); // 기존 무기 공격력 제거
                                    equippedWeapon = "SS급 타락한 마검";
                                    NewWeapon = equippedWeapon;
                                    power += GetWeaponPower(NewWeapon);
                                    Console.WriteLine($"{equippedWeapon}으로 장비가 교체되었습니다!");
                                    Thread.Sleep(1000);
                                }
                            }
                            else
                            {
                                power -= GetWeaponPower(equippedWeapon); // 기존 무기 공격력 제거
                                equippedWeapon = "SS급 타락한 마검";
                                NewWeapon = equippedWeapon;
                                power += GetWeaponPower(NewWeapon);
                                Console.WriteLine($"{equippedWeapon} 장비를 착용하였습니다!");
                                Thread.Sleep(800);
                                Console.WriteLine("(업은 또다시 반복된다...)");
                                Thread.Sleep(1000);
                            }

                        } // SS 타락한 마검 획득. 추후 SSS급 무기 획득시 무기 변경 가능하도록 수정
                        else if (getItem == 2)
                        {
                            Console.WriteLine("▶ 멀리 보이는 절벽 틈새가 빛나고 있는걸 보았다.");
                            Thread.Sleep(800);
                            Console.WriteLine("...");
                            Thread.Sleep(800);
                            Console.WriteLine("...");
                            Thread.Sleep(800);
                            Console.WriteLine("...");
                            Thread.Sleep(800);
                            Console.WriteLine("▶ 절벽 틈새로 들어가니 숨겨진 공간이 드러났다. (enter로 진행)");
                            Console.ReadLine();
                            Console.WriteLine("▶ 거대한 동공 내부에는 거대한 석상들이 서있었다. ");
                            Console.ReadLine();
                            Console.WriteLine("▶ 무식하게 커다란 크기와는 다르게 정교하게 조각된 석상들은, 마치 왕을 섬기든 한곳을 향해 무릎을 꿇고 있었다.");
                            Console.ReadLine();
                            Console.WriteLine("▶ 동공 중앙에 왕 처럼 보이는 석상 앞으로 다가가니 석상은 칠흑같이 어두운 갑주를 입고 있었다. ");
                            Console.ReadLine();
                            Console.WriteLine("▶ 근처에 있기만 해도 털이 쭈뼛 서는 사악한 기운이 나를 스쳐 지나가는 듯한 느낌이 든다. ");
                            Console.ReadLine();
                            Console.WriteLine("▶ 무언가에 홀린듯 갑옷에 다가가자, 멀리서는 보이지 않던 글자가 보인다. ");
                            Console.ReadLine();
                            Console.WriteLine("▶  - 또다시, 반복되리라 - ");
                            Console.ReadLine();
                            Console.WriteLine("▶ 갑작스럽게 갑주에서 불길한 기운이 솟구쳐 오르기 시작한다. ");
                            Console.ReadLine();
                            Console.WriteLine("▶ 그 어두운 기운들이 내 몸속을 헤집기 시작한다... ");
                            Console.ReadLine();
                            Console.WriteLine("▶ 알 수 없는 힘이 흘러들어온다... ");
                            Console.ReadLine();
                            Console.WriteLine("▶ 이런 말도 안되는 행운이! SS급 장비 어둠의 전신 값주를 획득하셨습니다! ");
                            Console.ReadLine();
                            if (equippedArmor != NewArmor)
                            {
                                Console.WriteLine("\n장비를 교체하시겠습니까?");
                                Console.WriteLine("1. 예 | 2. 아니요");
                                Console.Write("입력: ");
                                int choice = int.Parse(Console.ReadLine());

                                if (choice == 1)
                                {
                                    // 장비 교체
                                    maxHealth -= GetArmorHealth(equippedArmor); // 기존 무기 공격력 제거
                                    equippedArmor = "SS급 어둠의 전신 갑주";
                                    NewArmor = equippedArmor;
                                    maxHealth += GetArmorHealth(NewArmor);
                                    Console.WriteLine($"{equippedArmor} 장비를 착용하였습니다!");
                                }
                                else if (choice == 2)
                                {
                                    Console.WriteLine("기운을 거부할 수 없습니다.");
                                    power -= GetWeaponPower(equippedWeapon); // 기존 무기 공격력 제거
                                    equippedWeapon = "SS급 어둠의 전신 값주";
                                    NewWeapon = equippedWeapon;
                                    power += GetWeaponPower(NewWeapon);
                                    Console.WriteLine($"{equippedWeapon}으로 장비가 교체되었습니다!");
                                }
                            }
                            else
                            {
                                maxHealth -= GetArmorHealth(equippedArmor); // 기존 무기 공격력 제거
                                equippedArmor = "SS급 어둠의 전신 갑주";
                                NewArmor = equippedArmor;
                                maxHealth += GetArmorHealth(NewArmor);
                                Console.WriteLine($"{equippedArmor} 장비를 착용하였습니다!");
                                Console.WriteLine("▶ (어둠을 받아들여라...)");
                            }
                        } // SS 어둠의 전신 갑주 획득.
                        else if (getItem <= 6)
                        {
                            NewWeapon = "A급 기사단장의 검";
                            Console.WriteLine("▶ 강가를 뒤져보다 강 바닥에 빛나는 무언가를 보았다.");
                            Console.WriteLine("▶ ...");
                            Thread.Sleep(800);
                            Console.WriteLine("▶ ...");
                            Thread.Sleep(800);
                            Console.WriteLine("▶ ...");
                            Thread.Sleep(800);
                            Console.WriteLine("▶ 맙소사! A급 장비 기사단장의 검을 획득하셨습니다!");
                            if (equippedWeapon != NewWeapon)
                            {
                                Console.WriteLine("\n▶ 장비를 교체하시겠습니까?");
                                Console.WriteLine("1. 예");
                                Console.WriteLine("2. 아니요");
                                Console.Write("입력: ");
                                int choice = int.Parse(Console.ReadLine());

                                if (choice == 1)
                                {
                                    // 장비 교체
                                    power -= GetWeaponPower(equippedWeapon); // 기존 무기 공격력 제거
                                    equippedWeapon = "A급 기사단장의 검";
                                    NewWeapon = equippedWeapon;
                                    power += GetWeaponPower(NewWeapon);
                                    Console.WriteLine($"{equippedWeapon}으로 장비가 교체되었습니다!");
                                }
                                else if (choice == 2)
                                {
                                    Console.WriteLine("장비를 유지합니다.");
                                    break;
                                }
                            }
                            else
                            {
                                power -= GetWeaponPower(equippedWeapon); // 기존 무기 공격력 제거
                                equippedWeapon = "A급 기사단장의 검";
                                NewWeapon = equippedWeapon;
                                power += GetWeaponPower(NewWeapon);
                            }
                        } // A 기사단장 검 이벤트
                        else if (getItem <= 10) 
                        {
                            Console.WriteLine("▶ 강가를 뒤져보다 강 바닥에 빛나는 무언가를 보았다.");
                            Thread.Sleep(800);
                            Console.WriteLine("▶ ...");
                            Thread.Sleep(800);
                            Console.WriteLine("▶ ...");
                            Thread.Sleep(800);
                            Console.WriteLine("▶ ...");
                            Thread.Sleep(800);
                            Console.WriteLine("▶ 이런곳에 갑옷이! A급 장비 용사의 갑옷을 획득하셨습니다!");
                            {
                                NewArmor = "A급 용사의 갑옷";
                                if (equippedArmor != NewArmor)
                                {
                                    Console.WriteLine("\n장비를 교체하시겠습니까?");
                                    Console.WriteLine("1. 예 | 2. 아니요");
                                    Console.Write("입력: ");
                                    int choice = int.Parse(Console.ReadLine());

                                    if (choice == 1)
                                    {
                                        // 장비 교체
                                        maxHealth -= GetArmorHealth(equippedArmor); // 기존 무기 공격력 제거
                                        equippedArmor = "A급 용사의 갑옷";
                                        NewArmor = equippedArmor;
                                        maxHealth += GetArmorHealth(NewArmor);
                                        Console.WriteLine($"{equippedArmor} 장비를 착용하였습니다!");
                                    }
                                    else if (choice == 2)
                                    {
                                        Console.WriteLine("장비를 유지합니다.");
                                        break;
                                    }
                                }
                                else
                                {
                                    maxHealth -= GetArmorHealth(equippedArmor); // 기존 무기 공격력 제거
                                    equippedArmor = "A급 용사의 갑옷";
                                    NewArmor = equippedArmor;
                                    maxHealth += GetArmorHealth(NewArmor);
                                }
                            }
                        } // A 용사의 갑옷 이벤트
                        else if (getItem <= 80)
                        {
                            Console.WriteLine("▶ 몸에 좋은 약초를 발견했다! ");
                            Thread.Sleep(800);
                            Console.WriteLine("▶ 약초는 역시 갓 채집 했을 때 먹어야지 ");
                            Thread.Sleep(800);
                            Console.WriteLine("▶ ...");
                            Thread.Sleep(800);
                            Console.WriteLine("▶ ...");
                            Thread.Sleep(800);
                            Console.WriteLine("▶ ...");
                            Thread.Sleep(800);
                            Console.WriteLine("▶ 몸에 기운이 넘친다! ( 체력 + 50 )");
                            health += 50; // 체력 50 회복
                            if (health > maxHealth)
                            {
                                health = maxHealth;
                            }
                            Thread.Sleep(800);
                        } //약초 이벤트
                        else
                        {
                            Console.WriteLine("▶ 몸에 좋은 약초를 발견했다! ");
                            Thread.Sleep(800);
                            Console.WriteLine("▶ 약초는 역시 갓 채집 했을 때 먹어야지 ");
                            Thread.Sleep(800); 
                            Console.WriteLine("▶ ...");
                            Thread.Sleep(800);
                            Console.WriteLine("▶ ...");
                            Thread.Sleep(800);
                            Console.WriteLine("▶ ...");
                            Thread.Sleep(800);
                            Console.WriteLine("▶ 약초인 줄 알았던 풀이 독초였다... ( 체력 - 20 )");
                            health -= 20; // 체력 20 감소
                            Thread.Sleep(800);
                        } //독초 이벤트


                    } // 20%, 아이템 획득 이벤트
                    else if (eventChance <= 60) // 10%, 던전 발견
                    {
                        Console.WriteLine("▶ 던전을 발견했습니다! ");
                        Console.WriteLine("▶ 입장 하시겠습니까? ( 제한 : 명성 10 이상 )");
                        Console.WriteLine("▶ 1. 네 | 2. 아니오");

                        input = int.Parse(Console.ReadLine());
                        
                        if (input == 1)
                        {
                            if(fame < 10)
                            {
                                Console.WriteLine($"▶ 명성이 부족합니다. 현재 명성 : {fame} ");
                                //던전 발견 화면으로 넘어가기
                            }
                            else
                            {
                                Console.WriteLine($"▶ 던전에 입장합니다... ");
                                //명성 및 던전 미구현
                            }
                        }
                        else if (input == 2)
                        {
                            Console.WriteLine("▶ 던전은 너무 위험하니 돌아가자. ");
                            Console.WriteLine("▶ 나는 발걸음을 다른 곳으로 돌렸다... ");
                        }
                        else
                        {
                            Console.WriteLine("▶ 잘 못 입력하셨습니다. ");
                        }

                    } // 10%, 던전 입장 이벤트
                    else // 40% 확률로 허탕치기
                    {
                        health -= 5; // 체력 5 감소
                        Console.WriteLine("▶ 아무 성과 없이 돌아왔습니다... ( 체력 -5 )");
                    } //40%, 허탕

                    if (health <= 0)
                    {
                        Console.WriteLine("\n 💀 체력이 0이 되어 사망했습니다... 게임 오버");
                        isAlive = false;
                    } //탐험 중 사망

                    Thread.Sleep(1000);
                } // 탐험하기

                else if (input == 2) // 장비 뽑기
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("상점 주인 : 환영합니다! 어떤 것을 뽑으시겠어요?");
                        Thread.Sleep(800);
                        Console.WriteLine("상점 주인 : 뽑기로는 최대 S랭크 장비를 습득 할 수 있어요~");
                        Thread.Sleep(800);
                        Console.WriteLine("─────────────────────────────────────────────");
                        Console.WriteLine("1. 무기 뽑기 | 2. 방어구 뽑기 | 3. 돌아가기");
                        Console.WriteLine("─────────────────────────────────────────────");
                        Console.Write("입력 : ");
                        input = int.Parse(Console.ReadLine());

                        if (input == 1)
                        {
                            if (gold < 1000)
                            {
                                Console.WriteLine("골드가 부족합니다. (1000골드 필요)");
                                Thread.Sleep(1000);
                                continue;
                            }
                            if (gold >= 1000)
                            {
                                gold -= 1000;
                                Console.Clear();
                                Console.WriteLine(" 🎲 무기를 뽑습니다...");
                                Thread.Sleep(1000);
                                Console.Clear();
                                int rnd = rand.Next(1, 101); // 1~100 랜덤

                                if (rnd == 1) // 1
                                {
                                    NewWeapon = "S급 서리검";
                                    Console.WriteLine("축하합니다! S급 서리검 ( 공격력 + 50 ) 획득!\n");
                                    if (equippedWeapon != NewWeapon)
                                    {
                                        Console.WriteLine("장비를 교체하시겠습니까?");
                                        Console.WriteLine("─────────────────────────────────────────────");
                                        Console.WriteLine("1. 예 | 2. 아니요");
                                        Console.WriteLine("─────────────────────────────────────────────");

                                        Console.Write("입력: ");
                                        int choice = int.Parse(Console.ReadLine());

                                        if (choice == 1)
                                        {
                                            // 장비 교체
                                            power -= GetWeaponPower(equippedWeapon); // 기존 무기 공격력 제거
                                            equippedWeapon = "S급 서리검";
                                            NewWeapon = equippedWeapon;
                                            power += GetWeaponPower(NewWeapon);
                                            Console.WriteLine("─────────────────────────────────────────────");
                                            Console.WriteLine($"{equippedWeapon}으로 장비가 교체되었습니다!");
                                        }
                                        else if (choice == 2)
                                        {
                                            Console.WriteLine("─────────────────────────────────────────────");
                                            Console.WriteLine("장비를 유지합니다.");
                                            Thread.Sleep(800);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("이미 장착중인 장비입니다.");
                                        Thread.Sleep(800);
                                        power -= GetWeaponPower(equippedWeapon); // 기존 무기 공격력 제거
                                        equippedWeapon = "S급 서리검";
                                        NewWeapon = equippedWeapon;
                                        power += GetWeaponPower(NewWeapon);
                                    }
                                } // S 무기 획득
                                else if (rnd <= 5 && rnd > 1) // 5
                                {
                                    NewWeapon = "A급 기사단장의 검";
                                    Console.WriteLine("축하합니다! A급 기사단장의 검 ( 공격력 + 30 ) 획득!\n");
                                    if (equippedWeapon != NewWeapon)
                                    {
                                        Console.WriteLine("장비를 교체하시겠습니까?");
                                        Console.WriteLine("─────────────────────────────────────────────");
                                        Console.WriteLine("1. 예 | 2. 아니요");
                                        Console.WriteLine("─────────────────────────────────────────────");

                                        Console.Write("입력: ");
                                        int choice = int.Parse(Console.ReadLine());

                                        if (choice == 1)
                                        {
                                            // 장비 교체
                                            power -= GetWeaponPower(equippedWeapon); // 기존 무기 공격력 제거
                                            equippedWeapon = "A급 기사단장의 검";
                                            NewWeapon = equippedWeapon;
                                            power += GetWeaponPower(NewWeapon);
                                            Console.WriteLine("─────────────────────────────────────────────");
                                            Console.WriteLine($"{equippedWeapon}으로 장비가 교체되었습니다!");
                                        }
                                        else if (choice == 2)
                                        {
                                            Console.WriteLine("─────────────────────────────────────────────");
                                            Console.WriteLine("장비를 유지합니다.");
                                            Thread.Sleep(800);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("이미 장착중인 장비입니다.");
                                        Thread.Sleep(800);
                                        power -= GetWeaponPower(equippedWeapon); // 기존 무기 공격력 제거
                                        equippedWeapon = "A급 기사단장의 검";
                                        NewWeapon = equippedWeapon;
                                        power += GetWeaponPower(NewWeapon);
                                    }

                                } // A 무기 획득
                                else if (rnd <= 20 && rnd > 5) // 15
                                {
                                
                                    NewWeapon = "B급 질 좋은 철검";
                                    Console.WriteLine("B급 질 좋은 철검 ( 공격력 + 20 ) 획득!\n");
                                    if (equippedWeapon != NewWeapon)
                                    {
                                        Console.WriteLine("장비를 교체하시겠습니까?");
                                        Console.WriteLine("─────────────────────────────────────────────");
                                        Console.WriteLine("1. 예 | 2. 아니요");
                                        Console.WriteLine("─────────────────────────────────────────────");
                                        Console.Write("입력: ");
                                        int choice = int.Parse(Console.ReadLine());

                                        if (choice == 1)
                                        {
                                            // 장비 교체
                                            power -= GetWeaponPower(equippedWeapon); // 기존 무기 공격력 제거
                                            equippedWeapon = "B급 질 좋은 철검";
                                            NewWeapon = equippedWeapon;
                                            power += GetWeaponPower(NewWeapon);
                                            Console.WriteLine("─────────────────────────────────────────────");
                                            Console.WriteLine($"{equippedWeapon} 장비를 착용 하었습니다!");
                                        }
                                        else if (choice == 2)
                                        {
                                            Console.WriteLine("─────────────────────────────────────────────");
                                            Console.WriteLine("장비를 유지합니다.");
                                            Thread.Sleep(800);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("이미 장착중인 장비입니다.");
                                        Thread.Sleep(800);
                                        power -= GetWeaponPower(equippedWeapon); // 기존 무기 공격력 제거
                                        equippedWeapon = "B급 질 좋은 철검";
                                        NewWeapon = equippedWeapon;
                                        power += GetWeaponPower(NewWeapon);
                                    }
                                
                                } // B 무기 획득
                                else if (rnd <= 40 && rnd > 20) // 20
                                {
                                    NewWeapon = "C급 단단한 검";
                                    Console.WriteLine("C급 단단한 검 ( 공격력 + 15 ) 획득!\n");
                                    if (equippedWeapon != NewWeapon)
                                    {
                                        Console.WriteLine("장비를 교체하시겠습니까?");
                                        Console.WriteLine("─────────────────────────────────────────────");
                                        Console.WriteLine("1. 예 | 2. 아니요");
                                        Console.WriteLine("─────────────────────────────────────────────");
                                        Console.Write("입력: ");
                                        int choice = int.Parse(Console.ReadLine());

                                        if (choice == 1)
                                        {
                                            // 장비 교체
                                            power -= GetWeaponPower(equippedWeapon); // 기존 무기 공격력 제거
                                            equippedWeapon = "C급 단단한 검";
                                            NewWeapon = equippedWeapon;
                                            power += GetWeaponPower(NewWeapon);
                                            Console.WriteLine("─────────────────────────────────────────────");
                                            Console.WriteLine($"{equippedWeapon} 장비를 착용 하었습니다!");
                                        }
                                        else if (choice == 2)
                                        {
                                            Console.WriteLine("─────────────────────────────────────────────");
                                            Console.WriteLine("장비를 유지합니다.");
                                            Thread.Sleep(800);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("이미 장착중인 장비입니다.");
                                        Thread.Sleep(800);
                                        power -= GetWeaponPower(equippedWeapon); // 기존 무기 공격력 제거
                                        equippedWeapon = "C급 단단한 검";
                                        NewWeapon = equippedWeapon;
                                        power += GetWeaponPower(NewWeapon);
                                    }
                                } // C 무기 획득
                                else if (rnd <= 65 && rnd > 40) // 25
                                {
                                    NewWeapon = "D급 평범한 검";
                                    Console.WriteLine("D급 평범한 검 ( 공격력 + 10 ) 획득!\n");
                                    if (equippedWeapon != NewWeapon)
                                    {
                                        Console.WriteLine("장비를 교체하시겠습니까?");
                                        Console.WriteLine("─────────────────────────────────────────────");
                                        Console.WriteLine("1. 예 | 2. 아니요");
                                        Console.WriteLine("─────────────────────────────────────────────");
                                        Console.Write("입력: ");
                                        int choice = int.Parse(Console.ReadLine());

                                        if (choice == 1)
                                        {
                                            // 장비 교체
                                            power -= GetWeaponPower(equippedWeapon); // 기존 무기 공격력 제거
                                            equippedWeapon = "D급 평범한 검";
                                            NewWeapon = equippedWeapon;
                                            power += GetWeaponPower(NewWeapon);
                                            Console.WriteLine("─────────────────────────────────────────────");
                                            Console.WriteLine($"{equippedWeapon}으로 장비가 교체되었습니다!");
                                        }
                                        else if (choice == 2)
                                        {
                                            Console.WriteLine("─────────────────────────────────────────────");
                                            Console.WriteLine("장비를 유지합니다.");
                                            Thread.Sleep(800);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("이미 장착중인 장비입니다.");
                                        Thread.Sleep(800);
                                        power -= GetWeaponPower(equippedWeapon); // 기존 무기 공격력 제거
                                        equippedWeapon = "D급 평범한 검";
                                        NewWeapon = equippedWeapon;
                                        power += GetWeaponPower(NewWeapon);
                                    }
                                } // D 무기 획득
                                else
                                {
                                    NewWeapon = "F급 녹슨 철검";
                                    Console.WriteLine("F급 녹슨 철검 ( 공격력 + 5 ) 획득!\n");
                                    if (equippedWeapon != NewWeapon)
                                    {
                                        Console.WriteLine("장비를 교체하시겠습니까?");
                                        Console.WriteLine("─────────────────────────────────────────────");
                                        Console.WriteLine("1. 예 | 2. 아니요");
                                        Console.WriteLine("─────────────────────────────────────────────");
                                        Console.Write("입력: ");
                                        int choice = int.Parse(Console.ReadLine());

                                        if (choice == 1)
                                        {
                                            // 장비 교체
                                            power -= GetWeaponPower(equippedWeapon); // 기존 무기 공격력 제거
                                            equippedWeapon = "F급 녹슨 철검";
                                            NewWeapon = equippedWeapon;
                                            power += GetWeaponPower(NewWeapon);
                                            Console.WriteLine("─────────────────────────────────────────────");
                                            Console.WriteLine($"{equippedWeapon}으로 장비가 교체되었습니다!");
                                        }
                                        else if (choice == 2)
                                        {
                                            Console.WriteLine("─────────────────────────────────────────────");
                                            Console.WriteLine("장비를 유지합니다.");
                                            Thread.Sleep(800);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("이미 장착중인 장비입니다.");
                                        Thread.Sleep(800);
                                        power -= GetWeaponPower(equippedWeapon); // 기존 무기 공격력 제거
                                        equippedWeapon = "F급 녹슨 철검";
                                        NewWeapon = equippedWeapon;
                                        power += GetWeaponPower(NewWeapon);
                                    }
                                } // F 무기 획득

                                Thread.Sleep(2000);
                            }

                        } //무기 뽑기 이벤트
                        else if (input == 2) //방어구 뽑기 이벤트
                        {
                            if (gold < 1000)
                            {
                                Console.WriteLine("─────────────────────────────────────────────");
                                Console.WriteLine("골드가 부족합니다. (1000골드 필요)");
                                Thread.Sleep(1000);
                                continue;
                            }
                            if (gold >= 1000)
                            {
                                gold -= 1000;
                                Console.Clear();
                                Console.WriteLine(" 🎲 방어구를 뽑습니다...");
                                Thread.Sleep(1000);
                                Console.Clear();

                                int rnd = rand.Next(1, 101); // 1~100 랜덤

                                if (rnd == 1) // 1
                                {
                                    NewArmor = "S급 빛의 수호 갑옷";
                                    Console.WriteLine("축하합니다! S급 빛의 수호 갑옷 ( 최대체력 + 200 ) 획득!");
                                    if (equippedArmor != NewArmor)
                                    {
                                        Console.WriteLine("장비를 교체하시겠습니까?");
                                        Console.WriteLine("─────────────────────────────────────────────");
                                        Console.WriteLine("1. 예 | 2. 아니요");
                                        Console.WriteLine("─────────────────────────────────────────────");
                                        Console.Write("입력: ");
                                        int choice = int.Parse(Console.ReadLine());

                                        if (choice == 1)
                                        {
                                            // 장비 교체
                                            maxHealth -= GetArmorHealth(equippedArmor); // 기존 무기 공격력 제거
                                            equippedArmor = "S급 빛의 수호 갑옷";
                                            NewArmor = equippedArmor;
                                            maxHealth += GetArmorHealth(NewArmor);
                                            Console.WriteLine("─────────────────────────────────────────────");
                                            Console.WriteLine($"{equippedArmor} 장비를 착용하였습니다!");
                                        }
                                        else if (choice == 2)
                                        {
                                            Console.WriteLine("─────────────────────────────────────────────");
                                            Console.WriteLine("장비를 유지합니다.");
                                            Thread.Sleep(800);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("이미 장착중인 장비입니다.");
                                        Thread.Sleep(800);
                                        maxHealth -= GetArmorHealth(equippedArmor); // 기존 무기 공격력 제거
                                        equippedArmor = "S급 빛의 수호 갑옷";
                                        NewArmor = equippedArmor;
                                        maxHealth += GetArmorHealth(NewArmor);
                                    }
                                } // S 방어구
                                else if (rnd <= 5 && rnd > 1) 
                                {
                                    NewArmor = "A급 용사의 갑옷";
                                    Console.WriteLine("축하합니다! A급 용사의 갑옷 ( 최대체력 + 120 ) 획득!\n");
                                    if (equippedArmor != NewArmor)
                                    {
                                        Console.WriteLine("장비를 교체하시겠습니까?");
                                        Console.WriteLine("─────────────────────────────────────────────");
                                        Console.WriteLine("1. 예 | 2. 아니요");
                                        Console.WriteLine("─────────────────────────────────────────────");
                                        Console.Write("입력: ");
                                        int choice = int.Parse(Console.ReadLine());

                                        if (choice == 1)
                                        {
                                            // 장비 교체
                                            maxHealth -= GetArmorHealth(equippedArmor); // 기존 무기 공격력 제거
                                            equippedArmor = "A급 용사의 갑옷";
                                            NewArmor = equippedArmor;
                                            maxHealth += GetArmorHealth(NewArmor);
                                            Console.WriteLine("─────────────────────────────────────────────");
                                            Console.WriteLine($"{equippedArmor} 장비를 착용하였습니다!");
                                        }
                                        else if (choice == 2)
                                        {
                                            Console.WriteLine("─────────────────────────────────────────────");
                                            Console.WriteLine("장비를 유지합니다.");
                                            Thread.Sleep(800);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("이미 장착중인 장비입니다.");
                                        Thread.Sleep(800);
                                        maxHealth -= GetArmorHealth(equippedArmor); // 기존 무기 공격력 제거
                                        equippedArmor = "A급 용사의 갑옷";
                                        NewArmor = equippedArmor;
                                        maxHealth += GetArmorHealth(NewArmor);
                                    }
                                } // A 방어구
                                else if (rnd <= 20 && rnd > 5) // 15
                                {
                                    NewArmor = "B급 튼튼한 전투복";
                                    Console.WriteLine("B급 튼튼한 전투복 ( 최대체력 + 80 ) 획득!\n");
                                    if (equippedArmor != NewArmor)
                                    {
                                        Console.WriteLine("장비를 교체하시겠습니까?");
                                        Console.WriteLine("─────────────────────────────────────────────");
                                        Console.WriteLine("1. 예 | 2. 아니요");
                                        Console.WriteLine("─────────────────────────────────────────────");
                                        Console.Write("입력: ");
                                        int choice = int.Parse(Console.ReadLine());

                                        if (choice == 1)
                                        {
                                            // 장비 교체
                                            maxHealth -= GetArmorHealth(equippedArmor); // 기존 무기 공격력 제거
                                            equippedArmor = "B급 튼튼한 전투복";
                                            NewArmor = equippedArmor;
                                            maxHealth += GetArmorHealth(NewArmor);
                                            Console.WriteLine("─────────────────────────────────────────────");
                                            Console.WriteLine($"{equippedArmor} 장비를 착용하였습니다!");
                                        }
                                        else if (choice == 2)
                                        {
                                            Console.WriteLine("─────────────────────────────────────────────");
                                            Console.WriteLine("장비를 유지합니다.");
                                            Thread.Sleep(800);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("이미 장착중인 장비입니다.");
                                        Thread.Sleep(800);
                                        maxHealth -= GetArmorHealth(equippedArmor); // 기존 무기 공격력 제거
                                        equippedArmor = "B급 튼튼한 전투복";
                                        NewArmor = equippedArmor;
                                        maxHealth += GetArmorHealth(NewArmor);
                                    }
                                } // B 방어구
                                else if (rnd <= 40 && rnd > 20) // 20
                                {
                                    NewArmor = "C급 질긴 가죽 갑옷";
                                    Console.WriteLine("C급 질긴 가죽 갑옷 ( 최대체력 + 40 ) 획득!\n");
                                    if (equippedArmor != NewArmor)
                                    {
                                        Console.WriteLine("장비를 교체하시겠습니까?");
                                        Console.WriteLine("─────────────────────────────────────────────");
                                        Console.WriteLine("1. 예 | 2. 아니요");
                                        Console.WriteLine("─────────────────────────────────────────────");
                                        Console.Write("입력: ");
                                        int choice = int.Parse(Console.ReadLine());

                                        if (choice == 1)
                                        {
                                            // 장비 교체
                                            maxHealth -= GetArmorHealth(equippedArmor); // 기존 무기 공격력 제거
                                            equippedArmor = "C급 질긴 가죽 갑옷";
                                            NewArmor = equippedArmor;
                                            maxHealth += GetArmorHealth(NewArmor);
                                            Console.WriteLine("─────────────────────────────────────────────");
                                            Console.WriteLine($"{equippedArmor} 장비를 착용하였습니다!");
                                        }
                                        else if (choice == 2)
                                        {
                                            Console.WriteLine("─────────────────────────────────────────────");
                                            Console.WriteLine("장비를 유지합니다.");
                                            Thread.Sleep(800);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("이미 장착중인 장비입니다.");
                                        Thread.Sleep(800);
                                        maxHealth -= GetArmorHealth(equippedArmor); // 기존 무기 공격력 제거
                                        equippedArmor = "C급 질긴 가죽 갑옷";
                                        NewArmor = equippedArmor;
                                        maxHealth += GetArmorHealth(NewArmor);
                                    }
                                } // C 방어구
                                else if (rnd <= 65 && rnd > 40) // S 방어구
                                {
                                    NewArmor = "D급 낡은 사슬 갑옷";
                                    Console.WriteLine("D급 낡은 사슬 갑옷 ( 최대체력 + 30 ) 획득!\n");
                                    if (equippedArmor != NewArmor)
                                    {
                                        Console.WriteLine("장비를 교체하시겠습니까?");
                                        Console.WriteLine("─────────────────────────────────────────────");
                                        Console.WriteLine("1. 예 | 2. 아니요");
                                        Console.WriteLine("─────────────────────────────────────────────");
                                        Console.Write("입력: ");
                                        int choice = int.Parse(Console.ReadLine());

                                        if (choice == 1)
                                        {
                                            // 장비 교체
                                            maxHealth -= GetArmorHealth(equippedArmor); // 기존 무기 공격력 제거
                                            equippedArmor = "D급 낡은 사슬 갑옷";
                                            NewArmor = equippedArmor;
                                            maxHealth += GetArmorHealth(NewArmor);
                                            Console.WriteLine("─────────────────────────────────────────────");
                                            Console.WriteLine($"{equippedArmor} 장비를 착용하였습니다!");
                                        }
                                        else if (choice == 2)
                                        {
                                            Console.WriteLine("─────────────────────────────────────────────");
                                            Console.WriteLine("장비를 유지합니다.");
                                            Thread.Sleep(800);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("이미 장착중인 장비입니다.");
                                        Thread.Sleep(800);
                                        maxHealth -= GetArmorHealth(equippedArmor); // 기존 무기 공격력 제거
                                        equippedArmor = "D급 낡은 사슬 갑옷";
                                        NewArmor = equippedArmor;
                                        maxHealth += GetArmorHealth(NewArmor);
                                    }
                                } // D 방어구
                                else
                                {
                                    NewArmor = "F급 해진 천옷";
                                    Console.WriteLine("F급 해진 천옷 ( 최대체력 + 15 ) 획득!\n");
                                    if (equippedArmor != NewArmor)
                                    {
                                        Console.WriteLine("장비를 교체하시겠습니까?");
                                        Console.WriteLine("─────────────────────────────────────────────");
                                        Console.WriteLine("1. 예 | 2. 아니요");
                                        Console.WriteLine("─────────────────────────────────────────────");
                                        Console.Write("입력: ");
                                        int choice = int.Parse(Console.ReadLine());

                                        if (choice == 1)
                                        {
                                            // 장비 교체
                                            maxHealth -= GetArmorHealth(equippedArmor); // 기존 무기 공격력 제거
                                            equippedArmor = "F급 해진 천옷";
                                            NewArmor = equippedArmor;
                                            maxHealth += GetArmorHealth(NewArmor);
                                            Console.WriteLine("─────────────────────────────────────────────");
                                            Console.WriteLine($"{equippedArmor} 장비를 착용하였습니다!");
                                        }
                                        else if (choice == 2)
                                        {
                                            Console.WriteLine("─────────────────────────────────────────────");
                                            Console.WriteLine("장비를 유지합니다.");
                                            Thread.Sleep(800);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("이미 장착중인 장비입니다.");
                                        Thread.Sleep(800);
                                        maxHealth -= GetArmorHealth(equippedArmor); // 기존 무기 공격력 제거
                                        equippedArmor = "F급 해진 천옷";
                                        NewArmor = equippedArmor;
                                        maxHealth += GetArmorHealth(NewArmor);
                                    }
                                } // E 방어구

                                Thread.Sleep(2000);
                            }
                        } //방어구 뽑기 이벤트
                        else if (input == 3)
                        {
                            Console.WriteLine("마을로 돌아갑니다.");
                            break;
                        } // 마을로 돌아간다.
                    }
                } // 장비뽑기

                else if (input == 3) // 휴식하기
                {
                    while (true)
                    {
                        Console.Clear();
                        if (gold < 1000)
                        {
                            Console.WriteLine("골드가 부족합니다.");
                            Thread.Sleep(1000);
                            break;
                        }
                        Console.WriteLine("휴식을 취합니다... ( + 30 체력 / 마나 ) ");
                        gold -= 200;
                        Console.WriteLine($"현재 골드 {gold} ");
                        health += 20;
                        if (health > maxHealth)
                        {
                            health = maxHealth;
                        }
                        Thread.Sleep(1000);
                        break;
                    }
                } // 휴식하기

                else if (input == 4) //게임 종료
                {
                    Console.WriteLine("게임을 종료합니다.");
                    Environment.Exit(1);
                } // 게임 종료

                else // 입력 오류
                {
                    Console.WriteLine("잘못된 입력입니다. 다시 선택하세요.");
                    Thread.Sleep(1000);
                } // 입력 오류 처리
            }
        }
    }
}
