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

            //game functions
            Story story = new Story();
            story.Intro();
            story.PickPokemon();
            story.FirstBattle();
            story.StoryCont();        

            Console.ReadLine();

        }
    }
}
