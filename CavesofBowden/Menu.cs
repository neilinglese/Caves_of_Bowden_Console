﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CavesofBowden;

namespace CavesofBowden
{
    class Menu
    {
        public Menu(string[] names, string[] menu, string[] text, bool[] item, int[] num)
        {
            int leftOffSet = (Console.WindowWidth / 2) - 35;
            int leftOffSet1 = (Console.WindowWidth / 2) - 20;
            int leftOffSet2 = (Console.WindowWidth / 2) - 5;


            int topOffSet = (Console.WindowHeight / 2) - -07;
            int topOffSet2 = (Console.WindowHeight / 2) - -06;
            int topOffSet3 = (Console.WindowHeight / 2) - -11;

            Console.SetCursorPosition(leftOffSet, topOffSet);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(leftOffSet, topOffSet);
            Console.WriteLine();
            Console.Write("=========================================================================================================\n");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("             U"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("se| ");
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("look"); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(" A"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("round| ");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("T"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("alk| ");
            Console.Write("do "); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("N"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("othing| ");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("P"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("ickup| ");
            Console.Write("");
            Console.Write("");
            Console.Write("");
            Console.Write("");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("S"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("tats|                                          \n");
            Console.WriteLine("=========================================================================================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            if (item[3] == true)
            {
                Console.SetCursorPosition(leftOffSet, topOffSet3);
                Console.Write(names[6]);
            }
            else
            {
                Console.SetCursorPosition(leftOffSet, topOffSet3);
                Console.Write(names[14]);
            }
            if (item[4] == true)
            {
                Console.SetCursorPosition(leftOffSet1, topOffSet3);
                Console.Write(names[7]);
            }
            else
            {
                Console.SetCursorPosition(leftOffSet1, topOffSet3);
                Console.Write(names[14]);
            }
            if (item[5] == true)
            {
                Console.SetCursorPosition(leftOffSet2, topOffSet3);
                Console.Write(names[8]);
            }
            else
            {
                Console.SetCursorPosition(leftOffSet2, topOffSet3);
                Console.Write(names[14]);
            }

            Console.SetCursorPosition(leftOffSet, topOffSet2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

        }

    }
}
