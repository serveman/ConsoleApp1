using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.NewFolder1._0210
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            Solution021104 s = new Solution021104();
            s.FizzBuzz();
        }
    }

    internal class Solution021104
    {
        public void FizzBuzz()
        {
            string Fizz = "";
            string Buzz = "";

            for(int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0) Fizz = "Fizz"; else Fizz = "";
                if (i % 5 == 0) Buzz = "Buzz"; else Buzz = "";

                Console.WriteLine($"{i} - {Fizz}{Buzz}");
            }
        }
    }
}
