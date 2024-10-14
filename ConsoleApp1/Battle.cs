using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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

            Console.Clear();

            int moveChoice;
            int playerDamage;
            int enemyDamage;

        battle: 

            //Battle output
            Console.WriteLine("Enemy: {0}", enemy.mPokeName);
            Console.WriteLine("Enemy HP: {0}", enemy.mHP);

            Console.WriteLine("=========================");

            Console.WriteLine("You: {0}", pokemon.mPokeName);
            Console.WriteLine("Your HP: {0}", pokemon.mHP);

            Functions.Space();
            Console.WriteLine("Choose an action!");
            Functions.Space();

            Console.WriteLine("1. Offensive");
            Console.WriteLine("2. Accuracy");
            Console.WriteLine("3. Attack Buff");

            if (int.TryParse(Console.ReadLine(), out moveChoice) && moveChoice > 0 && moveChoice < 4)
            {
                goto action;
            }
            else
            {
                Functions.Error();
                goto battle;
            }

        action:
            switch (moveChoice)
            {
                case 1:

                    //player turn
                    playerDamage = pokemon.AttackOffensive(enemy, 0);
                    Console.WriteLine("You use Attack Offsensive and did {0} damage to {1}!", playerDamage, enemy.mPokeName);

                    //check if enemy dead
                    if (enemy.mHP <= 0)
                    {
                        Win(pokemon);
                        goto end;
                    }

                    goto enemy;

            }

        enemy:

            Random random = new Random();
            int enemyMove = random.Next(1, 4);

            if (enemyMove == 1)
            {
                //enemy turn
                enemyDamage = pokemon.AttackOffensive(pokemon, 0);
                Console.WriteLine("Enemy used Attack Offsensive and did {0} damage to {1}!", enemyDamage, pokemon.mPokeName);

                if (pokemon.mHP <= 0)
                {
                    Lose(pokemon);
                    goto end;
                }

                goto battle;
            }

        end:
            Console.WriteLine("");


        }

    }
}
