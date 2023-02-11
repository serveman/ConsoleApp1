using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.NewFolder1._0210
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Solution021101 s = new Solution021101();
            s.coinThrow();
            Console.ReadKey();
        }
    }

    internal class Solution021101
    {
        public void coinThrow()
        {
            Random roll = new Random();
            string result = (roll.Next(1, 3) == 1) ? "heads" : "tails";
            Console.WriteLine(result);
        }
    }
}
