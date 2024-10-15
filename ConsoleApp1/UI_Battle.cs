using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class UI_Battle
    {
        //MEMBER VARIABLES - NON POKEMON
        public string[] mUI_ResultsLine1_String = {"           ", "Choose an action!", "You won", "You lost", };
        public string mUI_ResultsLine1;
        public string[] mUI_ResultsLine2_String = { "               ", "You use Tackle Attack", "You used Sand Attack", "You used sword dance", 
            "enemny use Tackle Attack", "Enemy used Sand Attack", "Enemy used sword dance", };
        public string mUI_ResultsLine2;
        public string mUI_ResultsLine3;//string isn't a string array. Battle class sets this string
        public string[] mUI_ResultsLine4_String = { "                    ", "Your attack missed", "Your attack did 3x damage", "Their attack missed", "Their attack did 3x damage", };
        public string mUI_ResultsLine4;
        public string[] mUI_ResultsLine5_String = { "           ", "Choose an action!", "The enemy fainted.", "               ", };
        public string mUI_ResultsLine5;

        public UI_Battle()
        {
            mUI_ResultsLine1 = mUI_ResultsLine1_String[0];
            mUI_ResultsLine2 = mUI_ResultsLine2_String[0];
            mUI_ResultsLine3 = "                     ";
            mUI_ResultsLine4 = mUI_ResultsLine4_String[0];
            mUI_ResultsLine5 = mUI_ResultsLine5_String[0];
        }

        //MEMBER VARIABLES - POKEMON AS STRINGS
        public string[] mUIBulbasaur_String =
            {
                "\t",
                "\t",
                "\t",
                "\t                        _,.------....___,.' ',.-.",
                "\t                      ,-'          _,.--\"        |",
                "\t                    ,'         _.-'              .",
                "\t                   /   ,     ,'                   `",
                "\t                  .   /     /                     ``.",
                "\t                  |  |     .                       \\.\\\\",
                "\t        ____      |___._.  |       __               \\ `.",
                "\t      .'    `---\"\"       ``\"-.--\"'`  \\               .  \\",
                "\t     .  ,            __               `              |   .",
                "\t     `,'         ,-\"'  .               \\             |    L",
                "\t    ,'          '    _.'                -._          /    |",
                "\t   ,`-.    ,\".   `--'                      >.      ,'     |",
                "\t  . .'\\'   `-'       __    ,  ,-.         /  `.__.-      ,'",
                "\t  ||:, .           ,'  ;  /  / \\ `        `.    .      .'/",
                "\t  j|:D  \\          `--'  ' ,'_  . .         `.__, \\   , /",
                "\t / L:_  |                 .  \"' :_;                `.'.'",
                "\t .    \"\"'                  \"\"\"\"\"'                    V",
                "\t  `.                                 .    `.   _,..  `",
                "\t    `,_   .    .                _,-'/    .. `,'   __  `",
                "\t     ) \\`._        ___....----\"'  ,'   .'  \\ |   '  \\  .",
                "\t    /   `. \"`-.--\"'         _,' ,'     `---' |    `./  |",
                "\t   .   _  `\"\"'--.._____..--\"   ,             '         |",
                "\t   | .\" `. `-.                /-.           /          ,",
                "\t   | `._.'    `,_            ;  /         ,'          .",
                "\t  .'          /| `-.        . ,'         ,           ,",
                "\t  '-.__ __ _,','    '`-..___;-...__   ,.'\\ ____.___.'",
                "\t  `\"^--'..'   '-`-^-'\"--    `-^-'`.''\"\"\"\"\"`.,^.`.--'",
                "\t ",
                "\t ",
            };
        public string[] mUISquirtle_String =
            { "\t                _,........__",
                "\t            ,-'            \"`-.",
                "\t          ,'                   `-.",
                "\t        ,'                        \\",
                "\t      ,'                           .",
                "\t      .'\\               ,\"\".       `",
                "\t     ._.'|             / |  `       \\",
                "\t     |   |            `-.'  ||       `.",
                "\t     |   |            '-._,'||       | \\",
                "\t     .`.,'             `..,'.'       , |`-.",
                "\t     l                       .'`.  _/  |   `.",
                "\t     `-.._'-   ,          _ _'   -\" \\  .     `",
                "\t`.\"\"\"\"\"'-.`-...,---------','         `. `....__.",
                "\t.'        `\"-..___      __,'\\          \\  \\     \\",
                "\t\\_ .          |   `\"\"\"\"'    `.           . \\     \\",
                "\t  `.          |              `.          |  .     L",
                "\t    `.        |`--...________.'.        j   |     |",
                "\t      `._    .'      |          `.     .|   ,     |",
                "\t            ` `      `            /     |  |      |    _,-'\"\"\"`-.",
                "\t             \\ `.     .          /      |  '      |  ,'          `.",
                "\t              \\  v.__  .        '       .   \\    /| /              \\",
                "\t               \\/    `\"\"\\\"\"\"\"\"\"\"`.       \\   \\  /.''                |",
                "\t                `        .        `._ ___,j.  `/ .-       ,---.     |",
                "\t                ,`-.      \\         .\"     `.  |/        j     `    |",
                "\t               /    `.     \\       /         \\ /         |     /    j",
                "\t              |       `-.   7-.._ .          |\"          '         / ",
                "\t              |          `./_    `|          |            .     _,'",
                "\t              `.           / `----|          |-............`---'",
                "\t                \\          \\      |          |",
                "\t               ,'           )     `.         | ",
                "\t                7____,,..--'      /          |",
                "\t                                  `---.__,--.",
            };
        public string[] mUICharmander_String =
                {"\t              _.--\"\"`-..",
                "\t            ,'          `.",
                "\t          ,'          __  `.",
                "\t         /|          \" __   \\",
                "\t        , |           / |.   .",
                "\t        |,'          !_.'|   |",
                "\t      ,'             '   |   |",
                "\t     /              |`--'|   |",
                "\t    |                `---'   |",
                "\t     .   ,                   |                       ,\".",
                "\t      ._     '           _'  |                    , ' \\ `",
                "\t  `.. `.`-...___,...---\"\"    |       __,.        ,`\"   L,|",
                "\t  |, `- .`._        _,-,.'   .  __.-'-. /        .   ,    \\",
                "\t-:..     `. `-..--_.,.<       `\"      / `.        `-/ |   .",
                "\t  `,         \"\"\"\"'     `.              ,'         |   |  ',,",
                "\t    `.      '            '            /          '    |'. |/",
                "\t      `.   |              \\       _,-'           |       ''",
                "\t        `._'               \\   '\"\\                .      |",
                "\t           |                '     \\                `._  ,'",
                "\t           |                 '     \\                 .'|",
                "\t           |                 .      \\                | |",
                "\t            \\                |       |           ,'   /",
                "\t          ,' \\               |  _.._ ,-..___,..-'    ,'",
                "\t         /     .             .      `!             ,j'",
                "\t        /       `.          /        .           .'/",
                "\t       .          `.       /         |        _.'.'",
                "\t        `.          7`'---'          |------\"'_.'",
                "\t       _,.`,_     _'                ,''-----\"'",
                "\t   _,-_    '       `.     .'      ,\\",
                "\t   -\" /`.         _,'     | _  _  _.|",
                "\t    \"\"--'---\"\"\"\"\"'        `' '! |! /",
                "\t                            `\" \" -'",
        };

        public string[] mUICaterpie_String =
            {   "\t                   _,........_",
                "\t               _.-'    ___    `-._",
                "\t            ,-'      ,'   \\       `.",
                "\t _,...    ,'      ,-'     |  ,\"\"\":`._.",
                "\t/     `--+.   _,.'      _.',',|\"|  ` \\`\\",
                "\t_         `\"'     _,-\"'  | / `-'   l L\\",
                "\t  `\"---.._      ,-\"       | l       | | |",
                "\t      /   `.   |          ' `.     ,' ; |",
                "\t     j     |   |           `._`\"\"\"' ,'  |__",
                "\t     |      `--'____          `----'    .' `.",
                "\t     |    _,-\"\"\"    `-.                 |    \\",
                "\t     l   /             `.               F     l",
                "\t      `./     __..._     `.           ,'      |",
                "\t        |  ,-\"      `.    | ._     _.'        |",
                "\t        . j           \\   j   /`\"\"\"      __   |          ,\"`.",
                "\t         `|           | _,.__ |        ,'  `. |          |   |",
                "\t          `-._       /-'     `L       .     , '          |   |",
                "\t              F-...-'          `      |    , /           |   |",
                "\t              |            ,----.     `...' /            |   |",
                "\t              .--.        j      l        ,'             |   j",
                "\t             j    L       |      |'-...--<               .  /",
                "\t             `     |       . __,,_    ..  |               \\/",
                "\t              `-..'.._  __,-'     \\  |  |/`._           ,'`",
                "\t                  |   \"\"       .--`. `--,  ,-`..____..,'   |",
                "\t                   L          /     \\ _.  |   | \\  .-.\\    j",
                "\t                  .'._        l     .\\    `---' |  |  || ,'",
                "\t                   .  `..____,-.._.'  `._       |  `--;\"I'",
                "\t                    `--\"' `.            ,`-..._/__,.-1,'",
                "\t                            `-.__  __,.'     ,' ,' _-'",
                "\t                                 `'...___..`'--^--'",
                "\t ",
                "\t ",

        };

        public string[] mUIPikachu_String =
                {
                "\t $$$b  `---.__",
                "\t  \"$$b        `--.                          ___.---uuudP",
                "\t   `$$b           `.__.------.__     __.---'      $$$$\"              .",
                "\t     \"$b          -'            `-.-'            $$$\"              .'|",
                "\t       \".                                       d$\"             _.'  |",
                "\t         `.   /                              ...\"             .'     |",
                "\t           `./                           ..::-'            _.'       |",
                "\t            /                         .:::-'            .-'         .'",
                "\t           :                          ::''\\          _.'            |",
                "\t          .' .-.             .-.           `.      .'               |",
                "\t          : /'$$|           .@\"$\\           `.   .'              _.-'",
                "\t         .'|$u$$|          |$$,$$|           |  <            _.-'",
                "\t         | `:$$:'          :$$$$$:           `.  `.       .-'",
                "\t         :                  `\"--'             |    `-.     \\",
                "\t        :##.       ==             .###.       `.      `.    `\\",
                "\t        |##:                      :###:        |        >     >",
                "\t        |#'     `..'`..'          `###'        x:      /     /",
                "\t          \\                                xXXX'|    /   ./",
                "\t          /`-.                                  `.  /   /",
                "\t         :    `-  ...........,                   | /  .'",
                "\t         |         ``:::::::'       .            |<    `.",
                "\t         |                         .'    /'   xXX|  `:`M`M':.",
                "\t         |    |                    ;    /:' xXXX'|  -'MMMMM:'",
                "\t         `.  .'                   :    /:'       |-'MMMM.-'",
                "\t          |  |                   .'   /'        .'MMM.-'",
                "\t          `'`'|                 :  ,'          |MMM<",
                "\t               |                   `'         |tbap\\",
                "\t                /     .:::::::.. :           /",
                "\t               |     .:::::::::::`.         /",
                "\t               |   .:::------------\\       /",
                "\t              /   .''               >::'  /",
                "\t              `',:                 :.:' '",
        };

      
        //static public int myVar = 0;
        //public string[] UI_pika = {"\t                             ",
        //        "\t                                       ",
        //        "\t\t_______________________________________",
        //        "\t|" +myVar +"                                     |",
        //        "\t|                                      |",
        //        "\t|                                      |",
        //        "\t|                                      |",
        //        "\t|                                      |",
        //        "\t|______________________________________|",
        //        "\t                                         ",
        //    };

        //public string[] UI1 = {"\t\t                           ",
        //        "\t\t                                       ",
        //        "\t\t\t ______________________________________",
        //        "\t\t|                                      |",
        //        "\t\t|                                      |",
        //        "\t\t|                                      |",
        //        "\t\t|                                      |",
        //        "\t\t|                                      |",
        //        "\t\t|______________________________________|",
        //        "\t                                         ",
        //    };

        //public string[] UI2_base = {"\t\t                           ",
        //        "\t\t                                       ",
        //        "\t\t ______________________________________",
        //        "\t\t|                                      |",
        //        "\t\t|                                      |",
        //        "\t\t|                                      |",
        //        "\t\t|                                      |",
        //        "\t\t|                                      |",
        //        "\t\t|______________________________________|",
        //        "\t                                         ",

        //    };

        //public string[] UI_Result_Bulb = {"\t\t\t ",
        //        "\t\t\t",
        //        "\t\t __________________________________",
        //        "\t\t|                                  |",
        //        "\t\t\t|                                  |",
        //        "\t\t\t|                                  |",
        //        "\t\t\t|                                  |",
        //        "\t\t|                                  |",
        //        "\t\t|                                  |",
        //        "\t\t|                                  |",
        //        "\t\t|                                  |",
        //        "\t\t\t|                                  |",
        //        "\t\t\t|__________________________________|",
        //        "\t\t\t",
        //    };

        //public string[] UI_Result_Squi = {"\t\t ",
        //        "\t\t   squirtle                      ",
        //        "\t\t\t\t __________________________________",
        //        "\t\t\t\t|                                  |",
        //        "\t\t|                                  |",
        //        "\t\t|                                  |",
        //        "\t\t|                                  |",
        //        "\t\t|                                  |",
        //        "\t\t|                                  |",
        //        "\t\t|                                  |",
        //        "\t\t|                                  |",
        //        "\t\t|                                  |",
        //        "\t\t|__________________________________|",
        //        "\t\t",
        //    };

        //public string[] UI_Result_Char = {"\t\t ",
        //        "\t\t   char                      ",
        //        "\t\t __________________________________",
        //        "\t\t|                                  |",
        //        "\t\t|                                  |",
        //        "\t\t|                                  |",
        //        "\t\t|                                  |",
        //        "\t\t\t|                                  |",
        //        "\t\t\t|                                  |",
        //        "\t\t\t|                                  |",
        //        "\t\t\t|                                  |",
        //        "\t\t\t|                                  |",
        //        "\t\t\t|__________________________________|",
        //        "\t\t",
        //    };

        //public string[] UI_Result_Pik = {"\t\t ",
        //        "\t\t   char                      ",
        //        "\t\t __________________________________",
        //        "\t\t|                                  |",
        //        "\t\t|                                  |",
        //        "\t\t|                                  |",
        //        "\t\t|                                  |",
        //        "\t\t|                                  |",
        //        "\t\t|                                  |",
        //        "\t\t|                                  |",
        //        "\t\t|                                  |",
        //        "\t\t\t|                                  |",
        //        "\t\t\t|__________________________________|",
        //        "\t\t",
        //    };

        //public string[] UI_Result_Cat = {"\t\t ",
        //        "\t\t   Cat                      ",
        //        "\t\t __________________________________",
        //        "\t\t|                                  |",
        //        "\t\t|                                  |",
        //        "\t\t|                                  |",
        //        "\t\t|                                  |",
        //        "\t\t|                                  |",
        //        "\t\t|                                  |",
        //        "\t\t|                                  |",
        //        "\t\t|                                  |",
        //        "\t\t|                                  |",
        //        "\t\t|__________________________________|",
        //        "\t\t",
        //    };

        //FUNCTIONS
                                                                                                                                            //DEFENDING POKEMON                 
        public void PrintDefendPokeArt(string[] InDefendPokeArt, string[] InDefendPokeAttackStatBox)                                                            //Print Defending
        {
            for (int i = 0; i < InDefendPokeArt.Length; i++)
            {
                if (i <=5)
                {
                    Console.WriteLine($"{InDefendPokeArt[i],-70}");
                }
                else if (i >=6 && i <=12 )
                {
                    Console.WriteLine($"{InDefendPokeArt[i],-70}\t\t\t{InDefendPokeAttackStatBox[i-6],-20}");
                }
                else
                {
                    Console.WriteLine($"{InDefendPokeArt[i],-70}");
                }

            }

        }
         public void FindDefendPokeArt(Pokemon InDefendingPokemon)                                                           //Art Defending
        {
            string[] DefendPokeArt;             //stores the string of art for the defending pokemon.
            string[] DefendPokeAttackStatBox;   //stores the string of a box to house the defending pokemon health

            //"Squirtle","Charmander","Bulbasaur","Pigey","Pikachau",
            switch (InDefendingPokemon.mPokeName)
            {
                case "Squirtle":
                    {
                        DefendPokeArt = mUISquirtle_String;
                        DefendPokeAttackStatBox = UI_Defend_StatAttackBox(InDefendingPokemon);
                        break;
                    }
                case "Charmander":
                    {
                        DefendPokeArt = mUICharmander_String;
                        DefendPokeAttackStatBox = UI_Defend_StatAttackBox(InDefendingPokemon);
                        break;
                    }
                case "Bulbasaur":
                    {
                        DefendPokeArt = mUIBulbasaur_String;
                        DefendPokeAttackStatBox = UI_Defend_StatAttackBox(InDefendingPokemon);
                        break;
                    }
                case "Caterpie":
                    {
                        DefendPokeArt = mUICaterpie_String;
                        DefendPokeAttackStatBox = UI_Defend_StatAttackBox(InDefendingPokemon);
                        break;
                    }
                case "Pikachau":
                    {
                        DefendPokeArt = mUIPikachu_String;
                        DefendPokeAttackStatBox = UI_Defend_StatAttackBox(InDefendingPokemon);
                        break;
                    }
                default:
                {
                DefendPokeArt = mUICaterpie_String;
                DefendPokeAttackStatBox = UI_Defend_StatAttackBox(InDefendingPokemon);
                break;
                }
            }
            PrintDefendPokeArt(DefendPokeArt, DefendPokeAttackStatBox);          //pass art string as param to Print
        }


                                                                                                                                                        //PLAYER POKEMON                 
        public void PrintPlayerPokeArt(string[] InPlayerPokeArt, string[] InPlayerPokeAttackStatBox, string[] InPlayerPokeResultsBox)               //Print Player
        {
            for (int i = 0; i < InPlayerPokeArt.Length; i++)
            {

                if (i <= 9)
                {
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t" + $"{InPlayerPokeArt[i],-50}\t{InPlayerPokeAttackStatBox[i],10}");
                }
                else if (i >= 10 && i <= 14)
                {

                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t" + $"{InPlayerPokeArt[i],-50}");
                }
                else if (i >= 15 && i <= 27)
                {

                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t" + $"{InPlayerPokeArt[i],-50}\t{InPlayerPokeResultsBox[i - 15],30}");
                }
                else
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t" + $"{InPlayerPokeArt[i],-50}");
            }

        }
        public void FindPlayerPokeArt(Pokemon InPlayerPokemon)                                                                       //Art Player
        {
            string[] PlayerPokeArt;         //stores the string of art for the player pokemon.
            string[] PlayerPokeAttackStatBox;   //stores the string of a box to house the players pokemon attack options
            string[] PlayerPokeResultsBox;   //stores the string of a box to house the results of player and opponent attacks during battle

            //"Squirtle","Charmander","Bulbasaur","Pigey","Pikachau",
            switch (InPlayerPokemon.mPokeName)
            {
                case "Squirtle":
                    {
                        PlayerPokeArt = mUISquirtle_String;
                        //PlayerPokeAttackStatBox = UI2_base;
                        PlayerPokeAttackStatBox = UI_Base_StatAttackBox(InPlayerPokemon);
                        //PlayerPokeResultsBox = UI_Result_Squi;
                        PlayerPokeResultsBox = UI_Squi_Results();
                        break;
                    }
                case "Charmander":
                    {
                        PlayerPokeArt = mUICharmander_String;
                        PlayerPokeAttackStatBox = UI_Base_StatAttackBox(InPlayerPokemon);
                        PlayerPokeResultsBox = UI_Char_Results();
                        break;
                    }
                case "Bulbasaur":
                    {
                        PlayerPokeArt = mUIBulbasaur_String;
                        PlayerPokeAttackStatBox = UI_Base_StatAttackBox(InPlayerPokemon);
                        PlayerPokeResultsBox = UI_Bulb_Results();
                        break;
                    }
                case "Pikachau":
                    {
                        PlayerPokeArt = mUIPikachu_String;
                        //PlayerPokeAttackStatBox = UI_pika;
                        PlayerPokeAttackStatBox = UI_Pika_StatAttackBox(InPlayerPokemon);
                        PlayerPokeResultsBox = UI_Pika_Results();
                        break;
                    }
                default:
                    {
                        PlayerPokeArt = mUIPikachu_String;
                        PlayerPokeAttackStatBox = UI_Pika_StatAttackBox(InPlayerPokemon);
                        PlayerPokeResultsBox = UI_Pika_Results();
                        break;
                    }
            }
            //pass art string as param to Print
            PrintPlayerPokeArt(PlayerPokeArt, PlayerPokeAttackStatBox, PlayerPokeResultsBox);

        }

        //UI FUNCTIONS                                                                                                                                        //STAT & ATTACK
        public string[] UI_Pika_StatAttackBox(Pokemon InPoke)                                                                     //Pikachau
        {
            string[] UI_pika = {"\t                             ",
                "\t " + InPoke.mPokeName + "           ",
                "\t\t_______________________________________",
                "\t| Health " + InPoke.mHP +"                   |",
                "\t|                                      |",
                "\t|                                      |",
                "\t|                                      |",
                "\t|                                      |",
                "\t|______________________________________|",
                "\t                                         ",
            };
            return UI_pika;
        }

        public string[] UI_Defend_StatAttackBox(Pokemon InPoke)                                                               //Defending Pokemon
        {
            string[] UI2_Defend = {"\t\t                           ",
                "\t\t  " + InPoke.mPokeName + "             ",
                "\t\t ______________________________________",
                "\t\t| Health " + InPoke.mHP + "                            |",
                "\t\t|                                      |",
                "\t\t|                                      |",
                "\t\t|______________________________________|",
                "\t                                         ",
            };
            return UI2_Defend;
        }


        public string[] UI_Base_StatAttackBox(Pokemon InPoke)                                                               //Base Pokemon
        {
            string[] UI2_base = {"\t\t                           ",
                "\t\t  " + InPoke.mPokeName + "             ",
                "\t\t ______________________________________",
                "\t\t| Health " + InPoke.mHP + "                            |",
                "\t\t|                                      |",
                "\t\t| 1. Tackle                            |",
                "\t\t| 2. Sand Attack                       |",
                "\t\t| 3. Sword Dance                       |",
                "\t\t|______________________________________|",
                "\t                                         ",
            };
            return UI2_base;
        }

        public string[] UI_Bulb_Results()
        {
            string[] UI_Result_Bulb = {"\t\t\t ",
                "\t\t\t",
                "\t\t __________________________________",
                "\t\t|" + mUI_ResultsLine1 +"            ",
                "\t\t\t|"+mUI_ResultsLine2 +"            ",
                "\t\t\t|"+mUI_ResultsLine3 +"            ",
                "\t\t\t|"+mUI_ResultsLine4 +"            ",
                "\t\t|"+mUI_ResultsLine5 +"              ",
                "\t\t|                                   ",
                "\t\t|                                   ",
                "\t\t|                                   ",
                "\t\t\t|__________________________________",
                "\t\t\t",
            };
            return UI_Result_Bulb;
        }
        
        public string[] UI_Squi_Results()
        {
              string[] UI_Result_Squi = {"\t\t ",
                "\t\t                         ",
                "\t\t\t\t __________________________________",
                "\t\t|"+ mUI_ResultsLine1 +"            ",
                "\t\t|"+mUI_ResultsLine2 +"             ",
                "\t\t|"+mUI_ResultsLine3 +"             ",
                "\t\t|"+mUI_ResultsLine4 +"             ",
                "\t\t|"+mUI_ResultsLine5 +"             ",
                "\t\t|                                  ",
                "\t\t|                                  ",
                "\t\t|                                  ",
                "\t\t|__________________________________",
                "\t\t",
            };
            return UI_Result_Squi;
        }

        public string[] UI_Char_Results()
        {
             string[] UI_Result_Char = {"\t\t ",
                "\t\t                         ",
                "\t\t __________________________________",
                "\t\t|" + mUI_ResultsLine1 +"            ",
                "\t\t|"+mUI_ResultsLine2 +"              ",
                "\t\t|"+mUI_ResultsLine3 +"              ",
                "\t\t\t|"+mUI_ResultsLine4 +"              ",
                "\t\t\t|"+mUI_ResultsLine5 +"              ",
                "\t\t\t|                                  ",
                "\t\t\t|                                  ",
                "\t\t\t|                                  ",
                "\t\t\t|__________________________________",
                "\t\t",
            };
            return UI_Result_Char;
        }

        public string[] UI_Pika_Results()
        {
              string[] UI_Result_Pik = {"\t\t ",
                "\t\t                         ",
                "\t\t __________________________________",
                "\t\t|                                  |",
                "\t\t|                                  |",
                "\t\t|                                  |",
                "\t\t|                                  |",
                "\t\t|                                  |",
                "\t\t|                                  |",
                "\t\t|                                  |",
                "\t\t|                                  |",
                "\t\t\t|                                  |",
                "\t\t\t|__________________________________|",
                "\t\t",
            };
            return UI_Result_Pik;
        }






    }
}
