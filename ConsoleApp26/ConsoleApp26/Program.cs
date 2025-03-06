using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            // <<<<          Linq 쓰는중           >>>>

            //sort / OrderBy 사용
            /*
            string[] names = { "Charlie", "Alice", "Bob" };
            var sortedNames = names.OrderBy(n => n); // names.OrderBy 내부적으로 반복문을 돌려서 처리한다음 출력된다

            // var로 선언해주는건데 배열로 반환받고싶다면
            // string[] sortedNames = names.OrderBy(n => n).ToArray();
            
            foreach (var name in sortedNames)
            {
                Console.WriteLine(name);
            }

            var firstName = names.First(n => n.StartsWith("A"));

            Console.WriteLine($"First name starting with A : {firstName}");
            */

            //메서드 / 쿼리
            /* 
            //메서드 구문, 쿼리 구문
            int[] nums = { 5, 3, 8, 1 };

            //메서드 구문
            var sortedMeshod = nums.OrderBy(n => n); // 내림차순
            // var sortedMeshod = nums.OrderByDescending(n => n); // 오름차순

            //쿼리 구문
            var sortedQuery = from n in nums
                              orderby n
                              select n;

            Console.WriteLine("Meshod syntax : ");
            foreach (var n in sortedMeshod)
                Console.WriteLine(n);

            Console.WriteLine("Query syntax : ");
            foreach (var n in sortedQuery)
                Console.WriteLine(n);
            */

            //select()로 길이 추출
            /*
            string[] words = { "apple", "banana", "cherry" };

            //select()로 길이 추출

            var lengths = words.Select(w => w.Length);

            foreach(var length in lengths)
            {
                Console.WriteLine(length);
            }
            */

            //select 개념
            //Linq 쿼리 연산자 중 하나
            //각 요소를 변환하여 새로운 컬렉션을 생성
            /*
            string[] words = { "apple", "banana", "cherry" };

            var upperWords = words.Select(w => w.ToUpper()); // 대문자 변환

            foreach(var word in upperWords)
            {
                Console.WriteLine(word);
            }
            */

            //sum알고리즘
            /*
            int[] data = { 1, 2, 3, 4, 5 };
            int sum = 0;

            foreach (var d in data)
                sum += d;

            Console.WriteLine($"Sum : {sum}");
            */

            //여러가지 간편한 계산
            /*
            int[] data = { 53, 12, 73, 74, 95 };

            // + 배열의 개수 구하기
            int count = data.Length;
            Console.WriteLine($"Cout : {count}");

            // + 평균 구하기
            double avg = data.Average();
            Console.WriteLine($"Average : {avg:F2}");

            // + 최대값 구하기
            int max = data.Max();
            Console.WriteLine($"Max : {max}");

            // + 최소값 구하기
            int min = data.Min();
            Console.WriteLine($"Min : {min}");
            */

            //근삿값 구하기: NEAR 알고리즘
            //배열에서 특정 값에 가장 가까운 값을 찾는 예제
            /*
            int[] data = { 10, 12, 20, 25, 30 };
            int target = 22;
            int nearest = data[0];

            foreach(var d in data)
            {
                if (Math.Abs(d - target) < Math.Abs(nearest - target))
                    nearest = d;
            }

            Console.WriteLine($"Nearest to {target} : {nearest}");
            */

            //순위구하기 Rank알고리즘
            //각 요소가 몇 번째로 큰지 순위를 매기는 예제
            //이건 알고리즘 한번 더 둘러보자
            /*
            int[] scores = { 90, 70, 50, 70, 60 };

            for(int i=0; i<scores.Length; i++)
            {
                int rank = 1;

                for(int j=0; j<scores.Length; j++)
                {
                    if (scores[j] > scores[i])
                        rank++;
                }
                Console.WriteLine($"Score : {scores[i]}, Rank : {rank}");
            }
            */

            /*
            int[] data = { 5, 2, 8, 1, 9 };
            Array.Sort(data);

            foreach (var d in data)
                Console.WriteLine(d);
            */

            //특정 값 검색하기: Search 알고리즘
            int[] data = { 5, 2, 8, 1, 9 };
            int target = 8;
            int index = -1;

            for(int i=0; i<data.Length; i++)
            {
                if (data[i] ==target)
                {
                    index = i;
                    break;
                }
            }
            Console.WriteLine(index >= 0 ? "$Found at index{index}" : "Not found"); // index가 0보다 크면 출력하고 아니면 낫파운드 출력

            //백준
            //프로그래머스

            //그룹화하기 : GROUP 알고리즘
            //데이터를 특정 기준으로 그룹화하기
            // 문자열 배열 선언 (과일 이름 리스트)
            string[] fruits = { "apple", "banana", "blueberry", "cherry", "apricot" };
            // LINQ의 GroupBy()를 사용하여 첫 글자를 기준으로 그룹화
            var groups = fruits.GroupBy(f => f[0]); //첫 글자로 그룹화
                                                    // 각 그룹을 순회하며 출력
            foreach (var group in groups)
            {
                // 그룹의 Key (첫 글자) 출력
                Console.WriteLine($"Key : {group.Key}");
                // 해당 그룹에 속한 모든 요소 출력
                foreach (var item in group)
                {
                    Console.WriteLine($" {item}");
                }

            }




        }
    }
}
