using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Story
    {


        static public void Intro()
        {

            //Intro text here
            Console.WriteLine("Welcome to Pokemon!");
            Functions.Space();

            string playerName;

            while (true)
            {
                Console.WriteLine("Choose your name!");
                //enter player name here
                playerName = Console.ReadLine();

                //error checks
                //no spaces
                if(playerName.Contains(" ")) { Functions.Error(); continue;}
                //not too long
                else if(playerName.Length > 20){ Functions.Error(); continue;}
                //make sure its not empty
                else if(playerName == ""){Functions.Error(); continue;}
                break;
            }

            Functions.Space();
            Console.WriteLine("Hello {0}! Lets start your adventure!", playerName);
            Functions.Continue();

        }

        static public void PickPokemon(Pokemon pokemon)
        {
            int pokemonChoice;

            while (true)
            {
                Console.WriteLine("Choose your pokemon:");
                Console.WriteLine("1. Squirtle");
                Console.WriteLine("2. Charmander");
                Console.WriteLine("3. Bulbasaur");

                //enter pokemon choice here

                //if in between 1 and 3 and an int, continue
                if (int.TryParse(Console.ReadLine(), out pokemonChoice) && pokemonChoice > 0 && pokemonChoice < 4)
                {
                    //enter pokemon here
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
                    pokemon.mPokeName = "Squirtle";
                    Console.WriteLine("You chose {0}!", pokemon.mPokeName);
                    break;

                case 2:
                    //set stats for charmander
                    pokemon.mPokeName = "Charmander";
                    Console.WriteLine("You chose {0}!", pokemon.mPokeName);
                    break;

                case 3:
                    //set stats for bulbasaur
                    pokemon.mPokeName = "Bulbasaur";
                    Console.WriteLine("You chose {0}!", pokemon.mPokeName);
                    break;
            }

            Functions.Continue();

            //name pokemon

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Name your pokemon? (Yes or No)");

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
        }

    }
}
