using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CavesofBowden;

namespace CavesofBowden
{
    class Stats //stats
    {
        public Stats(string[] names, string[] menu, string[] text, bool[] item, int[] num)
        {
            Console.Clear();
            Console.WriteLine("Name: " + names[0]);
            Console.WriteLine("Class: " + names[1]);
            Console.WriteLine("========================");
            Console.WriteLine("Health: " + num[0]);
            Console.WriteLine("Willpower: " + num[1]);
            Console.WriteLine("Strength: " + num[2]);
            Console.WriteLine("Agility: " + num[3]);
            Console.WriteLine("Luck: " + num[4]);
            Console.WriteLine("\n\n");
            Console.WriteLine("Party Members");
            Console.WriteLine("========================");
            if (item[0] == true)
            {
                Console.WriteLine(names[3]);
            }
            else
            {
                Console.WriteLine(names[14]);
            }
            if (item[1] == true)
            {
                Console.WriteLine(names[4]);
            }
            else
            {
                Console.WriteLine(names[14]);
            }
            if (item[2] == true)
            {
                Console.WriteLine(names[5]);
            }
            else
            {
                Console.WriteLine(names[14]);
            }

            Console.WriteLine("\nInventory");
            Console.WriteLine("========================");
            if (item[3] == true)
            {
                Console.WriteLine(names[6]);
            }
            else
            {
                Console.WriteLine(names[14]);
            }
            if (item[4] == true)
            {
                Console.WriteLine(names[7]);
            }
            else
            {
                Console.WriteLine(names[14]);
            }
            if (item[5] == true)
            {
                Console.WriteLine(names[8]);
            }
            else
            {
                Console.WriteLine(names[14]);
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}
