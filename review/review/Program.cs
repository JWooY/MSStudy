using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace review
{
    class Program
    {
        static void Main(string[] args)
        {
            //로딩바 시작화면
            //게임 스토리1
            //비주얼노벨만들어보기

            Console.Write("새로운 시작 중입니다. 조금만 기다려주세요!");
            Console.Write("□□□□□");
            Thread.Sleep(2000);
            Console.Clear();

            Console.Write("새로운 시작 중입니다. 조금만 기다려주세요!");
            Console.Write("■□□□□");
            Thread.Sleep(2000);
            Console.Clear();

            Console.Write("새로운 시작 중입니다. 조금만 기다려주세요!");
            Console.Write("■■□□□");
            Thread.Sleep(2000);
            Console.Clear();

            Console.Write("새로운 시작 중입니다. 조금만 기다려주세요!");
            Console.Write("■■■□□");
            Thread.Sleep(2000);
            Console.Clear();


            Console.Write("새로운 시작 중입니다. 조금만 기다려주세요!");
            Console.Write("■■■■□");
            Thread.Sleep(2000);
            Console.Clear();

            Console.Write("새로운 시작 중입니다. 조금만 기다려주세요!");
            Console.Write("■■■■■");
            Thread.Sleep(2000);
            Console.Clear();

            Console.WriteLine("엔터키를 눌러 남자를 꺠우세요!");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("눈을 떴다. 머리가 지끈거린다.");
            Console.ReadLine();
            Console.Clear();

            Console.Write("\"윽 머리야... 여긴 어디지?\"");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("주위를 둘러보니 창문하나 없는 삭막한 방이 보인다.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\"있는거라곤 책상이랑... 문?\"");
            Console.ReadLine();
            Console.Clear();

            Console.Write("한쪽 벽을 바라보니 중앙에 낡은 나무 문이 보인다.");
            Console.ReadLine();
            Console.Clear();

            Console.Write("\"대체 이게.. 윽!\"");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("갑자기 머리가 쪼개질 듯 아파온다.");
            Console.ReadLine();
            Console.Clear();

            Console.Write("\"아아악!\"");
            Console.ReadLine();
            Console.Clear();

            Console.Write("영원할 것만 같았던 통증이 점차 잦아들며 머릿속에서 목소리가 울려퍼졌다.");
            Console.ReadLine();

            Console.Write("기억이 초기화되었습니다. 남은 시간 24:00:00");
            Console.ReadLine();
            Console.Clear();

            Console.Write("\"이게 무슨...\"");
            Console.ReadLine();
            Console.Clear();


            Console.Write("혼란스러움을 추스릴 새도 없이, 문 쪽에서 인기척이 들려온다.");
            Console.ReadLine();
            Console.Clear();

            Console.Write("똑똑");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("문을 여시겠습니까?");
            Console.WriteLine("1. 문을 연다. / 2. 무시한다.");

            string choice = Console.ReadLine();
            Console.Clear();

            if (choice == "1")
            {
                Console.WriteLine("혼란과 두려움을 간신히 진정시킨 뒤, 냉정히 생각해보았다.");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("\"무섭지만... 일단 뭐든 해야해 모든게 의문 투성이야\"");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("영원히 여기 있을 수는 없는 노릇이다.");
                Console.ReadLine();
                Console.WriteLine("치솟는 두려움을 가라앉히고 문을 열었다");
                Console.ReadLine();

            }
            else if (choice == "2")
            {
                Console.WriteLine("모든것이 두렵다. 저 존재가 누구든, 나를 해칠지도 모르지 않는가?");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("\"...그래 괜히 위험을 감수 할 필요는 없지.\"");
                Console.ReadLine();
                Console.WriteLine("\"조금만... 조금만 더 생각해보자\"");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("그렇게 영원한 24시간이 반복되었다.");
                Console.ReadLine();
                Console.WriteLine("Bad End");
                Console.ReadLine();
                Environment.Exit(0);

            }
            else
            {
                Console.WriteLine("잘못된 선택입니다. 1 또는 2를 입력해주세요.");
            }

            Console.WriteLine("그 앞엔 어떤 작은 키의 여자가 놀란 표정으로 서있었다.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\"으앗! 놀래라! 뭐야 진짜 누가 있잖아?\"");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("쏟아져나오려던 비명을 간신히 집어삼키며 물었다.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\"누, 누구세요?\"");
            Console.ReadLine();
            Console.WriteLine("\"그걸 나한테 물으면 어쩌자는 거에요?\"");
            Console.ReadLine();
            Console.WriteLine("\"그쪽이 저를 가둔 거 아니예요?\"");
            Console.ReadLine();
            Console.WriteLine("\"그건 제가 할 말이거든요?\"");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("어이가 없다는 듯 헛웃음 치던 그녀는 이내 심각한 표정이 되었다.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\"당신도 아니라면...\"");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("그녀는 잠시 말을 멈추고, 눈을 감았다가 다시 뜨며 말을 이었다.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\"사실... 저도 갇힌 지 얼마 안 됐어요.\"");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("그녀는 낮은 목소리로 말했다..");
            Console.ReadLine();
            Console.WriteLine("그녀의 말에 나는 잠시 침묵했다. 그럼, 여긴 대체...?");
            Console.ReadLine();
            Console.WriteLine("그때, 나는 그녀의 어깨너머로 보이는 방 침대 아래에서 뭔가 이상한 것을 발견했다.");
            Console.ReadLine();
            Console.WriteLine("침대 아래를 살펴보니, 사람 하나 겨우 들어갈 만한 작은 문이 있었다.");
            Console.ReadLine();
            Console.WriteLine("나는 조심스럽게 그 문을 가리켰다.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\"어? 저기... 저 문 좀 보세요. 혹시 저걸 통해 나갈 수 있을지도 몰라요.\"");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("그녀는 내 손끝을 따라 문을 보았다. 그녀는 깜짝놀라 말했다");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\"이, 이런곳에 문이?\"");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("나는 얼른 침대를 옆으로 밀어내곤 다락문처럼 생긴 낡은 나무 문을 바라보았다.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\"뭐가 뭔지는 모르겠지만... 알아낼 방법은 이거 하나뿐인 것 같네요\"");
            Console.ReadLine();
            Console.WriteLine("\"그, 그렇네요 그럼...\"");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("나는 조심스럽게 문을 열어보았다.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("남은 시간 23:00:00");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("갑작스럽게 아까전 울려퍼진 목소리가 들려왔다. 순간 놀라서 몸을 흠칫 떨었다");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\"뭐예요? 무슨 문제 있어요?\"");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("어리둥절한 표정으로 바라보는 그녀를 보며 생각했다.");
            Console.ReadLine();
            Console.WriteLine("그녀에겐 이 목소리가 들리지 않는건가?");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\"안갈거예요? 무서운건가? 참나, 덩치는 산만해가지고... 그럼 제가 먼저 가죠\"");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("멈춰선 나를 답답해 하던 그녀가 문을 여는 순간, 어두운 좁은 통로가 펼쳐졌다. 통로는 온통 어둠뿐이었다.");
            Console.ReadLine();
            Console.WriteLine("그녀는 잠시 망설였지만, 결국 한 발자국씩 그 어두운 통로로 들어갔다.");
            Console.ReadLine();
            Console.WriteLine("그녀가 먼저 앞장서자, 나는 그 뒤를 따랐다. 여전히 긴장된 상태였지만, 이 통로를 걷다보면 탈출할 수 있는 길이 나올지도 모른다는 희망이 생겼다.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\"넘어지지 않도록 조심하세요.\"");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("내가 조심스럽게 속삭였다.");
            Console.ReadLine();
            Console.WriteLine("앞장서던 그녀는 고개를 끄덕이며, 조용히 말했다.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\"그래요. 그런데... 당신은 당신이 누군지 아나요??\"");
            Console.ReadLine();
            Console.WriteLine("\"네? 그게 무슨?\"");
            Console.ReadLine();
            Console.WriteLine("\"전 아무것도 기억이 안나요\"");
            Console.ReadLine();
            Console.WriteLine("\"그건...\"");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("긴장 때문에 생각도 못하고 있던 부분");
            Console.ReadLine();
            Console.WriteLine("기억이... 없다");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\"그러고 보니... 아무, 아무런 기억이 안나요\"");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("내 누구인지 무엇을 했었는지, 처음부터 존재하지 않았던 것 처럼 아무런 기억이 나지 않는다.");
            Console.ReadLine();
            Console.WriteLine("그런데... 기이하게도 이 상황이 낯설지 않다. 어째서지?");
            Console.ReadLine();
            Console.WriteLine("숨이 멎을듯한 충격에 휩싸인 나를 보며 그녀가 말했다.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\"반응을 보니... 그쪽도 마찬가지인가 보네요\"");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("그때, 한참을 걸어가고 있던 통로쪽에서 시원한 바람이 불어왔다.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\"어?\"");
            Console.ReadLine();
            Console.WriteLine("\"바람? 당신도 느껴지죠?\"");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("나는 황급히 고개를 끄덕이며 말했다.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\"바깥과 이어져있나봐요! 얼른 가봐요!\"");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("그녀는 잠시 고민하더니 고개를 끄덕였다");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\"그러죠. 얼른가요!\"");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("처음의 조심성은 어디가고 서로가 미친듯이 달리기 시작했다.");
            Console.ReadLine();
            Console.WriteLine("무작정 앞을 보며 달리던 도중, 희미한 빛이 보이기 시작한다.");
            Console.ReadLine();
            Console.WriteLine("그 끝에 다다르자 서서히 속도를 줄였다.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\"하아..하아.. 여긴...\"");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("밝은 빛에 어둠에 적응되어있던 눈이 찌푸려지며 새로운 공간을 둘러보았다.");
            Console.ReadLine();
            Console.WriteLine("이내 뒤따라온 그녀가 기대감 어린 목소리로 물었지만 난 아무 말도 할 수 없었다.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\"하아.. 하아.. 밖! 밖인가요?\"");
            Console.ReadLine();
            Console.WriteLine("\"...\"");
            Console.ReadLine();
            Console.WriteLine("\"하아..스읍  왜그래요? 하아..\"");
            Console.ReadLine();
            Console.Clear();

            // 일단 급전개
            Console.WriteLine("그녀도 이내 얼빠진 표정으로 바깥을 바라보았다.");
            Console.ReadLine();
            Console.WriteLine("우리가 도망쳐 나갔다고 생각한 곳은 사실 또 다른 감옥이었다.");
            Console.ReadLine();
            Console.WriteLine("이곳은 실험의 일환으로 만들어진 '테스트 필드'였고, 우리가 살고 있다고 믿었던 현실은 전혀 다른 가상 현실이었다.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\"이건 무슨... 게임 같은 거잖아?\" 그녀는 당황하며 말했다.");
            Console.ReadLine();
            Console.WriteLine("\"그럼 우리가 실험의 일부였다는 건가?\" 나는 경악하며 물었다.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("그들은 알게 되었다. 자신들의 모든 것이 조작된 세계였다는 사실을.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\"말도안돼.. 그럼 우린...?\"");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("그때, 형연할 수 없는 거대한 무언가가 우리를 주시하는 기분이 들었다.");
            Console.ReadLine();
            Console.WriteLine("몸을 도저히 가눌수가 없다. 아무런 생각도 할 수 없다. 나는 그저 공포에 질리는 것 밖에 할 수 없었다.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("저게 대체 무엇이란 말인가.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("그 존재가 손짓하자 생각이 점점 느려져간다. 감각이 사라져간다..");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("깊게 가라앉는 듯한 의식속에서 작은 목소리가 멀어지듯 울려퍼진다");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("1382번째 실험 실패! 새로운 실험을 진행하겠습니다.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("...");
            Console.ReadLine();

            Console.WriteLine("...");
            Console.ReadLine();

            Console.WriteLine("...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("기억이 초기화 되었습니다. 남은 시간 24:00:00");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("The End");

        }
    }
}
