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

            Story story = new Story();
            story.Intro();
            story.PickPokemon();
            story.FirstBattle();
            story.StoryCont();


/*
            //test UI
            Squirtle squirtlePlayer = new Squirtle("Some Name", "Squirtle");
            Bulbasaur bulbasaurEnemy = new Bulbasaur("Enemy Bulba", "Bulbasaur");

            Bulbasaur BulbaPlayer = new Bulbasaur("Enemy Bulba", "Bulbasaur");
            Squirtle squirtleEnemy = new Squirtle("Some Name", "Squirtle");

            Charmander CharPlayer = new Charmander("Player Char", "Charamander");
            Pokemon CaterpieEnemy = new Pokemon();


            //Battle.BattleTime(squirtlePlayer);
            Battle battleObject = new Battle();

            UI_Battle UIObject = new UI_Battle();

            UIObject.FindDefendPokeArt(squirtleEnemy);
            UIObject.FindPlayerPokeArt(CharPlayer);
*/

            

            Console.ReadLine();

        }
    }
}
