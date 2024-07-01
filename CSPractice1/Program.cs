using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPractice1
{
    class Box
    {
        public int width { get; set; }
        private int height;

        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else { throw new Exception(); }
            }
        }
    }
    class Sample
    {
        public static int value;
        static Sample()
        {
            value = 10;
            Console.WriteLine("정적 생성자 호출");
            // 클래스 변수가 사용된다든가 하는 Sample이 언급될 때 바로 호출된다. 인스턴스가 생성되지 않아도 호출된다. 
        }
        public Sample()
        {
            Console.WriteLine("(인스턴스)생성자 호출");
        }
        ~Sample()
        {
            Console.WriteLine("소멸자 호출");
        }
    }
    class MyMath
    {
        public static int classVar = 1;// 클래스
        public int instanceVar = 2;// 인스턴스
        public static int Abs(int input)
        {
            Console.WriteLine(classVar);
            // Console.WriteLine(instanceVar); // 클래스 메서드에서 인스턴스 변수 접근 불가. 객체가 없기 때문에 사용할 수 없다. 
            return (input >= 0 ) ? input : -input;
        }

        public static double Abs (double input) { return 0; }
        // 메서드 시그네이처 (이름, 매개변수)가 겹쳐서는 안됨
        // public static double Abs (int input) { return 0; }
    }
    class FirstClass
    {
    }
    internal class Program
    {
        class Test
        {
            public int value = 10;
        }
        static void Change(Test t)
        {
            t.value = 20;
        }
        class ThirdClass
        {

        }
        static void Main(string[] args)
        {
            // 컨텍스트 키워드
            // var abc = "Hello World";
            // int void = 10;
            // Console.WriteLine(void);

            // 한 줄 주석
            /* 
             *
             *	여러 줄 주석
             */
            /*** XML 주석 - 문서화할 때 사용 ***/

            // 출력
            Console.WriteLine("Hello World");
            Console.Write("뉴라인x(개행x)");

            // 정수형
            Console.WriteLine(52 + 4 - 1); // 52
                                           // 사칙 연산자 = 산술 연산자 = Arithmetic Operator
                                           // + - * / %

            // 실수 (Real Number)
            Console.WriteLine(52.0);

            // 문자 (Character)
            Console.WriteLine('A');
            Console.WriteLine('가');

            // 문자열 (String)
            Console.WriteLine("Hello World");
            // 이스케이프 문자
            Console.WriteLine("미\n\\림\t마\"고");
            // 문자열 연결 연산자 (Concatenation Operator)
            Console.WriteLine("Hello" + " " + "World");
            // 문자열 인덱스 접근 [ ]
            Console.WriteLine("Hello World"[4]); // 'o'
                                                 // Console.WriteLine("Hello World"[100]); // 예외발생

            // 주의
            Console.WriteLine('가' + '힣');
            // 문자열연결연산자X 덧셈 연산자로 인식 

            // 논리 (Boolean)
            Console.WriteLine(true);
            Console.WriteLine(false);

            // 비교 연산자 (Comparison Operator)
            // == != > < >= <=
            // 논리 연산자 (Logical Operator)
            // && || !
            Console.WriteLine(!true);
            Console.WriteLine(true && false);
            Console.WriteLine(true || false);

            // #1 12-4. 변수
            string name = "문자열 자료형";

            // #1 12-5. 복합대입연산자
            // += -= *= /= %=
            string output = "Hello"; ;
            output += " World";
            Console.WriteLine(output);

            // #1 12-6. 증감 연산자
            int number = 10;
            Console.WriteLine(number++);// 10
            Console.WriteLine(++number);// 12
            Console.WriteLine(number--);// 12
            Console.WriteLine(--number);// 10

            // #1 12-8 var 키워드
            var varnumber = 20;
            // var abc; // x. 반드시 초기화 해줘야 함

            // #1 12-9 입력
            string input = Console.ReadLine();
            Console.WriteLine(input);

            // #1 12-10 자료형변환
            // 굉장히 중요

            // #2 13-1. if 조건문
            bool condition = true;
            if ( condition)
            {
                // true
            }
            else if ( condition )
            {
                // true2
            }
            else
            {
                // other
            }

            // #2 13-2. switch 조건문
            int v = 0;
            switch(v)
            {
                case 0:
                    // 0
                    break;
                default:
                    // other
                    break;
            }

            // #2 13-6. 삼항연산자
            Console.WriteLine(number % 2 != 1 ? "짝수" : "홀수");

            // #3 14-1. 반복문과 배열
            int[] intArray = new int[100];
            Console.WriteLine(intArray[99]);

            // #3 14-2. while 반복문
            int i = 0;
            int[] intArray2 = { 52, 273, 32 };
            while (i < intArray2.Length) {
                Console.WriteLine(intArray2[i]);
                i++; // 탈출을 위한 변수
            }

            // #3 14-6. foreach 반복문
            string[] foreachArray = { "사과", "배", "포도" };
            foreach (var item in foreachArray)
            {
                Console.WriteLine(item);
            }

            // #4 21-2. 클래스 사용
            Random random = new Random();
            Console.WriteLine(random.Next(1, 7));
            Console.WriteLine(random.Next(1, 7));
            Console.WriteLine(random.Next(1, 7));
            Console.WriteLine(random.Next(1, 7));
            Console.WriteLine(random.Next(1, 7));
            Console.WriteLine(random.Next(1, 7));

            Console.WriteLine(Math.Abs(-9)); //9
            Console.WriteLine(Math.Ceiling(52.273)); //53
            Console.WriteLine(Math.Floor(52.273)); //52
            Console.WriteLine(Math.Max(52, 273)); //273
            Console.WriteLine(Math.Min(52, 273)); //52
            Console.WriteLine(Math.Round(52.273)); //52
            Console.WriteLine(Math.PI); //3.14159265358979

            // #4 21-3. 클래스 생성

            // #4 21-4. 인스턴스 변수
            User user1 = new User();
            user1.name = "이미림";
            user1.phoneNumber = "010-0000-9999";

            Product p1 = new Product();
            p1.name = "어른폰";
            p1.price = 999999;

            Product p2 = new Product() { price = 100000, name = "아이폰"};// 이것이 생성자를 무리하게 많이 만들어야 하는 수고를 덜어줌
            Product p3 = new Product() { price = 100000 };// 일부만 초기화도 가능함

            // #4 21-5. 클래스 변수
            Console.WriteLine(Product.TAX_RATIO);
            // Console.WriteLine(p1.TAX_RATIO);// 인스턴스.클래스변수 로 접근하는 건 허용하지 않는다!!!

            // #5 22-3. 클래스 메서드

            // #5 22-6. 생성자(+ 정적 생성자)
            Console.WriteLine("첫 번째 위치");
            // Sample의 정적 생성자가 딱1번 호출됨
            Console.WriteLine(Sample.value);
            Console.WriteLine("두 번째 위치");
            Sample sample = new Sample();
            Console.WriteLine("세 번째 위치");

            // #5 22-7. 소멸자

            // #5 22-8. 속성(Property)
            Box b = new Box();
            b.width = 100;
            b.Height = 100;
            // b.Height = -100; // 예외 발생

            // #5 22-9. 값 복사와 참조복사
            Test test = new Test();
            test.value = 100;// value: 100
            Change(test);// value: 20
            Console.WriteLine(test.value);// value: 20. 참조로 받았기 때문에 값이 바뀐다. 

            // #6 23-4. is 키워드 (+as 키워드)
            List<Animal> animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Dog(), new Cat(), new Cat(),
            };
            foreach (var item in animals)
            {
                item.Eat();
                item.Sleep();
                if ( item is Dog )
                {
                    ((Dog)item).Bark();
                    Console.WriteLine("Dog");
                }
                else if ( item is Cat )
                {
                    Console.WriteLine("Cat");
                    var cat = item as Cat;
                    if (cat!=null) cat.Meow(); // as를 사용할 경우 null이 아닌지에 대한 예외처리가 필요하다. 
                }
            }

            // #6 23-6. 상속의 생성자
            Child child = new Child();// 부모 생성자가 먼저 호출되고 자식 생성자가 호출된다. 
            Child child2 = new Child("input2");
        }
    }
}
