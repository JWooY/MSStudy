using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG
{
    class MainGame
    {
        public Player m_tPlayer = null;
        //필드 객체
        public Field m_pField = null;



        //초기화 해주는 함수
        public void Initialize()
        {
            //플레이어 생성 및 직업 선택
            m_tPlayer = new Player();
            m_tPlayer.SelectJob();
        }

        public void Progress()
        {
            int iInput = 0;

            while (true)
            {
                Console.Clear();
                m_tPlayer.Render(); // 플레이어 출력
                Console.WriteLine("1.사냥터 / 2.종료 : ");
                iInput = int.Parse(Console.ReadLine());

                if (iInput == 1) // 사냥터 구현
                {
                    if(m_pField == null)
                    {
                        m_pField = new Field();

                        m_pField.SetPlayer(ref m_tPlayer);
                    }
                    m_pField.Progress();
                }

                if (iInput == 2)
                    break;
            }
        }

        public MainGame() { }

        ~MainGame() { }
    }
}
