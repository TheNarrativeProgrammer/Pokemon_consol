using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //create player pokemon
            Pokemon pokemon = new Pokemon();

            //story functions from story file
            Story.Intro();
            Story.PickPokemon(pokemon);


            Battle.Lose(pokemon);

            Console.ReadLine();

        }
    }
}
