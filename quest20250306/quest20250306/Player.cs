using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest20250306
{
    class Player
    {
        public INFO aInfo; // INFO 정보 받아와서 aInfo로 쓰기

        //받은 데미지
        public void SetDamage(int iAttack) { aInfo.iHp -= iAttack; }

        // 직업 선택
        public void SelectJob()
        {
            aInfo = new INFO();
            Console.WriteLine("직업을 선택하세요 (1. 전사 / 2. 도적 / 3. 마법사)");
            int Iinput = int.Parse(Console.ReadLine());

            switch(Iinput) // 값이 들어왔을 때 스위치문 돌려라
            {
                case 1: // 1들어오면
                    aInfo.strName = "전사";
                    aInfo.iHp = 100;
                    aInfo.iAttack = 10;
                    break;

                case 2:
                    aInfo.strName = "도적";
                    aInfo.iHp = 90;
                    aInfo.iAttack = 15;
                    break;

                case 3:
                    aInfo.strName = "마법사";
                    aInfo.iHp = 80;
                    aInfo.iAttack = 20;
                    break;
            }




        }

    }
}
