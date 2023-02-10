using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.NewFolder1._0210
{
    internal class ProgramBase
    {
        static void Main(string[] args)
        {
            Solution0210 solution0210 = new Solution0210();

            solution0210.ExampleArrayAndForeach();
            Console.ReadKey();
        }
    }

    public class Solution0210
    {
        public void ExampleArrayAndForeach()
        {
            string[] names = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

            foreach ( string name in names )
            {
                if ( name.ToUpper().StartsWith("B") )
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}