using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Pokemon;
using System.Xml.Linq;
using System.Threading;

namespace ConsoleApp1
{
    internal class Story
    {
        Player player = new Player();

        public void Intro()
        {


            //Intro text here
            Console.WriteLine(" ---------------------");
            Console.WriteLine("| Welcome to Pokemon! |");
            Console.WriteLine(" ---------------------");
            Functions.Space();


            while (true)
            {
                Console.WriteLine(" -------------------");
                Console.WriteLine("| Choose your name! |");
                Console.WriteLine(" -------------------");

                //enter player name here
                player.playerName = Console.ReadLine();

                //error checks
                //no spaces
                if(player.playerName.Contains(" ")) { Functions.Error(); continue;}
                //not too long
                else if(player.playerName.Length > 20){ Functions.Error(); continue;}
                //make sure its not empty
                else if(player.playerName == ""){Functions.Error(); continue;}
                break;
            }

            Functions.Space();
            Console.WriteLine("Hello {0}! Lets start your adventure!", player.playerName);
            Functions.Continue();

        }

        static public Pokemon PickPokemon()
        {
            int pokemonChoice;
            Pokemon pokemon = new Pokemon();

            while (true)
            {
                Console.WriteLine(" ----------------------");
                Console.WriteLine("| Choose your pokemon: |");
                Console.WriteLine("| 1. Squirtle          |");
                Console.WriteLine("| 2. Charmander        |");
                Console.WriteLine("| 3. Bulbasaur         |");
                Console.WriteLine(" ----------------------");


                //enter pokemon choice here

                //if in between 1 and 3 and an int, continue
                if (int.TryParse(Console.ReadLine(), out pokemonChoice) && pokemonChoice > 0 && pokemonChoice < 4)
                {
                    Functions.Space();
                    //Create new pokemon
                    break;
                }
                //if not, error
                else
                {
                    Functions.Error(); 
                    continue;
                }

            }

            //pokemon set stats
            switch (pokemonChoice)
            {
                case 1:
                    //set stats for squirtle
                    Squirtle pokemonSquirtle = new Squirtle("Squirtle", "Squirtle");
                    pokemon = pokemonSquirtle;
                    Console.WriteLine("You chose {0}!", pokemon.mPokeName);
                    break;

                case 2:
                    //set stats for charmander
                    Charmander pokemonCharmander = new Charmander("Charmander", "Charmander");
                    pokemon = pokemonCharmander;
                    Console.WriteLine("You chose {0}!", pokemon.mPokeName);
                    break;

                case 3:
                    //set stats for bulbasaur
                    Bulbasaur pokemonBulbasaur = new Bulbasaur("Bulbasaur", "Bulbasaur");
                    pokemon = pokemonBulbasaur;
                    Console.WriteLine("You chose {0}!", pokemon.mPokeName);
                    break;
            }

            Functions.Continue();

            //name pokemon

            while (true)
            {
                Console.Clear();
                Console.WriteLine(" --------------------------------");
                Console.WriteLine("| Name your pokemon? (Yes or No) |");
                Console.WriteLine(" --------------------------------");


                string ifName = Console.ReadLine().ToLower();

                switch (ifName)
                {
                    case "yes":

                        Console.WriteLine("Write out name:");

                        pokemon.mName = Console.ReadLine();

                        //error checks
                        //no spaces
                        if (pokemon.mName.Contains(" ")) { Functions.Error(); continue; }
                        //not too long
                        else if (pokemon.mName.Length > 10) { Functions.Error(); continue; }
                        //make sure its not empty
                        else if (pokemon.mName == "") { Functions.Error(); continue; }

                        break;

                    case "no":

                        if(pokemonChoice == 1)
                        {
                            pokemon.mName = "Squirtle";
                            break;
                        }
                        if (pokemonChoice == 2)
                        {
                            pokemon.mName = "Charmander";
                            break;
                        }
                        if (pokemonChoice == 3)
                        {
                            pokemon.mName = "Bulbasaur";
                            break;
                        }
                        else
                        {
                            Functions.Error();
                            continue;
                        }

                    default:
                        Functions.Error();
                        continue;
                }
                break;
            }
            Functions.Space();
            Console.WriteLine("Your pokemon is type {0} and is called {1}!", pokemon.mPokeName, pokemon.mName);
            Functions.Continue();

            return pokemon;
        }

        public void StoryCont()
        {
            int storyChoice;
            int itemChoice;

            begin:
            while (true)
            {

                Console.WriteLine(" --------------------------------------------------");
                Console.WriteLine("| Back on your journey! What would you like to do? |");
                Console.WriteLine("| 1. Next Battle                                   |");
                Console.WriteLine("| 2. Go to shop                                    |");
                Console.WriteLine("| 3. Take a nap                                    |");
                Console.WriteLine(" --------------------------------------------------");

                //if in between 1 and 3 and an int, continue
                if (int.TryParse(Console.ReadLine(), out storyChoice) && storyChoice > 0 && storyChoice < 4)
                {
                    Functions.Space();
                    //Create new pokemon
                    break;
                }
                //if not, error
                else
                {
                    Functions.Error();
                    continue;
                }

            }

            switch (storyChoice)
            {
                case 1:
                    //Battle.BattleTime(squirtlePlayer, bulbasaurEnemy, UIObject);

                    goto begin;

                case 2:

                    while (true)
                    {
                        Console.WriteLine("Your bank: {0}", player.money);
                        Console.WriteLine(" --------------------------------------------------");
                        Console.WriteLine("| Welcome to the shop! What would you like?        |");
                        Console.WriteLine("| 1. Item 1, 10$                                   |");
                        Console.WriteLine("| 2. Item 2, 20$                                   |");
                        Console.WriteLine("| 3. Item 3, 50$                                   |");
                        Console.WriteLine(" --------------------------------------------------");

                        //if in between 1 and 3 and an int, continue
                        if (int.TryParse(Console.ReadLine(), out itemChoice) && itemChoice > 0 && itemChoice < 4)
                        {
                            Functions.Space();
                            break;
                        }
                        //if not, error
                        else
                        {
                            Functions.Error();
                            continue;
                        }
                    }

                    switch (itemChoice)
                    {
                        case 1:
                            if(player.money > 10)
                            {
                                Console.WriteLine("You bought item 1, congrats!");
                                Functions.Continue();
                            }
                            else
                            {
                                Console.WriteLine("You can't afford that! Get outta here!");
                                Functions.Continue();
                            }
                            goto begin;

                        case 2:
                            if (player.money > 20)
                            {
                                Console.WriteLine("You bought item 2, enjoy!");
                                Functions.Continue();
                            }
                            else
                            {
                                Console.WriteLine("You can't afford that! Get outta here!");
                                Functions.Continue();
                            }
                            goto begin;

                        case 3:
                            if (player.money > 50)
                            {
                                Console.WriteLine("You bought item 3, enjoy!");
                                Functions.Continue();
                            }
                            else
                            {
                                Console.WriteLine("You can't afford that! Get outta here!");
                                Functions.Continue();
                            }
                            goto begin;
                    }
                    goto begin;
                case 3:
                    Console.WriteLine("Took a nap! That did nothing!");
                    Functions.Continue();

                    goto begin;
            }

            

        }


    }
}
