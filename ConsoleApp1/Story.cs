﻿using System;
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
        //initialize all the classes
        static public Player player = new Player();
        static public Pokemon pokemon = new Pokemon();
        public UI_Battle UIObject = new UI_Battle();
        static public Battle battle = new Battle();
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
        public void PickPokemon()
        {
            int pokemonChoice;

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
                    //if they want to name it, get user input for name
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

                    //if not set to base name
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

        }
        public void FirstBattle()
        {
            Console.WriteLine("You've run into your first battle!");
            Functions.Space();

            battle.BattleTime(pokemon, UIObject);
        }
        public void StoryCont()
        {
            int storyChoice;
            int itemChoice;

            begin:
            //check if level 8 for final battle
            if(pokemon.mLevel == 8)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("you have reached Level 8, your next battle will be the final battle against your rival Gary!");
                Console.ForegroundColor = ConsoleColor.White;
                Functions.Space();

            }

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

            //check what user chose
            switch (storyChoice)
            {
                //chose next battle
                case 1:

                    //check if level 8 for final battle
                    if (pokemon.mLevel == 8)
                    {
                        goto finalbattle;
                    }

                    Console.WriteLine("You chose battle! Begin fight!");
                    Functions.Space();

                    battle.BattleTime(pokemon, UIObject);

                    goto begin;

                //chose shop
                case 2:

                    while (true)
                    {
                        Console.WriteLine("Your bank: {0}", player.money);
                        Console.WriteLine(" --------------------------------------------------");
                        Console.WriteLine("| Welcome to the shop! What would you like?        |");
                        Console.WriteLine("| 1. Heal 10 HP, 10$                               |");
                        Console.WriteLine("| 2. Heal 20 HP, 20$                               |");
                        Console.WriteLine("| 3. Heal 30 HP, 30$                               |");
                        Console.WriteLine("| 4. Exit Shop                                     |");
                        Console.WriteLine(" --------------------------------------------------");

                        //if in between 1 and 4 and an int, continue
                        if (int.TryParse(Console.ReadLine(), out itemChoice) && itemChoice > 0 && itemChoice < 5)
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

                    //another switch for shop items
                    switch (itemChoice)
                    {
                        case 1:
                            if(player.money >= 10)
                            {
                                Console.WriteLine("You Healed 10 HP, congrats!");
                                player.money -= 10;
                                pokemon.mHP += 10;
                                Console.WriteLine("Bank now at {0}", player.money);
                                Console.WriteLine("{0} is now at {1} health", pokemon.mName, pokemon.mHP);
                                Functions.Continue();
                            }
                            else
                            {
                                Console.WriteLine("You can't afford that! Get outta here!");
                                Functions.Continue();
                            }
                            goto begin;

                        case 2:
                            if (player.money >= 20)
                            {
                                Console.WriteLine("You Healed 20 HP, enjoy!");
                                player.money -= 20;
                                pokemon.mHP += 20;
                                Console.WriteLine("Bank now at {0}", player.money);
                                Console.WriteLine("{0} is now at {1} health", pokemon.mName, pokemon.mHP);
                                Functions.Continue();
                            }
                            else
                            {
                                Console.WriteLine("You can't afford that! Get outta here!");
                                Functions.Continue();
                            }
                            goto begin;

                        case 3:
                            if (player.money >= 30)
                            {
                                Console.WriteLine("You Healed 30 HP, yay!");
                                player.money -= 30;
                                pokemon.mHP += 30;
                                Console.WriteLine("Bank now at {0}", player.money);
                                Console.WriteLine("{0} is now at {1} health", pokemon.mName, pokemon.mHP);
                                Functions.Continue();
                            }
                            else
                            {
                                Console.WriteLine("You can't afford that! Get outta here!");
                                Functions.Continue();
                            }
                            goto begin;
                        case 4:
                            goto begin;
                    }
                    goto begin;

                //chose nap
                case 3:
                    Console.WriteLine("You wake up feeling well rested. You gained nothing.");
                    Functions.Continue();

                    goto begin;
            }

        finalbattle:

            Console.WriteLine("You have reached level 8, it is time to fight your rival Gary!");

            //battle function
            battle.BattleTime(pokemon, UIObject);

            //check if level 9 to see if player won
            if (pokemon.mLevel == 9)
            {
                goto endgame;
            }
            else
            {
                Console.WriteLine("Try again!");
                Functions.Continue();
                goto finalbattle;
            }

        endgame:

            Console.Clear();
            Functions.Space();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You won! You and your {0} named {1} left at level 9 with {2} in the bank! Congrats!", pokemon.mPokeName, pokemon.mName, player.money);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

}
