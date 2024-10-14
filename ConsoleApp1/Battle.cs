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

        public static void BattleTime(Pokemon pokemon)
        {

            Console.Clear();

            int moveChoice;
            int playerDamage;
            int enemyDamage;

            //set enemy stats randomly

            Random randomEnem = new Random();
            int enemyType = randomEnem.Next(1, 4);

            Pokemon enemy = new Pokemon();

            switch (enemyType)
            {
                case 1:
                    enemy = new Squirtle("Squirtle", "Squirtle");
                    goto battle;

                case 2:
                    Bulbasaur enemy = new Bulbasaur("Bulbasaur", "Bulbasaur");
                    goto battle;

            }

        battle: 

            //Battle output
            Console.WriteLine("Enemy: {0}", enemy.mPokeName);
            Console.WriteLine("Enemy HP: {0}", enemy.mHP);

            Console.WriteLine("=========================");

            Console.WriteLine("You: {0}", pokemon.mName);
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
                    Functions.Space();

                    //check if enemy dead
                    if (enemy.mHP <= 0)
                    {
                        Win(pokemon);
                        goto end;
                    }

                    goto enemy;

                case 2:

                    //player turn
                    pokemon.AttackAccuracy(enemy);
                    Console.WriteLine("You use Attack Accuracy and decreased enemy {0} accuracy by 2!", enemy.mPokeName);
                    Functions.Space();

                    //enemy turn
                    goto enemy;

                case 3:

                    //player turn
                    pokemon.AttackBuff();
                    Console.WriteLine("You use Attack Buff!");
                    Functions.Space();

                    //enemy turn
                    goto enemy;
            }

        enemy:

            Random random = new Random();
            int enemyMove = random.Next(1, 4);

            switch (enemyMove)
            {
                case 1:
                    //enemy turn
                    enemyDamage = pokemon.AttackOffensive(pokemon, 0);
                    Console.WriteLine("Enemy used Attack Offsensive and did {0} damage to {1}!", enemyDamage, pokemon.mName);
                    Functions.Continue();

                    if (pokemon.mHP <= 0)
                    {
                        Lose(pokemon);
                        goto end;
                    }

                    goto battle;

                case 2:
                    //enemy turn
                    enemy.AttackAccuracy(pokemon);
                    Console.WriteLine("Enemy used Attack Accuracy and decreased your {0} accuracy by 2!", pokemon.mName);
                    Functions.Continue();

                    //player turn
                    goto battle;

                case 3:
                    //player turn
                    enemy.AttackBuff();
                    Console.WriteLine("Enemy used Attack Buff!");
                    Functions.Continue();

                    //enemy turn
                    goto battle;
            }

        end:
            Console.WriteLine("end");

        }

    }
}
