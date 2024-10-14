﻿using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class UI 
    {
        //MEMBER VARIABLES - NON POKEMON

        //MEMBER VARIABLES - POKEMON AS STRINGS
        public string[] mUIBulbasaur_String = 
            {"                                                   /",
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
                "\t ",
                "\t ",
                "\t ",
                "\t ",
                "\t ",
            };
        public string[] mUISquirtle_String = 
            {"                           _,........__",
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
                "\t         `--,\\       .            `7\"\"' |  ,      |",
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
                "\t",
            };
        public string[] mUICharamander_String = 
                {"              _.--\"\"`-..",
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
                "\t           |                 |       L              ,' |",
                "\t           `                 |       |             /   '",
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

    }


}
