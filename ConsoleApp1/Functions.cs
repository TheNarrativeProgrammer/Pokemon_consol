using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Functions
    {

        //space
        public static void Space()
        {
            Console.WriteLine("");
        }

        //error message
        public static void Error()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[please try again]");
            Console.ForegroundColor = ConsoleColor.White;
        }

        //pause or enter to continue
        public static void Pause()
        {
            Console.ReadLine();
        }

        //continue button

        public static void Continue()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[press any key to continue]");
            Console.ForegroundColor = ConsoleColor.White;
            //read key reads any key press
            Console.ReadKey();

            Console.Clear();
        }


    }
}
