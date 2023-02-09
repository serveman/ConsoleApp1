using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            s.daysUntilExpiration();
            Console.ReadKey();
        }
    }

    internal class Solution
    {
        public void daysUntilExpiration()
        {
            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            // Your code goes here
            if (daysUntilExpiration == 0)
            {
                Console.WriteLine("Your subscription has expired.");
            }
            else if (daysUntilExpiration <= 1)
            {
                Console.WriteLine("Your subscription expires whthin a day!");
                Console.WriteLine($"Renew now and save {discountPercentage = 20}%!");
            }
            else if (daysUntilExpiration <= 5)
            {
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
                Console.WriteLine($"Renew now and save {discountPercentage = 10}%!");
            }
            else if (daysUntilExpiration <= 10)
            {
                Console.WriteLine("Your subscription will expire soon. Renew now!");
            }
            else
            {

            }

            Console.WriteLine($"\ndaysUntilExpiration = {daysUntilExpiration}");
            Console.WriteLine($"discountPercentage = {discountPercentage}%");
        }
    }
}
