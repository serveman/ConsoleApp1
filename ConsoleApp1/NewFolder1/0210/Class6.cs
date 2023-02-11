using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.NewFolder1._0210
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            Solution021105 s = new Solution021105();
            s.RollPlayingGame();

        }
    }

    internal class Solution021105
    {
        public void RollPlayingGame()
        {
            Random r = new Random();

            int heroHP = 10;
            int monsterHP = 10;

            do
            {
                int damage = r.Next(1, 11);

                monsterHP -= damage;
                Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monsterHP}");
                if (monsterHP <= 0) continue;

                damage = r.Next(1, 11);

                heroHP -= damage;
                Console.WriteLine($"Hero was damaged and lost {damage} health and now has {heroHP} health.");
            } while (heroHP > 0 && monsterHP > 0);

            Console.WriteLine(((heroHP > monsterHP) ? "Hero" : "Monster") + " wins!");
        }
    }
}
