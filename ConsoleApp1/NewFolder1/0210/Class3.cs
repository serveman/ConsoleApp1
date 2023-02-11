using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.NewFolder1._0210
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            Solution021102 s = new Solution021102();

            s.isCorrectBlocks();
        }
    }

    internal class Solution021102
    {
        public void isCorrectBlocks()
        {
            int[] numbers = { 4, 8, 15, 16, 23, 42 };
            int total = 0;
            bool found = false;

            foreach (int number in numbers)
            {
                total += number;
                if (number == 42) found = true;
            }
            if (found) Console.WriteLine("Set contains 42");

            Console.WriteLine($"Total: {total}");
        }
    }
}
