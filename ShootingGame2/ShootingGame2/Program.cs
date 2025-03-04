using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShootingGame2
{
    //미사일 클래스
    public class BULLET
    {
        public int x;
        public int y;
        public bool fire;
    }
    //플레이어 클래스
    public class Player
    {
        [DllImport("msvcrt.dll")] //c언어 함수 가져옴. 강사님이 그냥 이거 쓰라고 디코로 주심
        static extern int _getch();  //c언어 함수 가져옴. 강사님이 그냥 이거 쓰라고 디코로 주심

        public int playerX; // 플레이어 x 좌표
        public int playerY; // 플레이어 y 좌표
        public BULLET[] playerBullet = new BULLET[20];
        public BULLET[] playerBullet2 = new BULLET[20];
        public BULLET[] playerBullet3 = new BULLET[20];
        public BULLET[] playerBullet4 = new BULLET[20];
        public BULLET[] playerBullet5 = new BULLET[20];
        public BULLET[] playerBullet6 = new BULLET[20];

        public int Score = 100;
        public Item item = new Item();
        public int itemCount = 0;

        public Player() // 생성자를 이용해 초기화
        {
            //플레이어 좌표 위치 초기화
            playerX = 0;
            playerY = 12;

            for (int i = 0; i < 20; i++) // 총알 초기화
            {
                playerBullet[i] = new BULLET(); // 총알 배열 받아오고 초기화
                playerBullet[i].x = 0;
                playerBullet[i].y = 0;
                playerBullet[i].fire = false;

                playerBullet2[i] = new BULLET(); // 총알 배열 받아오고 초기화
                playerBullet2[i].x = 0;
                playerBullet2[i].y = 0;
                playerBullet2[i].fire = false;

                playerBullet3[i] = new BULLET(); // 총알 배열 받아오고 초기화
                playerBullet3[i].x = 0;
                playerBullet3[i].y = 0;
                playerBullet3[i].fire = false;

                playerBullet4[i] = new BULLET(); // 총알 배열 받아오고 초기화
                playerBullet4[i].x = 0;
                playerBullet4[i].y = 0;
                playerBullet4[i].fire = false;

                playerBullet5[i] = new BULLET(); // 총알 배열 받아오고 초기화
                playerBullet5[i].x = 0;
                playerBullet5[i].y = 0;
                playerBullet5[i].fire = false;

                playerBullet6[i] = new BULLET(); // 총알 배열 받아오고 초기화
                playerBullet6[i].x = 0;
                playerBullet6[i].y = 0;
                playerBullet6[i].fire = false;

            }
        }

        public void GameMain()
        {
            //키를 입력하는 부분
            KeyConttol();
            // 플레이어를 그려준다.
            PlayerDraw();

            //UI 점수
            UIscore();

            if(item.ItemLife)
            {
                item.ItemMove();
                item.ItemDraw();
                CrashItem();
            }
        }

        public void KeyConttol()
        {
            int pressKey; // 정수형 변수 선언 키 값 받을 것임.

            if(Console.KeyAvailable) // 키가 눌렸을 때 true
            {
                pressKey = _getch(); // 아스키 값 왼쪽 오른쪽

                if (pressKey == 0 || pressKey == 224) // 화살표 키 또는 특수 키 감지
                {
                    pressKey = _getch(); // 실제 키 값 읽기
                }

                switch (pressKey)
                {
                    case 72: //위쪽방향 아스키코드
                        playerY--;
                        if (playerY < 1)
                            playerY = 1;
                        break;
                    case 75: // 왼쪽 화살표 키
                        playerX--;
                        if (playerX < 0)
                            playerX = 0;
                        break;
                    case 77: // 오른쪽 화살표 키
                        playerX++;
                        if (playerX > 75)
                            playerX = 75;
                        break;
                    case 80: //아래 화살표 키
                        playerY++;
                        if (playerY > 21)
                            playerY = 21;
                        break;
                    case 32: //스페이스바
                        //총알 발사
                        if (itemCount < 3)
                        {
                            for (int i = 0; i < 20; i++)
                            {
                                //미사일이 false 발사 가능
                                if (playerBullet[i].fire == false)
                                {
                                    playerBullet[i].fire = true;
                                    //플레이어 앞에서 미사일 쏘기 + 5
                                    playerBullet[i].x = playerX + 5;
                                    playerBullet[i].y = playerY + 1;
                                    //한발씩 쏘겠다는 뜻.
                                    break;
                                }
                            }

                            //총알2 발사
                            for (int i = 0; i < 20; i++)
                            {
                                //미사일이 false 발사 가능
                                if (playerBullet2[i].fire == false)
                                {
                                    playerBullet2[i].fire = true;
                                    //플레이어 앞에서 미사일 쏘기 + 5
                                    playerBullet2[i].x = playerX + 5;
                                    playerBullet2[i].y = playerY;
                                    //한발씩 쏘겠다는 뜻.
                                    break;
                                }
                            }

                            //총알3 발사
                            for (int i = 0; i < 20; i++)
                            {
                                //미사일이 false 발사 가능
                                if (playerBullet3[i].fire == false)
                                {
                                    playerBullet3[i].fire = true;
                                    //플레이어 앞에서 미사일 쏘기 + 5
                                    playerBullet3[i].x = playerX + 5;
                                    playerBullet3[i].y = playerY + 2;
                                    //한발씩 쏘겠다는 뜻.
                                    break;
                                }
                            }
                        }
                        else
                        {
                            //총알4 발사
                            for (int i = 0; i < 20; i++)
                            {
                                //미사일이 false 발사 가능
                                if (playerBullet4[i].fire == false)
                                {
                                    playerBullet4[i].fire = true;
                                    //플레이어 앞에서 미사일 쏘기 + 5
                                    playerBullet4[i].x = playerX + 5;
                                    playerBullet4[i].y = playerY + 2;
                                    //한발씩 쏘겠다는 뜻.
                                    break;
                                }
                            }

                            //총알5 발사
                            for (int i = 0; i < 20; i++)
                            {
                                //미사일이 false 발사 가능
                                if (playerBullet5[i].fire == false)
                                {
                                    playerBullet5[i].fire = true;
                                    //플레이어 앞에서 미사일 쏘기 + 5
                                    playerBullet5[i].x = playerX + 5;
                                    playerBullet5[i].y = playerY + 2;
                                    //한발씩 쏘겠다는 뜻.
                                    break;
                                }
                            }

                            //총알6 발사
                            for (int i = 0; i < 20; i++)
                            {
                                //미사일이 false 발사 가능
                                if (playerBullet6[i].fire == false)
                                {
                                    playerBullet6[i].fire = true;
                                    //플레이어 앞에서 미사일 쏘기 + 5
                                    playerBullet6[i].x = playerX + 5;
                                    playerBullet6[i].y = playerY + 2;
                                    //한발씩 쏘겠다는 뜻.
                                    break;
                                }
                            }
                        }
                        break;
                }
            }
        }

        //미사일 그리기
        public void BulletDraw()
        {
            string bullet = "->"; // 미사일 모습

            for (int i = 0; i < 20; i++)
            {
                if (playerBullet[i].fire == true)
                {
                    //좌표 설정 -> 중간위치를 위해 보정을 위해 x-1
                    Console.SetCursorPosition(playerBullet[i].x-1, playerBullet[i].y);
                    //총알 출력
                    Console.Write(bullet);

                    playerBullet[i].x++; // 미사일 한칸씩 오른쪽으로 날리기

                    if (playerBullet[i].x > 78)
                    {
                        playerBullet[i].fire = false; // 미사일 false. 다시 준비 상태로 돌리기
                    }
                }
            }
        }

        //미사일 그리기2
        public void BulletDraw2()
        {
            string bullet = "->"; // 미사일 모습

            for (int i = 0; i < 20; i++)
            {
                if (playerBullet2[i].fire == true)
                {
                    //좌표 설정 -> 중간위치를 위해 보정을 위해 x-1
                    Console.SetCursorPosition(playerBullet2[i].x-1, playerBullet2[i].y);
                    //총알 출력
                    Console.Write(bullet);

                    playerBullet2[i].x++; // 미사일 한칸씩 오른쪽으로 날리기

                    if (playerBullet2[i].x > 78)
                    {
                        playerBullet2[i].fire = false; // 미사일 false. 다시 준비 상태로 돌리기
                    }
                }
            }
        }

        //미사일 그리기3
        public void BulletDraw3()
        {
            string bullet = "->"; // 미사일 모습

            for (int i = 0; i < 20; i++)
            {
                if (playerBullet3[i].fire == true)
                {
                    //좌표 설정 -> 중간위치를 위해 보정을 위해 x-1
                    Console.SetCursorPosition(playerBullet3[i].x-1, playerBullet3[i].y);
                    //총알 출력
                    Console.Write(bullet);

                    playerBullet3[i].x++; // 미사일 한칸씩 오른쪽으로 날리기

                    if (playerBullet3[i].x > 78)
                    {
                        playerBullet3[i].fire = false; // 미사일 false. 다시 준비 상태로 돌리기
                    }
                }
            }
        }

        public void BulletDraw4()
        {
            string bullet = "--\\"; // 미사일 모습
            string bullet2 = "--/"; // 미사일 모습

            for (int i = 0; i < 20; i++)
            {
                if (playerBullet4[i].fire == true)
                {
                    //좌표 설정 -> 중간위치를 위해 보정을 위해 x-1
                    Console.SetCursorPosition(playerBullet4[i].x - 1, playerBullet4[i].y);
                    //총알 출력
                    Console.Write(bullet);

                    Console.SetCursorPosition(playerBullet4[i].x - 1, playerBullet4[i].y+1);
                    //총알 출력
                    Console.Write(bullet2);

                    playerBullet4[i].x++; // 미사일 한칸씩 오른쪽으로 날리기

                    if (playerBullet4[i].x > 78)
                    {
                        playerBullet4[i].fire = false; // 미사일 false. 다시 준비 상태로 돌리기
                    }
                }
            }
        }

        public void BulletDraw5()
        {
            string bullet = "--\\"; // 미사일 모습
            string bullet2 = "--/"; // 미사일 모습

            for (int i = 0; i < 20; i++)
            {
                if (playerBullet5[i].fire == true)
                {
                    //좌표 설정 -> 중간위치를 위해 보정을 위해 x-1
                    Console.SetCursorPosition(playerBullet5[i].x - 1, playerBullet5[i].y);
                    //총알 출력
                    Console.Write(bullet);

                    Console.SetCursorPosition(playerBullet5[i].x - 1, playerBullet5[i].y);
                    //총알 출력
                    Console.Write(bullet);

                    playerBullet5[i].x++; // 미사일 한칸씩 오른쪽으로 날리기

                    if (playerBullet5[i].x > 78)
                    {
                        playerBullet5[i].fire = false; // 미사일 false. 다시 준비 상태로 돌리기
                    }
                }
            }
        }

        public void BulletDraw6()
        {
            string bullet = "--\\";
            string bullet2 = "--/"; 

            for (int i = 0; i < 20; i++)
            {
                if (playerBullet6[i].fire == true)
                {
                    //좌표 설정 -> 중간위치를 위해 보정을 위해 x-1
                    Console.SetCursorPosition(playerBullet6[i].x - 1, playerBullet6[i].y);
                    //총알 출력
                    Console.Write(bullet);

                    playerBullet6[i].x++; // 미사일 한칸씩 오른쪽으로 날리기

                    if (playerBullet6[i].x > 78)
                    {
                        playerBullet6[i].fire = false; // 미사일 false. 다시 준비 상태로 돌리기
                    }
                }
            }
        }

        public void PlayerDraw()
        {
            String[] player = new string[]
            {
                "->",
                "-->",
                "->"
            }; //배열 문자열로 그리기

            for (int i = 0; i < player.Length; i++)
            {
                //콘솔좌표 설정. 플레이어X 플레이어Y
                Console.SetCursorPosition(playerX, playerY + i);
                //문자열 배열 출력
                Console.WriteLine(player[i]);
            }
        }

        //적과의 충돌 처리
        public void ClashEnemyAndBullet(Enemy enemy)
        {
            //미사일 20
            for (int i = 0; i < 20; i++)
            {
                if (playerBullet[i].fire == true)
                {
                    //미사일과 적의 y값이 같을 때
                    if (playerBullet[i].y == enemy.enemyY)
                    {
                        if (playerBullet[i].x >= (enemy.enemyX - 1)
                            && playerBullet[i].x <= (enemy.enemyX + 1)) //충돌
                        {
                            //아이템 충돌(획득)
                            item.ItemLife = true;
                            item.itemX = enemy.enemyX;
                            item.itemY = enemy.enemyY;

                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet[i].fire = false; // 미사일도 준비상태로 만들어주기

                            //스코어
                            Score += 100;


                        }
                    }
                }
            }

            //미사일2 20
            for (int i = 0; i < 20; i++)
            {
                if (playerBullet2[i].fire == true)
                {
                    //미사일과 적의 y값이 같을 때
                    if (playerBullet2[i].y == enemy.enemyY)
                    {
                        if (playerBullet2[i].x >= (enemy.enemyX - 1)
                            && playerBullet2[i].x <= (enemy.enemyX + 1)) //충돌
                        {
                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet2[i].fire = false; // 미사일도 준비상태로 만들어주기

                            //스코어
                            Score += 100;


                        }
                    }
                }
            }

            //미사일3 20
            for (int i = 0; i < 20; i++)
            {
                if (playerBullet3[i].fire == true)
                {
                    //미사일과 적의 y값이 같을 때
                    if (playerBullet3[i].y == enemy.enemyY)
                    {
                        if (playerBullet3[i].x >= (enemy.enemyX - 1)
                            && playerBullet3[i].x <= (enemy.enemyX + 1)) //충돌
                        {
                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet3[i].fire = false; // 미사일도 준비상태로 만들어주기

                            //스코어
                            Score += 100;


                        }
                    }
                }
            }
        }

        public void UIscore()
        {
            Console.SetCursorPosition(63, 0);
            Console.Write("┏━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(63, 1);
            Console.Write("┃              ┃");
            Console.SetCursorPosition(65, 1);
            Console.Write("Score : " + Score);
            Console.SetCursorPosition(63, 2);
            Console.Write("┗━━━━━━━━━━━━━━┛");
        }

        //아이템 충돌이 일어나면 양쪽 미사일 발사
        public void CrashItem()
        {
            if(playerY+1 == item.itemY)
            {
                if(playerX >= item.itemX-2 && playerX <= item.itemX + 2)
                {
                    item.ItemLife = false;

                    if (itemCount < 3)
                        itemCount++;

                    if (itemCount <= 3)
                    {
                        for (int i = 0; i < 20; i++) // 총알 초기화
                        {
                            playerBullet[i] = new BULLET(); // 총알 배열 받아오고 초기화
                            playerBullet[i].x = 0;
                            playerBullet[i].y = 0;
                            playerBullet[i].fire = false;

                            playerBullet2[i] = new BULLET(); // 총알 배열 받아오고 초기화
                            playerBullet2[i].x = 0;
                            playerBullet2[i].y = 0;
                            playerBullet2[i].fire = false;

                            playerBullet3[i] = new BULLET(); // 총알 배열 받아오고 초기화
                            playerBullet3[i].x = 0;
                            playerBullet3[i].y = 0;
                            playerBullet3[i].fire = false;
                        }
                    }
                    else if (itemCount > 3)
                    {
                        for (int i = 0; i < 20; i++) // 총알 초기화
                        {
                            playerBullet4[i] = new BULLET(); // 총알 배열 받아오고 초기화
                            playerBullet4[i].x = 0;
                            playerBullet4[i].y = 0;
                            playerBullet4[i].fire = false;

                            playerBullet5[i] = new BULLET(); // 총알 배열 받아오고 초기화
                            playerBullet5[i].x = 0;
                            playerBullet5[i].y = 0;
                            playerBullet5[i].fire = false;

                            playerBullet6[i] = new BULLET(); // 총알 배열 받아오고 초기화
                            playerBullet6[i].x = 0;
                            playerBullet6[i].y = 0;
                            playerBullet6[i].fire = false;
                        }
                    }
                }
            }
        }

    }

    public class Enemy // 적 클래스
    {
        public int enemyX; //적 X좌표
        public int enemyY; //적 Y좌표

        public Enemy()
        {
            //적 좌표 초기화
            enemyX = 77;
            enemyY = 12;
        }

        public void EnemyDraw()// 적 그리기
        {
            string enemy = "<-0->"; // 문자열로 표현
            Console.SetCursorPosition(enemyX, enemyY); //좌표 설정
            Console.Write(enemy); //출력
        }

        public void EnemyMove()// 적 행동
        {
            Random rand = new Random(); // 랜덤
            enemyX--; //왼쪽으로 움직임

            if(enemyX < 2)// 화면 왼쪽 넘어가면 새로 좌표 잡아라
            {
                enemyX = 75; //좌표 77
                enemyY = rand.Next(2, 22); // 2~21
            }    


        }
    }

    //아이템 클래스
    public class Item
    {
        public string ItemName;
        public string ItemSprite;
        public int itemX = 0;
        public int itemY = 0;
        public bool ItemLife = false;

        public void ItemDraw()
        {
            Console.SetCursorPosition(itemX, itemY);
            ItemSprite = "Item★";
            Console.Write(ItemSprite);
        }

        public void ItemMove()
        {
            /*
            if (itemX <= 1 || itemY <= 1)
            {
                ItemLife = false;
            }
            */
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            Player player = new Player(); // 플레이어 생성
            Enemy enemy = new Enemy(); // 적 생성 

            //유니티처럼 속도 프레임 속도
            int dwTime = Environment.TickCount; // 1/1000 초가 흐른다.

            while(true) //무한반복
            {
                // dwTime = Environment.TickCount; // 위에 dwTime 여기로 옮기면 1/1000초 단위로 흐르는걸 볼 수 있다.
                // Console.WriteLine(dwTime);

                //0.05초 지연
                if(dwTime + 50 < Environment.TickCount)
                {
                    //현재시간 셋팅
                    dwTime = Environment.TickCount;
                    Console.Clear(); // 0.05초 마다 지워주고 그려주고 무한반복됨

                    //플레이어 그리기
                    player.GameMain();
                    
                    //총알 그리기
                    if(player.itemCount == 0)
                    {
                        player.BulletDraw();
                    }
                    else if(player.itemCount == 1)
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                        
                    }
                    else if(player.itemCount == 2)
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                        player.BulletDraw3();
                    }
                    else if (player.itemCount == 3)
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                        player.BulletDraw3();
                    }
                    else if (player.itemCount == 4)
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                        player.BulletDraw3();
                    }
                    else
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                        player.BulletDraw3();
                    }

                    //적 이동
                    enemy.EnemyMove(); 

                    //적 그리기
                    enemy.EnemyDraw();

                    //적과의 충돌처리
                    player.ClashEnemyAndBullet(enemy);
                }
            }
        }
    }
}
