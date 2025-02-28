using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Program
    {
        struct Item
        {
            public string Name;
            public int Count;
        }

        class InventorySystem
        {
            //최대 아이템 개수(배열 크기)
            const int MAX_ITEMS = 10;
            private Item[] items = new Item[MAX_ITEMS]; // 흩어진 아이템 기능을 담을 배열. 하나의 클래스로 묶기 위함.

            //아이템 추가 함수
            public void AddItem(string name, int count)
            {
                for (int i = 0; i < MAX_ITEMS; i++)
                {
                    if (items[i].Name == name)  //이미 있는 아이템이면 개수 증가
                    {
                        items[i].Count += count;
                        return;
                    }
                }

                //빈 슬롯에 새로운 아이템 추가
                for (int i = 0; i < MAX_ITEMS; i++)
                {
                    if (string.IsNullOrEmpty(items[i].Name)) // IsNullOrEmpty 말고 딴거 쓸 수 있나?
                    {
                        items[i].Name = name;
                        items[i].Count = count;
                        return;
                    }
                }
                Console.WriteLine("인벤토리가 가득 찼습니다.");
            }

            //아이템 제거 함수
            public void RemoveItem(string name, int count)
            {
                for (int i = 0; i < MAX_ITEMS; i++)
                {
                    if (items[i].Name == name) //이름하고 같은지
                    {
                        if (items[i].Count >= count) //개수가 충분하면 차감
                        {
                            items[i].Count -= count;
                            if (items[i].Count == 0) //개수가 0이면 삭제
                            {
                                items[i].Name = null;
                            }
                            return;
                        }
                        else
                        {
                            Console.WriteLine("아이템 개수가 부족합니다!");
                            return;
                        }
                    }
                }
                Console.WriteLine("아이템을 찾을 수 없습니다!");
            }

            //인벤토리 출력 함수
            public void ShowInventory()
            {
                Console.WriteLine(" < 현재 인벤토리 > ");
                bool isEmpty = true;

                for (int i = 0; i < MAX_ITEMS; i++)
                {
                    if (!string.IsNullOrEmpty(items[i].Name)) // IsNullOrEmpty를 쓰면 null이나 빈 문자열 동시에 처리 가능함
                                                              // (items[i].Name != null) 였지만 IsNullOrEmpty 채용. 이유는 위와 같음.
                    {
                        Console.WriteLine($"{items[i].Name} (x{items[i].Count})");
                        isEmpty = false;
                    }
                }

                if (isEmpty)
                {
                    Console.WriteLine("인벤토리가 비어 있습니다.");
                }
            }

        }
        static void Main(string[] args)
        {
            InventorySystem inventory = new InventorySystem();
            
            //테스트 : 아이템 추가
            inventory.AddItem("포션", 5);
            inventory.AddItem("칼", 1);
            inventory.AddItem("포션", 3); // 포션 개수 추가 됨.
            inventory.ShowInventory();

            //아이템 사용
            Console.WriteLine("포션 2개 사용");
            inventory.RemoveItem("포션", 2);
            inventory.ShowInventory();

            //테스트 : 없는 아이템 제거
            Console.WriteLine("방패 1개 제거 시도");
            inventory.RemoveItem("방패", 1);
            inventory.ShowInventory();

            //테스트 : 모든 포션 제거
            Console.WriteLine("포션 6개 사용(초과 사용 테스트)");
            inventory.RemoveItem("포션", 6);
            inventory.ShowInventory();


        }
    }
}
