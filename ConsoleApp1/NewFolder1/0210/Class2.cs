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
            s.permission();
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

        public void permission()
        {
            string permission = "Admin|Manager";
            int level = 53;

            if(permission.Contains("Admin"))
            {
                if(level > 55)
                {
                    Console.WriteLine("Welcome, Super Admin user.");
                }
                else
                {
                    Console.WriteLine("Welcome, Admin user.");
                }
            }
            else if(permission.Contains("Manager"))
            {
                if(level >= 20)
                {
                    Console.WriteLine("Contact an Admin for access.");
                }
                else
                {
                    Console.WriteLine("You do not have sufficient privileges.");
                }
            }
            else
            {
                Console.WriteLine("You do net have sufficient privileges.");
            }
        }
    }
}
