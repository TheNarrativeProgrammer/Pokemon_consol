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

            Console.WriteLine("{0} lost.... You gained no xp and lost {1} money", pokemon.mName, moneyGained);

        }

        public static Pokemon SpawnRandomWildPokemon ()
        {
            Random randomEnem = new Random();
            int enemyType = randomEnem.Next(1, 3);
            Pokemon returnWildPokemon;

            switch (enemyType)
            {
                case 1:
                    {
                        Pokemon wildCaterpie = new Pokemon();
                        returnWildPokemon = wildCaterpie;
                        break;
                    }
                case 2:
                    {
                        Pokemon wildCaterpie = new Pokemon();
                        returnWildPokemon = wildCaterpie;
                        break;
                    }
                case 3:
                    {
                        Pokemon wildCaterpie = new Pokemon();
                        returnWildPokemon = wildCaterpie;
                        break;
                    }
                default:
                    {
                        Pokemon wildCaterpie = new Pokemon();
                        returnWildPokemon = wildCaterpie;
                        break;
                    }
            }
            return returnWildPokemon;
        }

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

        public static Pokemon BattleTime(Pokemon Inpokemon, Pokemon InenemyPokemon, UI_Battle InUIObject)
        {

            int moveChoice;
            int playerDamage;
            int enemyDamage;
            int countAttacks = 0;
            //UI_Battle UIObject = new UI_Battle();

            //InenemyPokemon = SpawnRandomWildPokemon();
            Functions.Continue();
            InUIObject.mUI_ResultsLine1 = InUIObject.mUI_ResultsLine1_String[1];
            InUIObject.FindDefendPokeArt(InenemyPokemon);
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
            InUIObject.FindDefendPokeArt(InenemyPokemon);
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
                    playerDamage = Inpokemon.AttackOffensive(InenemyPokemon, countAttacks);
                    Console.WriteLine("You use Attack Offsensive and did {0} damage to {1}!", playerDamage, InenemyPokemon.mPokeName);
                    Functions.Space();
                    //Update enemy stat - health
                    InenemyPokemon.mHP-=playerDamage;
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
                    
                    InUIObject.FindDefendPokeArt(InenemyPokemon);
                    InUIObject.FindPlayerPokeArt(Inpokemon);

                    //check if enemy dead
                    if (InenemyPokemon.mHP <= 0)
                    {
                        Win(Inpokemon);
                        Inpokemon.mEXPoints += (Inpokemon.mLevel * countAttacks);
                        goto end;
                    }

                    Functions.Continue();

                    goto enemy;

                case 2:

                    //player turn
                    Inpokemon.AttackAccuracy(InenemyPokemon);
                    Console.WriteLine("You use Attack Accuracy and decreased enemy {0} accuracy by 2!", InenemyPokemon.mPokeName);
                    
                    //update UI lines
                    InUIObject.mUI_ResultsLine1 = InUIObject.mUI_ResultsLine1_String[0];//blank
                    InUIObject.mUI_ResultsLine2 = InUIObject.mUI_ResultsLine2_String[2];//Sand attack
                    if (InenemyPokemon.mAttack_AccuracyDemoninator <= 4)
                    {
                        InUIObject.mUI_ResultsLine3 = string.Format("Attack had on effect on {0}", InenemyPokemon.mPokeName); //result of action
                    }
                    else
                    {
                        InUIObject.mUI_ResultsLine3 = string.Format("and decreased {0} accuracy by 1!", InenemyPokemon.mPokeName); //result of action
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
                    InUIObject.FindDefendPokeArt(InenemyPokemon);
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
                    InUIObject.FindDefendPokeArt(InenemyPokemon);
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
                case 1:

                    //enemy turn
                    enemyDamage = InenemyPokemon.AttackOffensive(Inpokemon, 0);
                    Console.WriteLine("Enemy used Attack Offsensive and did {0} damage to {1}!", enemyDamage, Inpokemon.mName);
                    Functions.Space();
                    //Update enemy stat - health
                    Inpokemon.mHP -= enemyDamage;
                    //update UI lines
                    InUIObject.mUI_ResultsLine1 = InUIObject.mUI_ResultsLine1_String[0];//blank
                    InUIObject.mUI_ResultsLine2 = InUIObject.mUI_ResultsLine2_String[4];//Tackle attack - enemy
                    InUIObject.mUI_ResultsLine3 = string.Format("and did {0} damage", enemyDamage); //result of action
                    if (InenemyPokemon.mDidAttackLand == false)
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
                    InUIObject.FindDefendPokeArt(InenemyPokemon);
                    InUIObject.FindPlayerPokeArt(Inpokemon);


                    if (Inpokemon.mHP <= 0)
                    {
                        Lose(Inpokemon);
                        goto end;
                    }

                    goto battle;

                case 2:

                    //enemy turn
                    enemyDamage = InenemyPokemon.AttackOffensive(Inpokemon, 0);
                    Console.WriteLine("Enemy used Attack Offsensive and did {0} damage to {1}!", enemyDamage, Inpokemon.mName);
                    Functions.Space();
                    //Update enemy stat - health
                    Inpokemon.mHP -= enemyDamage;
                    //update UI lines
                    InUIObject.mUI_ResultsLine1 = InUIObject.mUI_ResultsLine1_String[0];//blank
                    InUIObject.mUI_ResultsLine2 = InUIObject.mUI_ResultsLine2_String[4];//Tackle attack - enemy
                    InUIObject.mUI_ResultsLine3 = string.Format("and did {0} damage", enemyDamage); //result of action
                    if (InenemyPokemon.mDidAttackLand == false)
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
                    InUIObject.FindDefendPokeArt(InenemyPokemon);
                    InUIObject.FindPlayerPokeArt(Inpokemon);


                    if (Inpokemon.mHP <= 0)
                    {
                        Lose(Inpokemon);
                        goto end;
                    }

                    goto battle;

                case 3:
                    //enemy turn
                    InenemyPokemon.AttackAccuracy(Inpokemon);
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

                    if (InenemyPokemon.mDidAttackLand == false)
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
                    InUIObject.FindDefendPokeArt(InenemyPokemon);
                    InUIObject.FindPlayerPokeArt(Inpokemon);

                    //player turn
                    goto battle;

                case 4:

                    //enemy turn
                    InenemyPokemon.AttackBuff();
                    Console.WriteLine("You use Attack Buff!");
                    Functions.Space();
                    //update UI lines
                    InUIObject.mUI_ResultsLine1 = InUIObject.mUI_ResultsLine1_String[0];//blank
                    InUIObject.mUI_ResultsLine2 = InUIObject.mUI_ResultsLine2_String[6];//Buff (sword dance) - enemy
                    InUIObject.mUI_ResultsLine3 = "enemy's next attack does 3x damage."; //result of action
                    if (InenemyPokemon.mDidAttackLand == false)
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
                    InUIObject.FindDefendPokeArt(InenemyPokemon);
                    InUIObject.FindPlayerPokeArt(Inpokemon);

                    //enemy turn
                    goto battle;
            }

        end:
            Console.WriteLine("end");


            return InenemyPokemon;

        }

    }
}
