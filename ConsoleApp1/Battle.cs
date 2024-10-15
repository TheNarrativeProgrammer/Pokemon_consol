using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Battle
    {

        public static void Win(Pokemon pokemon)
        {
            Console.Clear();

            //gain money and a level
            Story.player.money += 10;
            Story.pokemon.mLevel += 1;

            //reset all stats for next battle NOT including HP
            if (pokemon.mPokeName == "Squirtle")
            {
                pokemon.mAttack_Damage = 7;
                pokemon.mAttack_AccuracyDemoninator = 10;
                pokemon.mAttack_BuffMultiplier = 1;
                pokemon.mAttack_WeaknessMultiplier = 1;
                pokemon.mAttack_StrengthSubtractor = 0;
            }
            if (pokemon.mPokeName == "Bulbasaur")
            {
                pokemon.mAttack_Damage = 6;
                pokemon.mAttack_AccuracyDemoninator = 10;
                pokemon.mAttack_BuffMultiplier = 1;
                pokemon.mAttack_WeaknessMultiplier = 1;
                pokemon.mAttack_StrengthSubtractor = 0;
            }
            if (pokemon.mPokeName == "Charmander")
            {
                pokemon.mAttack_Damage = 8;
                pokemon.mAttack_AccuracyDemoninator = 10;
                pokemon.mAttack_BuffMultiplier = 1;
                pokemon.mAttack_WeaknessMultiplier = 1;
                pokemon.mAttack_StrengthSubtractor = 0;
            }

            Console.WriteLine("{0} won! you gained 10$ and 1 level. You now have {1} in the bank and are at level {2}!", pokemon.mName, Story.player.money, Story.pokemon.mLevel);
        }

        public static void Lose(Pokemon pokemon)
        {
            Console.Clear();

            //lose all money
            Story.player.money = 0;

            //reset all stats for next battle including HP
            if(pokemon.mPokeName == "Squirtle")
            {
                pokemon.mHP = 38;
                pokemon.mAttack_Damage = 7;             
                pokemon.mAttack_AccuracyDemoninator = 10;
                pokemon.mAttack_BuffMultiplier = 1;
                pokemon.mAttack_WeaknessMultiplier = 1;
                pokemon.mAttack_StrengthSubtractor = 0;
            }
            if(pokemon.mPokeName == "Bulbasaur")
            {
                pokemon.mHP = 42;
                pokemon.mAttack_Damage = 6;   
                pokemon.mAttack_AccuracyDemoninator = 10;
                pokemon.mAttack_BuffMultiplier = 1;
                pokemon.mAttack_WeaknessMultiplier = 1;
                pokemon.mAttack_StrengthSubtractor = 0;
            }
            if(pokemon.mPokeName == "Charmander")
            {
                pokemon.mHP = 37;
                pokemon.mAttack_Damage = 8;
                pokemon.mAttack_AccuracyDemoninator = 10;
                pokemon.mAttack_BuffMultiplier = 1;
                pokemon.mAttack_WeaknessMultiplier = 1;
                pokemon.mAttack_StrengthSubtractor = 0;
            }

            Console.WriteLine("{0} lost....you lost all your money!", pokemon.mName);

        }

        //spawning a random pokemon for battle 
        public Pokemon SpawnRandomWildPokemon ()
        {
            Random randomEnem = new Random();
            int enemyType = randomEnem.Next(1, 3);
            Pokemon enemy = new Pokemon();

            switch (enemyType)
            {
                case 1:
                    {
                        enemy = new Pikachu("Enemy Pikachu", "Pikachau");
                        break;
                    }
                case 2:
                    {
                        enemy = new Pokemon();
                        break;
                    }
                default:
                    {
                        enemy = new Pokemon();
                        break;
                    }
            }
            return enemy;
        }

        //for future use, rival pokemon generated based on pokemon user chooses
        public static Pokemon SpawnRivalPokemon(Pokemon PlayerPokemon)
        {
            Pokemon returnRivalPokemon;
            switch (PlayerPokemon.mPokeName)
            {
                case "Squirtle":
                    {
                        Bulbasaur RivalBulasaur = new Bulbasaur("Rival Bulbasaur", "Bulbasaur");
                        returnRivalPokemon = RivalBulasaur;
                        break;
                        
                    }
                case "Charamander":
                    {
                        Squirtle RivalSquirtle = new Squirtle("Rival Squirtle", "Squirtle");
                        returnRivalPokemon = RivalSquirtle;
                        break;
                        
                    }
                case "Bulbasaur":
                    {
                        Charmander RivalCharamander = new Charmander("Rival Charamander", "Charamander");
                        returnRivalPokemon = RivalCharamander;
                        break;
                    }
                default:
                    {
                        Charmander RivalCharamander = new Charmander("Rival Charamander", "Charamander");
                        returnRivalPokemon = RivalCharamander;
                        break;
                    }
            }
            return returnRivalPokemon;
        }

        public Pokemon BattleTime(Pokemon Inpokemon, UI_Battle InUIObject)
        {

            Pokemon randomEnemy = SpawnRandomWildPokemon();
            int moveChoice;
            int playerDamage;
            int enemyDamage;
            int countAttacks = 0;
            //UI_Battle UIObject = new UI_Battle();

            //InenemyPokemon = SpawnRandomWildPokemon();
            Functions.Continue();
            InUIObject.mUI_ResultsLine1 = InUIObject.mUI_ResultsLine1_String[1];
            InUIObject.FindDefendPokeArt(randomEnemy);
            InUIObject.FindPlayerPokeArt(Inpokemon);

        //set enemy stats randomly

        /*
        Random randomEnem = new Random();
        int enemyType = randomEnem.Next(1, 4);

        Pokemon enemy = new Pokemon();

        switch (enemyType)
        {
            case 1:
                enemy = new Squirtle("Squirtle", "Squirtle");
                goto battle;

            case 2:
                enemy = new Bulbasaur("Bulbasaur", "Bulbasaur");
                goto battle;

        }
        */

        battle:

            //Battle output
            //Console.WriteLine("Enemy: {0}", enemy.mPokeName);
            //Console.WriteLine("Enemy HP: {0}", enemy.mHP);

            //Console.WriteLine("=========================");

            //Console.WriteLine("You: {0}", Inpokemon.mName);
            //Console.WriteLine("Your HP: {0}", Inpokemon.mHP);

            //Functions.Space();
            //Console.WriteLine("Choose an action!");
            //Functions.Space();

            //Console.WriteLine("1. Offensive");
            //Console.WriteLine("2. Accuracy");
            //Console.WriteLine("3. Attack Buff");

            //set UI Results box
            //InUIObject.mUI_ResultsLine1 = InUIObject.mUI_ResultsLine1_String[1];//"Choose an action!"
            //reset UI
            
            Console.Clear();
            InUIObject.FindDefendPokeArt(randomEnemy);
            InUIObject.FindPlayerPokeArt(Inpokemon);

            //public string battleText = string.Format("{0} won! You gained {1} xp and {2} money", pokemon.mName, moneyGained, moneyGained);

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
                    playerDamage = Inpokemon.AttackOffensive(randomEnemy, countAttacks);
                    Console.WriteLine("You use Attack Offsensive and did {0} damage to {1}!", playerDamage, randomEnemy.mPokeName);
                    Functions.Space();
                    //Update enemy stat - health
                    randomEnemy.mHP-=playerDamage;
                    //update UI lines
                    InUIObject.mUI_ResultsLine1 = InUIObject.mUI_ResultsLine1_String[0];//blank
                    InUIObject.mUI_ResultsLine2 = InUIObject.mUI_ResultsLine2_String[1];//Tackle attack
                    InUIObject.mUI_ResultsLine3 = string.Format("and did {0} damage", playerDamage); //result of action
                    if(Inpokemon.mDidAttackLand==false)
                    {
                        InUIObject.mUI_ResultsLine4 = InUIObject.mUI_ResultsLine4_String[1];//attack missed
                    }
                    else
                    {
                        InUIObject.mUI_ResultsLine4 = InUIObject.mUI_ResultsLine4_String[0];//attack landed. Line is blank
                    }
                    InUIObject.mUI_ResultsLine5 = InUIObject.mUI_ResultsLine5_String[0];//clear prompt
                    //reset UI
                    Console.Clear();
                    InUIObject.FindDefendPokeArt(randomEnemy);
                    InUIObject.FindPlayerPokeArt(Inpokemon);

                    //check if enemy dead
                    if (randomEnemy.mHP <= 0)
                    {
                        Win(Inpokemon);
                        Inpokemon.mEXPoints += (Inpokemon.mLevel * countAttacks);
                        goto end;
                    }

                    Functions.Continue();

                    goto enemy;

                case 2:

                    //player turn
                    Inpokemon.AttackAccuracy(randomEnemy);
                    Console.WriteLine("You use Attack Accuracy and decreased enemy {0} accuracy by 2!", randomEnemy.mPokeName);
                    
                    //update UI lines
                    InUIObject.mUI_ResultsLine1 = InUIObject.mUI_ResultsLine1_String[0];//blank
                    InUIObject.mUI_ResultsLine2 = InUIObject.mUI_ResultsLine2_String[2];//Sand attack
                    if (randomEnemy.mAttack_AccuracyDemoninator <= 4)
                    {
                        InUIObject.mUI_ResultsLine3 = string.Format("Attack had on effect on {0}", randomEnemy.mPokeName); //result of action
                    }
                    else
                    {
                        InUIObject.mUI_ResultsLine3 = string.Format("and decreased {0} accuracy by 1!", randomEnemy.mPokeName); //result of action
                    }
                    if (Inpokemon.mDidAttackLand == false)
                    {
                        InUIObject.mUI_ResultsLine4 = InUIObject.mUI_ResultsLine4_String[1];//attack missed
                    }
                    else
                    {
                        InUIObject.mUI_ResultsLine4 = InUIObject.mUI_ResultsLine4_String[0];//attack landed. Line is blank
                    }
                    InUIObject.mUI_ResultsLine5 = InUIObject.mUI_ResultsLine5_String[0];//clear prompt
                    //reset UI
                    Console.Clear();
                    InUIObject.FindDefendPokeArt(randomEnemy);
                    InUIObject.FindPlayerPokeArt(Inpokemon);

                    Functions.Continue();

                    //enemy turn
                    goto enemy;

                case 3:

                    //player turn
                    Inpokemon.AttackBuff();
                    Console.WriteLine("You use Attack Buff!");
                    
                    //update UI lines
                    InUIObject.mUI_ResultsLine1 = InUIObject.mUI_ResultsLine1_String[0];//blank
                    InUIObject.mUI_ResultsLine2 = InUIObject.mUI_ResultsLine2_String[3];//Buff (sword dance)
                    InUIObject.mUI_ResultsLine3 = "your next attack does 3x damage."; //result of action
                    if (Inpokemon.mDidAttackLand == false)
                    {
                        InUIObject.mUI_ResultsLine4 = InUIObject.mUI_ResultsLine4_String[1];//attack missed
                    }
                    else
                    {
                        InUIObject.mUI_ResultsLine4 = InUIObject.mUI_ResultsLine4_String[0];//attack landed. Line is blank
                    }
                    InUIObject.mUI_ResultsLine5 = InUIObject.mUI_ResultsLine5_String[0];//clear prompt
                    //reset UI
                    Console.Clear();
                    InUIObject.FindDefendPokeArt(randomEnemy);
                    InUIObject.FindPlayerPokeArt(Inpokemon);

                    Functions.Continue();


                    //enemy turn
                    goto enemy;
            }

        enemy:

            Random random = new Random();
            int enemyMove = random.Next(1, 5);

            switch (enemyMove)
            {
                case 1: //case 1 and case 2 are enemy tackle to give a higher chance enemy will attack.

                case 2:

                    //enemy turn
                    enemyDamage = randomEnemy.AttackOffensive(Inpokemon, 0);
                    Console.WriteLine("Enemy used Attack Offsensive and did {0} damage to {1}!", enemyDamage, Inpokemon.mName);
                    Functions.Space();
                    //Update enemy stat - health
                    Inpokemon.mHP -= enemyDamage;
                    //update UI lines
                    InUIObject.mUI_ResultsLine1 = InUIObject.mUI_ResultsLine1_String[0];//blank
                    InUIObject.mUI_ResultsLine2 = InUIObject.mUI_ResultsLine2_String[4];//Tackle attack - enemy
                    InUIObject.mUI_ResultsLine3 = string.Format("and did {0} damage", enemyDamage); //result of action
                    if (randomEnemy.mDidAttackLand == false)
                    {
                        InUIObject.mUI_ResultsLine4 = InUIObject.mUI_ResultsLine4_String[1];//attack missed
                    }
                    else
                    {
                        InUIObject.mUI_ResultsLine4 = InUIObject.mUI_ResultsLine4_String[0];//attack landed. Line is blank
                    }
                    InUIObject.mUI_ResultsLine5 = InUIObject.mUI_ResultsLine5_String[1];//Prompt player to chose action
                    //reset UI
                    Console.Clear();
                    InUIObject.FindDefendPokeArt(randomEnemy);
                    InUIObject.FindPlayerPokeArt(Inpokemon);


                    if (Inpokemon.mHP <= 0)
                    {
                        Lose(Inpokemon);
                        goto end;
                    }

                    goto battle;

                case 3:
                    //enemy turn
                    randomEnemy.AttackAccuracy(Inpokemon);
                    Console.WriteLine("Enemy used Attack Accuracy and decreased your {0} accuracy by 2!", Inpokemon.mName);
                    Functions.Space();

                    //update UI lines
                    InUIObject.mUI_ResultsLine1 = InUIObject.mUI_ResultsLine1_String[0];//blank
                    InUIObject.mUI_ResultsLine2 = InUIObject.mUI_ResultsLine2_String[5];//Sand attack enemy
                    
                    if(Inpokemon.mAttack_AccuracyDemoninator<=4)
                    {
                        InUIObject.mUI_ResultsLine3 = string.Format("attack had no effect on {0}", Inpokemon.mPokeName); //result of action
                    }
                    else
                    {
                    InUIObject.mUI_ResultsLine3 = string.Format("and decreased {0} accuracy by 1!", Inpokemon.mPokeName); //result of action
                    }

                    if (randomEnemy.mDidAttackLand == false)
                    {
                        InUIObject.mUI_ResultsLine4 = InUIObject.mUI_ResultsLine4_String[4];//attack missed
                    }
                    else
                    {
                        InUIObject.mUI_ResultsLine4 = InUIObject.mUI_ResultsLine4_String[0];//attack landed. Line is blank
                    }
                    InUIObject.mUI_ResultsLine5 = InUIObject.mUI_ResultsLine5_String[1];//Prompt player to chose action
                    //reset UI
                    Console.Clear();
                    InUIObject.FindDefendPokeArt(randomEnemy);
                    InUIObject.FindPlayerPokeArt(Inpokemon);

                    //player turn
                    goto battle;

                case 4:

                    //enemy turn
                    randomEnemy.AttackBuff();
                    Console.WriteLine("You use Attack Buff!");
                    Functions.Space();
                    //update UI lines
                    InUIObject.mUI_ResultsLine1 = InUIObject.mUI_ResultsLine1_String[0];//blank
                    InUIObject.mUI_ResultsLine2 = InUIObject.mUI_ResultsLine2_String[6];//Buff (sword dance) - enemy
                    InUIObject.mUI_ResultsLine3 = "enemy's next attack does 3x damage."; //result of action
                    if (randomEnemy.mDidAttackLand == false)
                    {
                        InUIObject.mUI_ResultsLine4 = InUIObject.mUI_ResultsLine4_String[1];//attack missed
                    }
                    else
                    {
                        InUIObject.mUI_ResultsLine4 = InUIObject.mUI_ResultsLine4_String[0];//attack landed. Line is blank
                    }
                    InUIObject.mUI_ResultsLine5 = InUIObject.mUI_ResultsLine5_String[1];//Prompt player to chose action
                    //reset UI
                    Console.Clear();
                    InUIObject.FindDefendPokeArt(randomEnemy);
                    InUIObject.FindPlayerPokeArt(Inpokemon);

                    //enemy turn
                    goto battle;
            }

        end:
            Functions.Space();
            return randomEnemy;

        }

    }
}
