using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPractice1
{
    internal class Child : Parent
    {
        public Child() : base("input") // 상수로 넘김
        {
            Console.WriteLine("자식 생성자 호출");
        }

        public Child(string input) : base (input) // 변수로 넘김
        {
            Console.WriteLine("Child(string input)");
        }
    }
}
