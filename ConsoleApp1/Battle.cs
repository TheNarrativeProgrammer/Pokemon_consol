using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Battle
    {

        //num attacks in battle times level

        //win
        public static void Win(Pokemon pokemon)
        {
            Console.Clear();

            //write exp gained
            //pokemon.mXP +=

            //gain random amount of money
            Random random = new Random();
            int moneyGained = random.Next(10, 20);

            //player.mMoney += moneyGained

            Console.WriteLine("{0} won! You gained {1} xp and {2} money", pokemon.mName, moneyGained, moneyGained);
        }

        public static void Lose(Pokemon pokemon)
        {
            Console.Clear();

            //no exp gained

            //lose money - add 
            Random random = new Random();
            int moneyGained = random.Next(10, 20);

            //player.mMoney -= moneyGained

            Console.WriteLine("{0} lost.... You gained no xp and lost {2} money", pokemon.mName, moneyGained, moneyGained);

        }

        public static void BattleTime(Pokemon pokemon, Pokemon enemy)
        {


        }

    }
}
