using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG
{
    class Field
    {
        Player m_pPlayer = null;
        //몬스터
        Monster m_pMonster = null;

        //플레이어 maingame에서 생성한거 가지고 와야함
        //플레이어가 필드에서 전투를 하면 데미지를 입을거고 hp가 깎일거임
        //그럼 배운것중에 ref 를 써볼 수 있을거임

        public void SetPlayer(ref Player pPlayer) { m_pPlayer = pPlayer; }
        
        public void Progress()
        {
            //사냥터로 들어왔다.
            int iInput = 0;

            while(true)
            {
                Console.Clear();

                m_pPlayer.Render();
                DrawMap();

                iInput = int.Parse(Console.ReadLine());

                if (iInput == 4)
                    break;

                if (iInput <= 3)
                {
                    //몬스터 만들고
                    //1번일 때 초보 몬스터
                    //2번일 때 중급 몬스터
                    //3번일 때 고급 몬스터
                    CreateMonster(iInput);
                    //싸운다
                    Fight();
                }


            }
        }

        //생성을 도와주는 함수
        //공장처럼 찍어낸다.
        //팩토리 메서드 패턴
        public void Create(string _strName, int _iHp, int _iAttack, out Monster pMonster)
        {
            pMonster = new Monster(); // 몬스터 생성
            INFO tMonster = new INFO(); // 몬스터 데이터 메모리 주기 객체 생성

            tMonster.strName = _strName; // 초보 몬스터, 중, 고
            tMonster.iHp = _iHp; //체력
            tMonster.iAttack = _iAttack; // 공격력

            pMonster.SetMonster(tMonster); // 샹성된 데이터 INFO 클래스타입 이자로 데이터 세팅
        }


        public void CreateMonster(int input)
        {
            switch(input)
            {
                case 1:
                    //공장 처럼 찍어내준다.
                    //디자인 패턴 팩토리 메서드 패턴
                    Create("초보몹", 30, 3, out m_pMonster);
                    break;
                case 2:
                    Create("중수몹", 60, 6, out m_pMonster);
                    break;
                case 3:
                    Create("고수몹", 90, 9, out m_pMonster);
                    break;

            }
        }
        public void Fight()
        {
            int iInput = 0;

            while(true)
            {
                Console.Clear(); // 콘솔 화면 지움
                m_pPlayer.Render(); // 플레이어 정보 출력
                m_pMonster.Render(); // 몬스터 정보 출력

                Console.WriteLine("1공격 / 2.도망 : "); //1,2 선택 표시
                iInput = int.Parse(Console.ReadLine());

                //공백일 때 엔터 눌러도 다시 선택 반복되도록 하기
                /*
                while (true)
                {
                    string input = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out iInput))
                    {
                        break; // 유효한 숫자 입력이 들어오면 반복문 탈출
                    }
                }
                */
                if (iInput == 1)
                {
                    //플레이어 데미지 주기. 몬스터 공격력 넣어서 데미지
                    m_pPlayer.SetDamage(m_pMonster.GetMonster().iAttack);
                    //몬스터 데미지 주기. 플레이어 공격력 넣기
                    m_pMonster.SetDamage(m_pPlayer.GetInfo().iAttack);

                    if (m_pPlayer.GetInfo().iHp <= 0) // 플레이어 체력이 0이하면
                    {
                        m_pPlayer.SetHp(100);
                        break; //체력 100 채워주고 다시 전투
                    }

                }

                if(iInput == 2 || m_pMonster.GetMonster().iHp <= 0)
                {
                    m_pMonster = null;
                    break; // 탈출
                }
            }    
        }

        private void DrawMap()
        {
            Console.WriteLine("1. 초보맵"); // 얘네 전부 드래그 하고 알트 엔터로 함수화 시킴
            Console.WriteLine("2. 중수맵");
            Console.WriteLine("3. 고수맵");
            Console.WriteLine("4. 이전으로");
            Console.WriteLine("============");
            Console.WriteLine("맵을 선택하세요 : ");
        }

        public Field() { }
        ~Field() { }


    }
}
