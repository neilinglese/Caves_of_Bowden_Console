using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using CavesofBowden;

namespace CavesofBowden
{
    class Program
    {
        static void Main(string[] args)
        {
            Title();
        }
        static void Title() //title screen
        {
            Console.CursorVisible = false;
            int leftOffSet = (Console.WindowWidth / 2) - 19;
            int topOffSet = (Console.WindowHeight / 2) - 2;
            int topOffSet1 = (Console.WindowHeight / 2) - 1;
            int topOffSet2 = (Console.WindowHeight / 2) - -1;
            int topOffSet3 = (Console.WindowHeight / 2) - 4;
            int topOffSet4 = (Console.WindowHeight / 2) - 3;
            int topOffSet5 = (Console.WindowHeight / 2) - 0;
            int topOffSet6 = (Console.WindowHeight / 2) - -2;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.SetCursorPosition(leftOffSet, topOffSet3);
            Console.WriteLine("=======================================");
            Console.SetCursorPosition(leftOffSet, topOffSet4);
            Console.WriteLine("|                                     |");
            Console.SetCursorPosition(leftOffSet, topOffSet);
            Console.WriteLine("|           Caves of Bowden           |");    //change this title      
            Console.SetCursorPosition(leftOffSet, topOffSet1);
            Console.Write("|           "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("By Neil Inglese"); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("           |"); //By Line
            Console.SetCursorPosition(leftOffSet, topOffSet5);
            Console.WriteLine("|                                     |");
            Console.SetCursorPosition(leftOffSet, topOffSet2);
            Console.WriteLine("|      Press Any Key To Continue...   |"); // Continue Line
            Console.SetCursorPosition(leftOffSet, topOffSet6);
            Console.WriteLine("=======================================");
            Console.ReadKey();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Intro();
        }
        static void Intro() //varables and instructions
        {
            string[] names =
            {
                " ", //0 name
                " ", //1 class
                " ",//2 choice
                "Caldwell", //3 party1
                "Taneya", //4 party2
                "Ark", //5 party3
                "key", //6 item1
                "map",//7 item2
                "medpack",//8 item3
                "health",//9 stats1
                "willpower",//10 stats2
                "strength",//11 stats3
                "agility",//12 stats4
                "luck",//13 stats5
                "empty"//14 empty
            };
            bool[] item =
           {
               false,//0 party1
               false,//1 party2
               false,//2 party3
               false,//3 key
               false,//4 map
               false,//5 medpack
               false,//6
               false,//7
               true,//8
           };
            int[] num =
            {
                0,//0 health
                0,//1 willpower
                0,//2 strength
                0,//3 agility
                0,//4 luck

                
            };
            string[] menu =
            {
                "You cannot go that way...", //0 directions
                "There is nothing to pick up right now...", //1 pickup
                "You don't have anything to use right now...", //2 use
                "You have picked up ", //3 picked up
                " has joined your party!",//4 joined you
            };
            string[] text =
            {
                
            };

            int leftOffSet = (Console.WindowWidth / 2) - 8;
            int leftOffSet1 = (Console.WindowWidth / 2) - 12;

            int topOffSet = (Console.WindowHeight / 2) - 10;
            int topOffSet1 = (Console.WindowHeight / 2) - -7;
            Console.CursorVisible = false;

            string text1 = "Welcome Champion!\n\n\n";
            string text2 = "The Caves of Bowden is a game inspired by the choose your own adventure books.\n";
            string text3 = "You will be able to make decisions throughout the game that will effect\nthe outcome.\n";
            string text4 = "By using the colored letters on the menu, select your choices wisely.\n";
            string text5 = "If your unsure of what to do, try looking around your surroundings,\nyou might find the answer your looking for.\n";
            string text6 = "Your adventure awaits....";
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();
            Console.SetCursorPosition(leftOffSet, topOffSet);
            for (int z = 0; z < text1.Length; z++)
            {
                Console.Write(text1[z]);
                Thread.Sleep(75);
            }
            for (int z = 0; z < text2.Length; z++)
            {
                Console.Write(text2[z]);
                Thread.Sleep(25);
            }
            for (int z = 0; z < text3.Length; z++)
            {
                Console.Write(text3[z]);
                Thread.Sleep(25);
            }
            for (int z = 0; z < text4.Length; z++)
            {
                Console.Write(text4[z]);
                Thread.Sleep(25);
            }
            for (int z = 0; z < text5.Length; z++)
            {
                Console.Write(text5[z]);
                Thread.Sleep(25);
            }
            Console.SetCursorPosition(leftOffSet1, topOffSet1);
            for (int z = 0; z < text6.Length; z++)
            {
                Console.Write(text6[z]);
                Thread.Sleep(50);
            }
            Console.ReadLine();
            Creation myCreation = new Creation(names, menu, text, item, num);
        }
    }//title,intro,varables
   
}
