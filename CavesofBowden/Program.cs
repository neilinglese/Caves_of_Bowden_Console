using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace frames
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
    class Menu //menu for story
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
            Console.Write("================================================================================");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("             U"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("se| ");
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("look"); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(" A"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("round| ");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("T"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("alk| ");
            Console.Write("do "); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("N"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("othing| ");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("P"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("ickup| ");
            Console.Write("");
            Console.Write("");
            Console.Write("");
            Console.Write("");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("S"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("tats|                 ");
            Console.WriteLine("================================================================================");
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
    class DMenu //menu for transition
    {
        public DMenu(string[] names, string[] menu, string[] text, bool[] item, int[] num)
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
            Console.Write("================================================================================");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("                         F"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("orward | ");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("L"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("eft |");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(" R"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("ight | ");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(" B"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("ack |                       ");
            Console.WriteLine("================================================================================");
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
    class Creation //char creation
    {
        public Creation(string[] names, string[] menu, string[] text, bool[] item, int[] num)
        {
            //left sets
            int leftOffSet = (Console.WindowWidth / 2) - 12; //left center
            int leftOffSet1 = (Console.WindowWidth / 2) - 8; //center 
            int leftOffSet2 = (Console.WindowWidth / 2) - 25; //center 
            int leftOffSet3 = (Console.WindowWidth / 2) - 8; //center 

            //top sets
            int topOffSet = (Console.WindowHeight / 2) - 0; //middle
            int topOffSet1 = (Console.WindowHeight / 2) - 2; // +2
            int topOffSet2 = (Console.WindowHeight / 2) - 3; //+3
            int topOffSet3 = (Console.WindowHeight / 2) - 4; //+5
            int topOffSet4 = (Console.WindowHeight / 2) - 6; // +6
            Console.Clear();
            //start color
            Console.ForegroundColor = ConsoleColor.White;
            //name
            Console.SetCursorPosition(leftOffSet, topOffSet1);
            Console.WriteLine("Please enter your a name...");
            Console.SetCursorPosition(leftOffSet1, topOffSet);
            names[0] = Console.ReadLine(); // class name
            Console.Clear();
            Console.SetCursorPosition(leftOffSet2, topOffSet1);
            Console.WriteLine("Are you sure you want " + names[0] + " as your name? Y or N");
            Console.SetCursorPosition(leftOffSet1, topOffSet);
            names[2] = Console.ReadLine();
            switch (names[2].ToLower())
            {
                case "y":
                    Console.Clear();
                    break;
                case "n":
                    Console.Clear();
                    new Creation(names, menu, text, item, num);
                    break;
                default:
                    Console.Clear();
                    new Creation(names, menu, text, item, num);
                    break;
            }
            Console.Clear();
            //class
            Console.SetCursorPosition(leftOffSet, topOffSet4);
            Console.WriteLine(names[0] + ", now choose a class...");
            Console.SetCursorPosition(leftOffSet, topOffSet3);
            Console.Write("1)"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(" Warrior\n"); Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(leftOffSet, topOffSet2);
            Console.Write("2)"); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(" Thief\n"); Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(leftOffSet, topOffSet1);
            Console.Write("3)"); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(" Mage\n"); Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(leftOffSet, topOffSet);
            names[1] = Console.ReadLine();

            switch (names[1])
            {
                case "1":
                    names[1] = "warrior";
                    num[0] = 200;
                    num[1] = 0;
                    num[2] = 150;
                    num[3] = 50;
                    num[4] = 25;
                    break;
                case "2":
                    names[1] = "thief";
                    num[0] = 150;
                    num[1] = 0;
                    num[2] = 25;
                    num[3] = 200;
                    num[4] = 50;
                    break;
                case "3":
                    names[1] = "mage";
                    num[0] = 150;
                    num[1] = 200;
                    num[2] = 0;
                    num[3] = 0;
                    num[4] = 75;
                    break;
                default:
                    names[1] = "warrior";
                    num[0] = 200;
                    num[1] = 0;
                    num[2] = 150;
                    num[3] = 50;
                    num[4] = 25;
                    break;
            }
            Prelude(names, menu, text, item, num);
        }
        public void Prelude(string[] names, string[] menu, string[] text, bool[] item, int[] num) //class intros
        {
            Console.Clear();
            while (names[1] == "warrior")
            {
                Console.WriteLine("“Another ale barkeep!” you shout.");
                Console.WriteLine("You find yourself in a small tavern in the royal city of Silverhaven.");
                Console.WriteLine("The stench of alcohol fills the air. The crowd’s commotion echo’s your ears.");
                Console.WriteLine("The tavern is unusually crowed for a typical night. As you look around, you");
                Console.WriteLine("notice the patrons are mostly Imperial soldiers.\n");
                Console.WriteLine("“He made farther than any other has.“overhearing one of the soldiers saying.");
                Console.WriteLine("“Wonder what exactly he was after. Think he was after the Sapphire of Allize?”");
                Console.WriteLine("“Doesn’t matter, I just want to know how he thought he was going to get out.");
                Console.WriteLine("No man can beat the Knights of Seven”, he says.");
                Console.WriteLine("The last sentence echoes in your ears.No one can beat them, you say to yourself");
                Console.WriteLine("Never one for self-control, especially after a few drinks, you always enjoy a");
                Console.WriteLine("challenge.\n");
                Console.WriteLine("You stand up, tap the guard on the shoulder,as he turns around you smash your");
                Console.WriteLine("mug right on his head. Immediately the other guards jump out of their seats");
                Console.WriteLine("You fight them off in waves. Two, Three, Four at a time, they are no match");
                Console.WriteLine("for your raw strength. After several rounds, you here a whistle, it’s the");
                Console.WriteLine("commander of the Knights.“Enough of this!” he yells out.");
                Console.WriteLine("Thinking here is someone that can challenge you, you make your way towards him");
                Console.WriteLine("drowning the rest of the bar out. That’s when you feel it, a guard had");
                Console.WriteLine("snuck up behind you and cracked the back of your head with the hilt of a sword.");
                Console.WriteLine("You go down.");
                Console.ReadLine();
                break;

            }
            while (names[1] == "thief")
            {
                Console.WriteLine("Only a few more doors, and you will be there.");
                Console.WriteLine("No thief has ever been this far into the palace without being caught.");
                Console.WriteLine("“I think I heard something down here.” one of the royal guards yells out.");
                Console.WriteLine("They are getting close, you must hurry. You begin to pick the lock of");
                Console.WriteLine("the treasury doors. The gem of Allize is just inside. With that");
                Console.WriteLine("you will no longer need to steal. You will be rich, and famous.");
                Console.WriteLine("All of your hopes, and your dreams, are locked behind this door.");
                Console.WriteLine("Click...you hear the lock popping open.\n");
                Console.WriteLine("As you turn the handle, you feel a sharp pain in your leg.");
                Console.WriteLine("The soldiers have found you, and one of them has shot an arrow in your");
                Console.WriteLine("leg. You pull the arrow out, each second its in hurts more.");
                Console.WriteLine("“We got him, down here!” the guard exclaims.");
                Console.WriteLine("Reinforcements are on their way. You can hear their steps getting closer.");
                Console.WriteLine("You try to make a run for it, the treasure will have to wait.");
                Console.WriteLine("The pain in your leg is slowing you down, your unable to move fast enough.");
                Console.WriteLine("The guards surround you. At least 20 of them chase behind you.");
                Console.WriteLine("The only choice is to attempt to fight them off. With this injury you won't");
                Console.WriteLine("be able to escape. You turn to fight, but when you do, you are pierced");
                Console.WriteLine("with another arrow, this one in the shoulder. It drops you down to your");
                Console.WriteLine("knees. You begin to fade out of consciousness.");
                Console.ReadLine();
                break;
            }
            while (names[1] == "mage")
            {
                Console.WriteLine("It is a dark night. The moon the only source of light, guiding you through the");
                Console.WriteLine("dense forest of Glassdell. You are fleeing from the Imperial soldiers, however");
                Console.WriteLine("these are not just any soldiers. They are the Knights of Seven.");
                Console.WriteLine("If you’re caught, at best you will be thrown in an imperial cell, to await");
                Console.WriteLine("a sentence of death, worse case they will kill you on the spot.\n");
                Console.WriteLine("“I see him”, a knight shouts as he catches a glimpse of you. “This way!”");
                Console.WriteLine("Someone had tipped the guards off to the location of the small village.");
                Console.WriteLine("They came quickly and quietly. You're now fleeing for your life");
                Console.WriteLine("“In the name of Allize stop!” The guards exclaim.");
                Console.WriteLine("Knowing there is little chance to escape, you stop.");
                Console.WriteLine("You begin to set the trees around you on fire.");
                Console.WriteLine("The guards focus is drawn to you. There is too many though,if these were normal");
                Console.WriteLine("soldiers might be able to get away,but these are mage killers. They surround you");
                Console.WriteLine("as you attempt to fight back,you get hit by an arrow.The hypocritical guards");
                Console.WriteLine("use an enchanted arrow to pierce your shoulder. It dulls your magic");
                Console.WriteLine("and your senses. You begin to fall to the ground.");
                Console.ReadLine();
                break;
            }

            int leftOffSet5 = (Console.WindowWidth / 2) - 12;
            int topOffSet5 = (Console.WindowHeight / 2) - 2;
            Console.Clear();
            Console.SetCursorPosition(leftOffSet5, topOffSet5);
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("Chapter One "); Console.ForegroundColor = ConsoleColor.White; Console.Write(" - "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("The Escape"); Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
            Story MyStory = new Story(names, menu, text, item, num);
        }
    }
    class Story //story for the game
    {
        public Story(string[] names, string[] menu, string[] text, bool[] item, int[] num)
        {
            int leftOffSet = (Console.WindowWidth / 2) - 3;
            int leftOffSet2 = (Console.WindowWidth / 2) - 12;
            int leftOffSet3 = (Console.WindowWidth / 2) - 8;
            int leftOffSet4 = (Console.WindowWidth / 2) - 21;

            int topOffSet = (Console.WindowHeight / 2) - 2;

            int leftOffSet5 = (Console.WindowWidth / 2) - 12;
            int topOffSet5 = (Console.WindowHeight / 2) - 2;


            string text1 = "Hey....";
            string text2 = "Hey you there, wake up...";
            string text3 = "Are you ok?";
            string text4 = "You must be that " + names[1] + " they dragged in last night.";

            Console.Clear();
            Console.SetCursorPosition(leftOffSet, topOffSet);
            for (int z = 0; z < text1.Length; z++)
            {
                Console.Write(text1[z]);
                Thread.Sleep(75);
            }
            Console.Clear();
            Console.SetCursorPosition(leftOffSet2, topOffSet);
            for (int z = 0; z < text2.Length; z++)
            {
                Console.Write(text2[z]);
                Thread.Sleep(75);
            }
            Console.Clear();
            Console.SetCursorPosition(leftOffSet3, topOffSet);
            for (int z = 0; z < text3.Length; z++)
            {
                Console.Write(text3[z]);
                Thread.Sleep(75);
            }
            Console.Clear();
            Console.SetCursorPosition(leftOffSet4, topOffSet);
            for (int z = 0; z < text4.Length; z++)
            {
                Console.Write(text4[z]);
                Thread.Sleep(75);
            }



            Console.Clear();
            Console.WriteLine("You begin to awaken to the sound of an unknown voice. You notice you’re in a ");
            Console.WriteLine("small Imperial cell. There is nothing in it except for a cold stone slab used");
            Console.WriteLine("for a bed, and a large pot. You can see across from your cell, another prisoner");
            Console.WriteLine("is locked up. He must have been the voice that awoken you. The prisoner is");
            Console.WriteLine("attempting to get your attention.\n");
            Console.WriteLine("You continue to ignore him as you gather your thoughts. For some");
            Console.WriteLine("reason you cannot remember, and have no idea how you ended up in here.");
            Console.WriteLine("Maybe you should indulge him, maybe he has some answers….");

            Console.ReadLine();
            Story1(names, menu, text, item, num);
        }
        public void Story1(string[] names, string[] menu, string[] text, bool[] item, int[] num)
        {

            Console.Clear();
            Console.WriteLine("“I have been behind these bars for far too long. You are the first real person");
            Console.WriteLine("person I have seen in ages.” the prisoner explains.");
            Console.WriteLine("“They only send the people who are sentenced to death down here.");
            Console.WriteLine("However I know of a passage that would lead us to freedom.");
            Console.WriteLine("They built in incase of an emergency back when the first of the bloodline was");
            Console.WriteLine("king. It has since been forgotten. If there is anything you can do to help");
            Console.WriteLine("us escape from these bars, I can lead us out of this wretched place.”");

            Menu myMenu = new Menu(names, menu, text, item, num);
            names[2] = Console.ReadLine();

            switch (names[2])
            {
                case "a":
                    Console.Clear();
                    Console.WriteLine("You look around your cell. There isnt to much you could use to escape.");
                    Console.WriteLine("Directly across from your cell is the other prisioner, a burely man,");
                    Console.WriteLine("he looks as if he has seen better days.\n");
                    Console.WriteLine("Upon closer inspection you can notice the bars are in poor shape.");
                    Console.WriteLine("Maybe with enough force, or using on of your skills, you might be able to");
                    Console.WriteLine("break out of the cell, and free yourself.");
                    Console.ReadLine();
                    Console.Clear();
                    Story1(names, menu, text, item, num);
                    break;

                case "t":

                    Console.Clear();
                    Console.WriteLine("“I'm sorry,I forgotton my manners, my name is Caldwell.” the prisioner says.");
                    Console.WriteLine("“Your "+names[0]+" right? I heard them mention it as they dragged you down here.”");
                    while (names[1] == "warrior")
                    {
                        Console.WriteLine("“I overheard them talking about how you started a fight in the tavern.”");
                        Console.WriteLine("“You managed to take down five of the Knights of Seven, single handedly");
                        Console.WriteLine("I am impressed.” Caldwell says.");
                        Console.ReadLine();
                        Console.Clear();
                        Story1(names, menu, text, item, num);
                        break;
                    }
                    while (names[1] == "mage")
                    {
                        Console.WriteLine("“I overheard them talking about how they caught you outside of Glassdell.”");
                        Console.WriteLine("“Appearently your friend got away, they were enraged they couldn't catch her”");
                        Console.WriteLine("Caldwell explains.");
                        Console.ReadLine();
                        Console.Clear();
                        Story1(names, menu, text, item, num);
                        break;
                    }
                    while (names[1] == "thief")
                    {
                        Console.WriteLine("“I overheard them talking about how they caught you inside the palace.”");
                        Console.WriteLine("“No one has made it as far as you have.” Caldwell explains.");
                        Console.WriteLine("“I am very impressed.”");
                        Console.ReadLine();
                        Console.Clear();
                        Story1(names, menu, text, item, num);
                        break;
                    }
                    break;

                case "n":
                    Console.Clear();
                    Console.WriteLine("You remain silent, ignoring the other prisoner,");
                    Console.WriteLine("as you attempt to compose yourself.");
                    Console.ReadLine();
                    Console.Clear();
                    Story1(names, menu, text, item, num);
                    break;

                case "p":
                    Console.Clear();
                    Console.WriteLine(menu[1]);
                    Console.ReadLine();
                    Console.Clear();
                    Story1(names, menu, text, item, num);
                    break;

                case "u":
                    Console.Clear();
                    while (names[1] == "warrior")
                    {
                        Console.WriteLine("You grab ahold of the cell bars. Using your raw strenght you begin\ntoo bend them.");
                        Console.WriteLine("You are able to snap the bars themself off the hinges that held them.");
                        Console.WriteLine("Freeing yourself from your cell. You quickly go over\nand do the same and free Caldwell.");
                        Console.ReadLine();
                        Console.Clear();
                        Story2(names, menu, text, item, num);
                        break;
                    }
                    while (names[1] == "mage")
                    {
                        Console.WriteLine("The guards must have thought you would be knocked out for a few more days.");
                        Console.WriteLine("They never would have locked a mage in such a cell. You grab ahold of the bars,");
                        Console.WriteLine("the bars begin to turn into ice, and then shatter. You free yourself, then\nquickly go and free Caldwell.");
                        Console.ReadLine();
                        Console.Clear();
                        Story2(names, menu, text, item, num);
                        break;
                    }
                    while (names[1] == "thief")
                    {
                        Console.WriteLine("You're able to break a small,sharp piece of iron off off the rusting cell door.");
                        Console.WriteLine("Using it as a make shift lock pick, you are able to unlock your cell.");
                        Console.WriteLine("After freeing yourself, you quickly go and unlock Caldwell's cell.");
                        Console.ReadLine();
                        Console.Clear();
                        Story2(names, menu, text, item, num);
                        break;
                    }
                    break;

                case "s":
                    Console.Clear();
                    Stats myStats = new Stats(names, menu, text, item, num);
                    Story1(names, menu, text, item, num);
                    break;

                default:
                    Console.Clear();
                    Story1(names, menu, text, item, num);
                    break;

            }
            Console.ReadLine();
        }//escape
        public void Story2(string[] names, string[] menu, string[] text, bool[] item, int[] num)
        {
            Console.WriteLine("“You did it!” Caldwell exclaims.");
            Console.WriteLine("“They must have heard the noise though, they will come to investigate soon.");
            Console.WriteLine("We must hurry, quickly follow me. He grabs a torch from the wall to light");
            Console.WriteLine("the path ahead.\n");
            Console.WriteLine("Deciding to trust Caldwell, as he seems just as desperate to escape this");
            Console.WriteLine("wretched place as you do, you follow him down a series of hallways.");
            Console.WriteLine("The two of you reach a dead end.");
            Console.WriteLine("“It has to be here somewhere” he remarks as he frantically begins pushing");
            Console.WriteLine("the stone blocks that line the wall.");
            Console.WriteLine("“Here”, you here a click as the block he presses slowly moves into the wall.");
            Console.WriteLine("The wall itself begins to slowly move back revealing a passage.");
            Console.WriteLine("“Let me know when you’re ready” Caldwell says.");


            Menu myMenu = new Menu(names, menu, text, item, num);
            names[2] = Console.ReadLine();

            switch (names[2])
            {
                case "a":
                    Console.Clear();
                    Console.WriteLine("The halls are dark, the torches that align them barely light your path.");
                    Console.WriteLine("The trap door is open, but it won't stay that way for long.");
                    Console.WriteLine("Talk to Caldwell and let him know your ready to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    Story2(names, menu, text, item, num);
                    break;

                case "t":

                    Console.Clear();
                    Console.WriteLine("“I'm ready, lets get out of this place” you tell Caldwell.");
                    Console.ReadLine();
                    Console.Clear();
                    Story3(names, menu, text, item, num);
                    break;

                case "n":
                    Console.Clear();
                    Console.WriteLine("You stand still, listening for any sign the guards are follwing you.");
                    Console.WriteLine("Caldwell just stares at you.");
                    Console.ReadLine();
                    Console.Clear();
                    Story2(names, menu, text, item, num);
                    break;

                case "p":
                    Console.Clear();
                    Console.WriteLine(menu[1]);
                    Console.ReadLine();
                    Console.Clear();
                    Story2(names, menu, text, item, num);
                    break;

                case "u":
                    Console.Clear();
                    Console.WriteLine(menu[2]);
                    Console.ReadLine();
                    Console.Clear();
                    Story2(names, menu, text, item, num);
                    break;

                case "s":
                    Console.Clear();
                    Stats myStats = new Stats(names, menu, text, item, num);
                    Story2(names, menu, text, item, num);
                    break;

                default:
                    Console.Clear();
                    Story2(names, menu, text, item, num);
                    break;

            }
        }//escape1
        public void Story3(string[] names, string[] menu, string[] text, bool[] item, int[] num)
        {
            Console.WriteLine("You follow him through the passage, and the two of you push the wall back");
            Console.WriteLine("in place covering your tracks. The only source of light is the torch,");
            Console.WriteLine("you can barely see. The smell of decay, and things you can’t even imagine");
            Console.WriteLine("lingers in the air. The sounds of rats scurrying haunts your ears.\n");
            Console.WriteLine("“This way, it wont be to far now.” He says.\n");
            Console.WriteLine("The two of you treck through a series of winding tunnels for what seems");
            Console.WriteLine("like hours. Your pretty sure he is lost, but wont admit it.");
            Console.WriteLine("At last you can see something up ahead, a glimmer of light pierces through the");
            Console.WriteLine("tunnels.\n");
            Console.WriteLine("“That’s it we are almost free!”, Caldwell yells in excitement.");
            Console.WriteLine("At last you are out from tunnels. The smell of fresh air overwhelms your senses");
            Console.WriteLine("the chirps of birds is a welcomed sound.");

            Menu myMenu = new Menu(names, menu, text, item, num);
            names[2] = Console.ReadLine();

            switch (names[2])
            {
                case "a":
                    Console.Clear();
                    Console.WriteLine("Before you is a lake, the tunnels must have been used as a drain\npipe at one time.");
                    Console.WriteLine("The birds are singing around you. Behind you is the tunnels you spent so\nlong in to escape.");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                    Story3(names, menu, text, item, num);
                    break;

                case "t":

                    Console.Clear();
                    Console.WriteLine("“Thank you, Caldwell. I dont know how I would have escaped.” you tell Caldwell.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                    Story4(names, menu, text, item, num);
                    break;

                case "n":
                    Console.Clear();
                    Console.WriteLine("You just look around. You have never felt so grateful to be outside in your life.");
                    Console.WriteLine("The fresh smelling air, and the songs of the birds send you into a deep trance.");
                    Console.ReadLine();
                    Console.Clear();
                    Story3(names, menu, text, item, num);
                    break;

                case "p":
                    Console.Clear();
                    Console.WriteLine(menu[1]);
                    Console.ReadLine();
                    Console.Clear();
                    Story3(names, menu, text, item, num);
                    break;

                case "u":
                    Console.Clear();
                    Console.WriteLine(menu[2]);
                    Console.ReadLine();
                    Console.Clear();
                    Story3(names, menu, text, item, num);
                    break;

                case "s":
                    Console.Clear();
                    Stats myStats = new Stats(names, menu, text, item, num);
                    Story3(names, menu, text, item, num);
                    break;

                default:
                    Console.Clear();
                    Story3(names, menu, text, item, num);
                    break;

            }

        }//escape2
        public void Story4(string[] names, string[] menu, string[] text, bool[] item, int[] num)
        {
            Console.WriteLine("“Thank you, I never dreamt I would be free again. I could not have done it");
            Console.WriteLine("without your help!” he says. “However I do not know what I will do with my");
            Console.WriteLine("freedom, it has been far too long. Everything I cared is gone.");
            Console.WriteLine("You can see the realization hit him, as the look of hope drains from his face");
            Console.WriteLine("replaced only with the gloom you first saw in his eyes.\n");
            Console.WriteLine("“I know of a lost treasure. Let me come with you and we can find it together.”");
            Console.WriteLine("he says. Caldwell has been a great help, without him you never would have");
            Console.WriteLine("made it out of those cells. You agree to let him accompany you.\n");
            Console.WriteLine("“The only problem is, no one has been able to find the Caves of Bowden.”");
            Console.WriteLine("“I had a map that was supposed to lead me there before I got imprisoned");
            Console.WriteLine("I lost it in the town of Ironshire.”");
            Console.WriteLine("“I have also heard rumors that the mages of Glassdell know of the path,");
            Console.WriteLine("and a thief had once been there, it is rumored he is hiding out in Winterhaven.”");

            Menu myMenu = new Menu(names, menu, text, item, num);
            names[2] = Console.ReadLine();

                        switch (names[2])
            {
                case "a":
                Console.Clear();
                Console.WriteLine("Before you is the main road. It forks in four different directions.");
                Console.WriteLine("A path towards Glassdell, one towards Ironshire, one towards Winterhaven.");
                Console.WriteLine("The fourth leads back towards Silverhaven, its probably not a good idea to");
                Console.WriteLine("return to the city. They will surely be looking for you.");
                Console.WriteLine("Maybe talking to Caldwell will help you decide.");
                Console.ReadLine();
                Console.Clear();
                Story4(names, menu, text, item, num);
                break;

                case "t":
          
                Console.Clear();
                Console.WriteLine("“It’s your choice which way we take.” Caldwell says.");
                item[0] = true;
                Console.ReadLine();
                Console.Clear();
                Story5(names, menu, text, item, num);
                break;

                case "n":
                Console.Clear();
                Console.WriteLine("You look towards the road. Debating on which path to take.");
                Console.WriteLine("");
                Console.ReadLine();
                Console.Clear();
                Story4(names, menu, text, item, num);
                break;

                case "p":
                Console.Clear();
                Console.WriteLine(menu[1]);
                Console.ReadLine();
                Console.Clear();
                Story4(names, menu, text, item, num);
                break;

                case "u":
                Console.Clear();
                Console.WriteLine(menu[2]);
                Console.ReadLine();
                Console.Clear();
                Story4(names, menu, text, item, num);
                break;

                case "s":
                Console.Clear();
                Stats myStats = new Stats(names, menu, text, item, num);
                Story4(names, menu, text, item, num);
                break;

                default:
                Console.Clear();
                Story4(names, menu, text, item, num);
                break;

            }

        }//escape3
        public void Story5(string[] names, string[] menu, string[] text, bool[] item, int[] num)
        {

            int leftOffSet5 = (Console.WindowWidth / 2) - 12;
            int topOffSet5 = (Console.WindowHeight / 2) - 2;


            Console.WriteLine("You now have a choice to make");
            Console.WriteLine("=============================");
            Console.WriteLine("Going Forward will take you to the town of Ironshire.");
            Console.WriteLine("Going Left will take you towards Glassdell forest, and the mages.");
            Console.WriteLine("Going Right will take you towards Winterhaven, in search of the thief.");
            Console.WriteLine("");
            Console.WriteLine("");


            DMenu myDMenu = new DMenu(names, menu, text, item, num);
            names[2] = Console.ReadLine();

            switch (names[2])
            {
                case "f":
                    Console.Clear();			
			        Console.SetCursorPosition(leftOffSet5, topOffSet5);
                    Console.ForegroundColor = ConsoleColor.Green;Console.Write("Chapter Two ");Console.ForegroundColor = ConsoleColor.White;Console.Write(" - ");Console.ForegroundColor = ConsoleColor.Cyan;Console.Write("Old Friends");Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    Console.Clear();

                    Story6(names, menu, text, item, num);
                    break;

                case "b":

                    Console.Clear();
                    Story5(names, menu, text, item, num);
                    break;

                case "r":
                    Console.Clear();			
			        Console.SetCursorPosition(leftOffSet5, topOffSet5);
                    Console.ForegroundColor = ConsoleColor.Green;Console.Write("Chapter Two ");Console.ForegroundColor = ConsoleColor.White;Console.Write(" - ");Console.ForegroundColor = ConsoleColor.Cyan;Console.Write("Is anyone home?");Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    Console.Clear();			
                    Story12(names, menu, text, item, num);
                    break;

                case "l":
                    Console.Clear();			
			        Console.SetCursorPosition(leftOffSet5, topOffSet5);
                    Console.ForegroundColor = ConsoleColor.Green;Console.Write("Chapter Two ");Console.ForegroundColor = ConsoleColor.White;Console.Write(" - ");Console.ForegroundColor = ConsoleColor.Cyan;Console.Write("Lending a hand");Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    Console.Clear();
                    Story9(names, menu, text, item, num);
                    break;

                default:
                    Console.Clear();
                    Story5(names, menu, text, item, num);
                    break;

            }
        }//choice
        public void Story6(string[] names, string[] menu, string[] text, bool[] item, int[] num)
        {
            Console.WriteLine("You decide to travel to Ironshire. It’s a small and peaceful town.");
            Console.WriteLine("“Let us get a drink first.” Caldwell suggest.");
            Console.WriteLine("The two of you make your way to a small tavern on the outskirts of the town.");
            Console.WriteLine("Upon entering it you can see this is the only place of entertainment for this");
            Console.WriteLine("village. It’s crowed and the noise drowns out your thoughts. You and Caldwell");
            Console.WriteLine("take a seat at the bar.");

            Menu myMenu = new Menu(names, menu, text, item, num);
            names[2] = Console.ReadLine();

            switch (names[2])
            {
                case "a":
                    Console.Clear();
                    Console.WriteLine("The tavern is lively, it seems as if most of the town is here.");
                    Console.WriteLine("The noise drowns out most of your thoughts.");
                    Console.WriteLine("Everyone seems to be having a good time.");
                    Console.ReadLine();
                    Console.Clear();
                    Story6(names, menu, text, item, num);
                    break;

                case "t":

                    Console.Clear();
                    Console.WriteLine("“Two of your finest ales!” Caldwell bellows out.");
                    Console.WriteLine("“I grew up in this town you know.” Caldwell says as he looks around the room.");
                    Console.WriteLine("“It’s been far to long.”");
                    Console.ReadLine();
                    Console.Clear();
                    Story7(names, menu, text, item, num);
                    break;

                case "n":
                    Console.Clear();
                    Console.WriteLine("You just soak up the atmosphere of the tavern.");
                    Console.ReadLine();
                    Console.Clear();
                    Story6(names, menu, text, item, num);
                    break;

                case "p":
                    Console.Clear();
                    Console.WriteLine(menu[1]);
                    Console.ReadLine();
                    Console.Clear();
                    Story6(names, menu, text, item, num);
                    break;

                case "u":
                    Console.Clear();
                    Console.WriteLine(menu[2]);
                    Console.ReadLine();
                    Console.Clear();
                    Story6(names, menu, text, item, num);
                    break;

                case "s":
                    Console.Clear();
                    Stats myStats = new Stats(names, menu, text, item, num);
                    Story6(names, menu, text, item, num);
                    break;

                default:
                    Console.Clear();
                    Story6(names, menu, text, item, num);
                    break;

            }
        }//neutral start
        public void Story7(string[] names, string[] menu, string[] text, bool[] item, int[] num)
        {
            Console.WriteLine("“Caldwell?” “Caldwell is that you?” As you turn around you see an old man");
            Console.WriteLine("making his way across the tavern towards you. “By Allize, it is you!”");
            Console.WriteLine("“Kirilenko…my old friend!” Caldwell shouts at the old man.");
            Console.WriteLine("“I thought they had you locked up in SIlverhaven.” the old man asks.");
            Console.WriteLine("“They did, but thanks to my friend here, we escaped.”");
            Console.WriteLine("The old man eyes you over, then pats your shoulder. “Thank you.” He tells you.");
            Console.WriteLine("“Ah before I forget, when they dragged you away, you tossed this. ");
            Console.WriteLine("I had a feeling one day you would come back looking for it.” The old man");
            Console.WriteLine("reaches into his pocket and pulls out an old crinkled piece of paper.");

            Menu myMenu = new Menu(names, menu, text, item, num);
            names[2] = Console.ReadLine();

            switch (names[2])
            {
                case "a":
                    Console.Clear();
                    Console.WriteLine("The old man has to be in his 90's at least.");
                    Console.WriteLine("His robes are tattered and torn. He walks with a slight limp.");
                    Console.WriteLine("His cane is a large golden rod, it looks like a very fine walking stick.");
                    Console.WriteLine("You should do nothing and watch the scene unfold.");
                    Console.ReadLine();
                    Console.Clear();
                    Story7(names, menu, text, item, num);
                    break;

                case "t":

                    Console.Clear();
                    Console.WriteLine("You begin to say something but the noise of the crowd drowns out any sound.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                    Story7(names, menu, text, item, num);
                    break;

                case "n":
                    Console.Clear();
                    Console.WriteLine("You just sit there watching Caldwell take the map from the old man.");
                    Console.ReadLine();
                    Console.Clear();
                    Story8(names, menu, text, item, num);
                    break;

                case "p":
                    Console.Clear();
                    Console.WriteLine(menu[1]);
                    Console.ReadLine();
                    Console.Clear();
                    Story7(names, menu, text, item, num);
                    break;

                case "u":
                    Console.Clear();
                    Console.WriteLine(menu[2]);
                    Console.ReadLine();
                    Console.Clear();
                    Story7(names, menu, text, item, num);
                    break;

                case "s":
                    Console.Clear();
                    Stats myStats = new Stats(names, menu, text, item, num);
                    Story7(names, menu, text, item, num);
                    break;

                default:
                    Console.Clear();
                    Story7(names, menu, text, item, num);
                    break;

            }

        }//neutral 1
        public void Story8(string[] names, string[] menu, string[] text, bool[] item, int[] num)
        {
            int leftOffSet5 = (Console.WindowWidth / 2) - 12;
            int topOffSet5 = (Console.WindowHeight / 2) - 2;

                Console.WriteLine("As Caldwell unfolds it he exclaims, “Kirilenko, you sly dog.");
                Console.WriteLine("Do you know what this is ”"+names[0]+"as he ");
                Console.WriteLine("shoves the paper into your face.\n");
                Console.WriteLine("“A map?” you respond.");
                Console.WriteLine("“Not just any map, this is the map I was talking about, this will lead us");
                Console.WriteLine("to the Caves of Bowden!”");
                Console.WriteLine("“Thank you old man, I will not forget about this.”");
                Console.WriteLine("“It is no trouble at all, I knew that’s why they took you away. ");
                Console.WriteLine("I did what I must to protect it.” With that the old man turns around,");
                Console.WriteLine("and disappears back into the crowd.");

            Menu myMenu = new Menu(names, menu, text, item, num);
            names[2] = Console.ReadLine();

            switch (names[2])
            {
                case "a":
                    Console.Clear();
                    Console.WriteLine("Caldwell hold the map in his hands. Searching it for any clues.");
                    Console.WriteLine("Talk to him, see if he found anything.");
                    Console.ReadLine();
                    Console.Clear();
                    Story8(names, menu, text, item, num);
                    break;

                case "t":

                    Console.Clear();
                    Console.WriteLine("“I found it, I know which way to go.” Caldwell says in excitment.");
                    Console.WriteLine("“We don't have much time, lets get out of here.”");
                    item[4] = true;
                    Console.ReadLine();
			        Console.Clear();			
			        Console.SetCursorPosition(leftOffSet5, topOffSet5);
                    Console.ForegroundColor = ConsoleColor.Green; Console.Write("Chapter Three "); Console.ForegroundColor = ConsoleColor.White; Console.Write(" - "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("The Caves");Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    Console.Clear();  
                    Ending myEnding = new Ending(names, menu, text, item, num);
                    break;

                case "n":
                    Console.Clear();
                    Console.WriteLine("You just continue to look around the bar.");
                    Console.WriteLine("There is no sign of the old man, almost as if he just vanished in thin air.");
                    Console.ReadLine();
                    Console.Clear();
                    Story8(names, menu, text, item, num);
                    break;

                case "p":
                    Console.Clear();
                    Console.WriteLine(menu[1]);
                    Console.ReadLine();
                    Console.Clear();
                    Story8(names, menu, text, item, num);
                    break;

                case "u":
                    Console.Clear();
                    Console.WriteLine(menu[2]);
                    Console.ReadLine();
                    Console.Clear();
                    Story8(names, menu, text, item, num);
                    break;

                case "s":
                    Console.Clear();
                    Stats myStats = new Stats(names, menu, text, item, num);
                    Story8(names, menu, text, item, num);
                    break;

                default:
                    Console.Clear();
                    Story8(names, menu, text, item, num);
                    break;

            }

        }//neutral 2
        public void Story9(string[] names, string[] menu, string[] text, bool[] item, int[] num)//good start
        {
            Console.WriteLine("You decide to head towards the forest of Glassdell. From the distance,");
            Console.WriteLine("you can see smoke rising. As you get closer you can see that it is a small");
            Console.WriteLine("wagon flipped on its side and burning. The screams of a young woman echo");
            Console.WriteLine("your ears as you get closer, barely able to make out her cries for help.");
            Console.WriteLine("You and Caldwell begin to sprint towards the scene.\n");
            Console.WriteLine("“Stop it!” she yells.");
            Console.WriteLine("You can see two Imperial soldiers standing over her taunting her.");
            Console.WriteLine("You decide you cannot allow this ruthless assault to happen.\n");
            Console.WriteLine("“Hey! Leave her alone!” you yell.");
            Console.WriteLine("This worked, because now their attention has turned towards you as they");
            Console.WriteLine("make their way towards you and Caldwell.");
            Console.WriteLine("Caldwell quickly grabs one of the nearby wooden planks, and charges at them.");
            Console.WriteLine("He takes a swing nailing one of the guards in the face. The guard drops");
            Console.WriteLine("down as he passes out. The other guard grabs the plank from Caldwell.");


            Menu myMenu = new Menu(names, menu, text, item, num);
            names[2] = Console.ReadLine();

            switch (names[2])
            {
                case "a":
                    Console.Clear();
                    Console.WriteLine("A young woman is on the ground in tears, her wagon is in flames.");
                    Console.WriteLine("Caldwell has taken down one of the guards, but the second seems to ");
                    Console.WriteLine("have him pinned down. You need to do something, or use one of your skills.");
                    Console.ReadLine();
                    Console.Clear();
                    Story9(names, menu, text, item, num);
                    break;

                case "t":

                    Console.Clear();
                    Console.WriteLine("“Hey!” You yell.");
                    Console.WriteLine("It gets the guards attention, do something!");
                    Console.ReadLine();
                    Console.Clear();
                    Story9(names, menu, text, item, num);
                    break;

                case "n":
                    Console.Clear();
                    Console.WriteLine("You just stand there, looking around at the horrific scene.");
                    Console.ReadLine();
                    Console.Clear();
                    Story9(names, menu, text, item, num);
                    break;

                case "p":
                    Console.Clear();
                    Console.WriteLine(menu[1]);
                    Console.ReadLine();
                    Console.Clear();
                    Story9(names, menu, text, item, num);
                    break;

                case "u":
                    Console.Clear();
                    while (names[1] == "warrior")
                    {
                        Console.WriteLine("You charge forward, using your brute strength and tackle the guard.");
                        Console.WriteLine("Taking him down, he hits his head on the ground pretty hard.");
                        Console.WriteLine("He seems to be unconscious now.");
                        Console.ReadLine();
                        Console.Clear();
                        Story10(names, menu, text, item, num);
                        break;
                    }
                    while (names[1] == "mage")
                    {
                        Console.WriteLine("You let out a dazzling display of magic.");
                        Console.WriteLine("Lighting shoots from the tips of your fingers, shocking the other soldier.");
                        Console.WriteLine("This quickly incapacitates him.");
                        Console.ReadLine();
                        Console.Clear();
                        Story10(names, menu, text, item, num);
                        break;
                    }
                    while (names[1] == "thief")
                    {
                        Console.WriteLine("Using your quick thinking, you leap into action, a few lightning fast");
                        Console.WriteLine("kicks to the knee of the guard he goes down, then a quick fist to the");
                        Console.WriteLine("to the back of the head knocks him out cold.");
                        Console.ReadLine();
                        Console.Clear();
                        Story10(names, menu, text, item, num);
                        break;
                    }
                    break;

                case "s":
                    Console.Clear();
                    Stats myStats = new Stats(names, menu, text, item, num);
                    Story9(names, menu, text, item, num);
                    break;

                default:
                    Console.Clear();
                    Story9(names, menu, text, item, num);
                    break;

            }

        }
        public void Story10(string[] names, string[] menu, string[] text, bool[] item, int[] num)
        {
            Console.WriteLine("“You saved me!” the girl exclaims.");
            Console.WriteLine("“Are you ok?” You ask, “What is your name?”");
            Console.WriteLine("“I am Taneya, I am alright, I could use some bandages though,");
            Console.WriteLine("I had a med pack around here, if you can find it I can patch myself up.”");


            Menu myMenu = new Menu(names, menu, text, item, num);
            names[2] = Console.ReadLine();

            switch (names[2])
            {
                case "a":
                    Console.Clear();
                    Console.WriteLine("You look around the horrific scene. A small wagon is in flames");
                    Console.WriteLine("its contents thrown throughout the road. You notice under some of the");
                    Console.WriteLine("rubble is a small med pack.");
                    Console.WriteLine("you should pick it up and give it to Taneya.");
                    Console.ReadLine();
                    Console.Clear();
                    Story10(names, menu, text, item, num);
                    break;

                case "t":

                    Console.Clear();
                    Console.WriteLine("“I think she is a mage.” Caldwell Whispers");
                    Console.WriteLine("“Do you really think we should help her?”");
                    Console.WriteLine("“The Imperials will be looking for her, not to mention us. We can turn back");
                    Console.WriteLine("and disappear now.”");
                    Console.ReadLine();
                    Console.Clear();
                    Story10(names, menu, text, item, num);
                    break;

                case "n":
                    Console.Clear();
                    Console.WriteLine("You just stand still, horrified by the scene.");
                    Console.ReadLine();
                    Console.Clear();
                    Story10(names, menu, text, item, num);
                    break;

                case "p":
                    Console.Clear();
                    Console.WriteLine("You have picked up a med pack!");
                    item[5] = true;
                    Console.ReadLine();
                    Console.Clear();
                    Story10(names, menu, text, item, num);
                    break;

                case "u":
                    Console.Clear();
                    Console.WriteLine("“Stay still,” you tell Taneya as you begin to patch her up.");
                    Console.ReadLine();
                    Console.Clear();
                    Story11(names, menu, text, item, num);
                    break;

                case "s":
                    Console.Clear();
                    Stats myStats = new Stats(names, menu, text, item, num);
                    Story10(names, menu, text, item, num);
                    break;

                default:
                    Console.Clear();
                    Story10(names, menu, text, item, num);
                    break;

            }

        }//good 1
        public void Story11(string[] names, string[] menu, string[] text, bool[] item, int[] num)
        {
            int leftOffSet5 = (Console.WindowWidth / 2) - 12;
            int topOffSet5 = (Console.WindowHeight / 2) - 2;


            Console.WriteLine("“Thank you! I would have been dead if not for the two of you.”");
            Console.WriteLine("“I owe you my life” Taneya cries, “They destroyed everything!”");
            Console.WriteLine("“Let me come with you, I promise I won’t get in the way! I have");
            Console.WriteLine("nowhere else to go.”");

            Menu myMenu = new Menu(names, menu, text, item, num);
            names[2] = Console.ReadLine();
            switch (names[2])
            {
                case "a":
                    Console.Clear();
                    Console.WriteLine("The young mage seems to be almost like new.");
                    Console.WriteLine("She is jumping up and down in excitment that you saved her.");
                    Console.WriteLine("Maybe you should talk to her.");
                    Console.ReadLine();
                    Console.Clear();
                    Story11(names, menu, text, item, num);
                    break;

                case "t":

                    Console.Clear();
                    Console.WriteLine("“We are also not the Imperials favorite citizens, we just escaped");
                    Console.WriteLine("from the cells of Silverhaven. It might not be safe with us.” You explain.");
                    Console.WriteLine("“Where am I to go? Being a mage, the guards will be hunting me.”");
                    Console.WriteLine("“We have already done this much, It wouldn’t hurt to have a mage with us");
                    Console.WriteLine("going to where we are going.” Caldwell chimes in.");
				
                    Console.WriteLine("“Where….Where are you going?” Taneya asks.");
                    Console.WriteLine("“We are looking for the Caves of Bowden.” You tell her.");
                    Console.WriteLine("“Today is your lucky day, I know how to find them.” Taneya says cheerfully.");
                    Console.WriteLine("“Alright then, its settled, you can come with us.”");
                    Console.WriteLine("“I will be no trouble at all! It will be fun!” Taneya screams in excitement.");
                    Console.ReadLine();
                    item[1] = true;
			        Console.Clear();			
			        Console.SetCursorPosition(leftOffSet5, topOffSet5);
                    Console.ForegroundColor = ConsoleColor.Green; Console.Write("Chapter Three "); Console.ForegroundColor = ConsoleColor.White; Console.Write(" - "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("The Caves");Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    Console.Clear(); 
                    Ending myEnding = new Ending(names, menu, text, item, num);
                    break;

                case "n":
                    Console.Clear();
                    Console.WriteLine("You remain silent, trying to decide if you should let her come with you.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                    Story11(names, menu, text, item, num);
                    break;

                case "p":
                    Console.Clear();
                    Console.WriteLine(menu[1]);
                    Console.ReadLine();
                    Console.Clear();
                    Story11(names, menu, text, item, num);
                    break;

                case "u":
                    Console.Clear();
                    Console.WriteLine(menu[2]);
                    Console.ReadLine();
                    Console.Clear();
                    Story11(names, menu, text, item, num);
                    break;

                case "s":
                    Console.Clear();
                    Stats myStats = new Stats(names, menu, text, item, num);
                    Story11(names, menu, text, item, num);
                    break;

                default:
                    Console.Clear();
                    Story11(names, menu, text, item, num);
                    break;

            }

        }// good 2
        public void Story12(string[] names, string[] menu, string[] text, bool[] item, int[] num)//evil start
        {
            Console.WriteLine("You decide to travel to the town of the small village of Winterbrook.");
            Console.WriteLine("The journey is long, but you have heard a master thief taking refuge here.");
            Console.WriteLine("If anyone knows how to find the Caves of Bowden, it will be him.\n");
            Console.WriteLine("As you arrive you notice the town is oddly quiet for this time of day,");
            Console.WriteLine("and you do not see anyone in the streets.");
            Console.WriteLine("You decide to check out the local inn, maybe there is someone there with some");
            Console.WriteLine("answers, and hopefully can point you in the right direction to find this thief.");
            Console.WriteLine("You enter the inn, and just like the town, it seems deserted");
            Console.WriteLine("except you can hear the crackling of a fire. Someone must be inside.");

            Menu myMenu = new Menu(names, menu, text, item, num);
            names[2] = Console.ReadLine();

            switch (names[2])
            {
                case "a":
                    Console.Clear();
                    Console.WriteLine("The town seems abondoned. There is no one in sight.");
                    Console.WriteLine("The only clue of life is inside this broken down inn, a small");
                    Console.WriteLine("fire is light inside. You should see if anyone answers you.");
                    Console.ReadLine();
                    Console.Clear();
                    Story12(names, menu, text, item, num);
                    break;

                case "t":

                    Console.Clear();
                    Console.WriteLine("“Hello… is anyone here?” you ask.");
                    Console.WriteLine("Go away!” a strange voice returns.");
                    Console.WriteLine("“I am looking for someone, maybe you can point me in the right direction");
                    Console.WriteLine("and I’ll leave.” You reply.");
                    Console.ReadLine();
                    Console.Clear();
                    Story13(names, menu, text, item, num);
                    break;

                case "n":
                    Console.Clear();
                    Console.WriteLine("Being cautious you take your time entering the inn.");
                    Console.ReadLine();
                    Console.Clear();
                    Story12(names, menu, text, item, num);
                    break;

                case "p":
                    Console.Clear();
                    Console.WriteLine(menu[1]);
                    Console.ReadLine();
                    Console.Clear();
                    Story12(names, menu, text, item, num);
                    break;

                case "u":
                    Console.Clear();
                    Console.WriteLine(menu[2]);
                    Console.ReadLine();
                    Console.Clear();
                    Story12(names, menu, text, item, num);
                    break;

                case "s":
                    Console.Clear();
                    Stats myStats = new Stats(names, menu, text, item, num);
                    Story12(names, menu, text, item, num);
                    break;

                default:
                    Console.Clear();
                    Story12(names, menu, text, item, num);
                    break;

            }

        }
        public void Story13(string[] names, string[] menu, string[] text, bool[] item, int[] num)
        {
            int leftOffSet5 = (Console.WindowWidth / 2) - 12;
            int topOffSet5 = (Console.WindowHeight / 2) - 2;

            Console.WriteLine("You step farther into the inn, looking for the man who responded to your");
            Console.WriteLine("initial inquiry. You can see a shadow in the back room of someone by the fire.");
            Console.WriteLine("“I am looking for a skilled thief, I heard he may be in this town, his name");
            Console.WriteLine("Ark, do you know him” you inquire.");
            Console.WriteLine("“I might but answers are not free, what do you have?”");
            Console.WriteLine("“I don’t have much, but a few coins.”");
            Console.WriteLine("The odd man looking you over, you cannot help to feel a little uncomfortable.");
            Console.WriteLine("“This will do, why are you looking for this Ark?” the old man asks.");
            Console.WriteLine("“We are looking for the entrance to the Caves of Bowden. We heard he is the");
            Console.WriteLine("only one to return from there.”");
            Console.WriteLine("“Ah yes, the caves, those are much too dangerous, now go away!” the man snarls.");
            Console.WriteLine("“Hey!” Caldwell snaps, “We just gave you the rest of our coin, help us!”");
            Console.WriteLine("“This is pointless we should turn back now. Obviously this guy doesn't know.”");
            Console.WriteLine("“I lost a very special key in this tavern, if you can find it,");
            Console.WriteLine("I will take you to ark.”");


            Menu myMenu = new Menu(names, menu, text, item, num);
            names[2] = Console.ReadLine();

            switch (names[2])
            {
                case "a":
                    Console.Clear();
                    Console.WriteLine("You survey the inn, its in horrible condition, almost as if the people");
                    Console.WriteLine("of this town abandoned it long ago. cobwebs cover almost everything in sight.");
                    Console.WriteLine("As you search around the inn, you catch a glimmer in the corner of your eye.");
                    Console.WriteLine("You step closer to investigate, and notice lodged under the floorboards");
                    Console.WriteLine("is a small oddly shaped key. This must be the key the  man is looking for.");
                    Console.ReadLine();
                    Console.Clear();
                    Story13(names, menu, text, item, num);
                    break;

                case "t":
                    while (item[3] == false)
                    {
                    Console.Clear();
                    Console.WriteLine("“I am waiting.”");
                    Console.ReadLine();
                    Console.Clear();
                    Story13(names, menu, text, item, num);
                    break;
                    }
                    while (item[3] == true)
                    {
                    Console.Clear();
                    Console.WriteLine("“I found your key.” You tell the man.“A favor for a favor,now take us to Ark.”");
                    Console.WriteLine("“I already have.” the man remarks.");
                    Console.WriteLine("“You have taken us no where!” Caldwell shouts.\n\n");
                    Console.WriteLine("“Idiots, I am Ark. I stashed that key here long ago, it is a very special key");
                    Console.WriteLine("it unlocks a very special room in the Caves of Bowden.” He says.");
                    Console.WriteLine("“If you are truly looking for the caves, you will need my help to get there.”");
                    Console.WriteLine("Ark says with a slight smirk on his face.");
                    Console.ReadLine();
                    item[2] = true;
                    Console.Clear();
                    Console.SetCursorPosition(leftOffSet5, topOffSet5);
                    Console.ForegroundColor = ConsoleColor.Green; Console.Write("Chapter Three "); Console.ForegroundColor = ConsoleColor.White; Console.Write(" - "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("The Caves"); Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    Console.Clear(); 
                    Ending myEnding = new Ending(names, menu, text, item, num);
                    break;
                    }
                    break;
                case "n":
                    Console.Clear();
                    Console.WriteLine("You just look around the inn. The weird man huddling over the fire");
                    Console.WriteLine("is giving you a strange look, it makes you feel uncomfortable.");
                    Console.ReadLine();
                    Console.Clear();
                    Story13(names, menu, text, item, num);
                    break;

                case "p":
                    Console.Clear();
                    Console.WriteLine("You have picked up a key!");
                    Console.ReadLine();
                    item[3] = true;
                    Console.Clear();
                    Story13(names, menu, text, item, num);
                    break;

                case "u":
                    Console.Clear();
                    Console.WriteLine(menu[2]);
                    Console.ReadLine();
                    Console.Clear();
                    Story13(names, menu, text, item, num);
                    break;

                case "s":
                    Console.Clear();
                    Stats myStats = new Stats(names, menu, text, item, num);
                    Story13(names, menu, text, item, num);
                    break;

                default:
                    Console.Clear();
                    Story13(names, menu, text, item, num);
                    break;

            }

        }// evil 1
    }
    class Ending
    {
        public Ending(string[] names, string[] menu, string[] text, bool[] item, int[] num)//ending intro
        {
            Console.WriteLine("After a long journey you and your party finally make it to, what seems to be");
            Console.WriteLine("the entrance to the Caves of Bowden. The cliffside is massive");
            Console.WriteLine("the surrounding forest is overgrowing, almost as if it was swallowing");
            Console.WriteLine("the caves. A small crack in the cliffside, just big enough for a person");
            Console.WriteLine("to squeeze through seems to be the only way in.");

            Console.WriteLine("You make your way into the cave to reveal a huge chamber.");
            Console.WriteLine("By the looks of it no one has been inside since who ever built it. Before you");
            Console.WriteLine("see the chamber splits in three directions. The passage way on the left");
            Console.WriteLine("looks to be protected by a magical force. The door on the right is");
            Console.WriteLine("protected by a large iron door. The only way through it seems to be with a");
            Console.WriteLine("small oddly shaped key. The passage in front of you does not seem to be");
            Console.WriteLine("guarded you can enter this way freely.");

            Menu myMenu = new Menu(names, menu, text, item, num);
            names[2] = Console.ReadLine();

            switch (names[2])
            {
                case "a":
                    Console.Clear();
                    Console.WriteLine("There are three doors before you.");
                    Console.WriteLine("If you have a thief with you, you might be able to get through the iron door.");
                    Console.WriteLine("If you have a mage with you, they might be able to lower the magical barrier.");
                    Console.WriteLine("If you have no one, just take the center door, talk to Caldwell to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    new Ending(names, menu, text, item, num);
                    break;

                case "t":

                    Console.Clear();
                    Console.WriteLine("“Alright lets go.” You tell Caldwell.");
                    Console.ReadLine();
                    Console.Clear();
                    Trans(names, menu, text, item, num);
                    break;

                case "n":
                    Console.Clear();
                    Console.WriteLine("You remain still, pondering which path to take.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                    new Ending(names, menu, text, item, num);
                    break;

                case "p":
                    Console.Clear();
                    Console.WriteLine(menu[1]);
                    Console.ReadLine();
                    Console.Clear();
                    new Ending(names, menu, text, item, num);
                    break;

                case "u":
                    Console.Clear();
                    Console.WriteLine(menu[2]);
                    Console.ReadLine();
                    Console.Clear();
                    new Ending(names, menu, text, item, num);
                    break;

                case "s":
                    Console.Clear();
                    Stats myStats = new Stats(names, menu, text, item, num);
                    new Ending(names, menu, text, item, num);
                    break;

                default:
                    Console.Clear();
                    new Ending(names, menu, text, item, num);
                    break;

            }


        }
        public void Trans(string[] names, string[] menu, string[] text, bool[] item, int[] num)//choice
        {
            Console.Clear();
            Console.WriteLine("You have a choice to make...");
            Console.WriteLine("============================");
            Console.WriteLine("Go Left through the Magical Barrier.");
            Console.WriteLine("Go Right through the Iron Door.");
            Console.WriteLine("Go Forward through the unguarded path.");

            DMenu myDMenu = new DMenu(names, menu, text, item, num);
            names[2] = Console.ReadLine();

            switch (names[2])
            {
                case "f":
                    while (names[1] == "warrior")
                    {
                        Console.Clear();
                        Ending1(names, menu, text, item, num);
                        break;
                    }
                    while (names[1] == "mage")
                    {
                        Console.Clear();
                        Ending2(names, menu, text, item, num);
                        break;
                    }
                    while (names[1] == "thief")
                    {
                        Console.Clear();
                        Ending3(names, menu, text, item, num);
                        break;
                    }
                    break;

                case "b":

                    Console.Clear();
                    Trans(names, menu, text, item, num);
                    break;

                case "r":
                    while (item[2] == false)
                    {
                        Console.WriteLine("You are unable to pass the iron door.");
                        Trans(names, menu, text, item, num);
                        break;

                    }
                    while (item[2] == true)
                    {
                        Ending5(names, menu, text, item, num);
                        break;
                    }

                    break;
                case "l":
                    while (item[1] == false)
                    {
                        Console.Clear();
                        Console.WriteLine("You are unable to pass the magical barrier.");
                        Trans(names, menu, text, item, num);
                        break;
                    }
                    while (item[1] == true)
                    {
                        Ending4(names, menu, text, item, num);
                        break;
                    }
                    break;

                default:
                    Console.Clear();
                    Trans(names, menu, text, item, num);
                    break;
            }

        }
        public void Ending1(string[] names, string[] menu, string[] text, bool[] item, int[] num)//warrior
        {
                Console.WriteLine("As you make your way through the middle passage the torches along the walls");
                Console.WriteLine("magically light up as you pass them. After what seems like forever down");
                Console.WriteLine("a long, twisting, and narrow path, you find yourself in a large room.");
                Console.WriteLine("As the torches continue to light up, you can just barely make out");
                Console.WriteLine("the contents of the room.\n");
                Console.WriteLine("“What in the name of Allize..” Caldwell utters, “Is that what I think it is?”");
                Console.WriteLine("“If you think it’s a 30 foot, fire breathing, real life dragon, then yes.");
                Console.WriteLine("I think it’s exactly what you think it is.” You respond.");

                Menu myMenu = new Menu(names, menu, text, item, num);
                names[2] = Console.ReadLine();

                switch (names[2])
                {
                    case "a":
                        Console.Clear();
                        Console.WriteLine("A large monstrous dragon is blocking your path.");
                        Console.WriteLine("No one has seen one in hundreds of years and thought to be extinct.");
                        Console.WriteLine("Yet here one is, blocking the path to the treasure you have been");
                        Console.WriteLine("so eager to seek out.");
                        Console.WriteLine("Maybe you have a trick up or sleeve to use against it.");
                        Console.ReadLine();
                        Console.Clear();
                        Ending1(names, menu, text, item, num);
                        break;

                    case "t":

                        Console.Clear();
                        Console.WriteLine("“How do you suppose we get past that?” Caldwell asks.");
                        Console.ReadLine();
                        Console.Clear();
                        Ending1(names, menu, text, item, num);
                        break;

                    case "n":
                        Console.Clear();
                        Console.WriteLine("You have never seen a dragon before. The sight is impressive.");
                        Console.ReadLine();
                        Console.Clear();
                        Ending1(names, menu, text, item, num);
                        break;

                    case "p":
                        Console.Clear();
                        Console.WriteLine(menu[1]);
                        Console.ReadLine();
                        Console.Clear();
                        Ending1(names, menu, text, item, num);
                        break;

                    case "u":
                        Console.Clear();
				        Console.WriteLine("The only thing you have known is brute force and strength.");
                        Console.WriteLine("As a warrior you have always looked to pick a fight with an");
                        Console.WriteLine("an opponent bigger then you. They don’t come much bigger ");
                        Console.WriteLine("than a dragon. You will be remembered for all of eternity");
                        Console.WriteLine("if you manage to defeat him.\n");
                        Console.WriteLine("You charge the dragon, you can see his tail coming right for you. ");
                        Console.WriteLine("You leap onto its tail in what could only be described as pure luck, ");
                        Console.WriteLine("manage to grab ahold of it. As his tail is in the air you manage to leap ");
                        Console.WriteLine("onto his back and quickly run up his long neck to his head.");
                        Console.WriteLine("You begin to go into a berserk rage as you pummel the dragon. ");
                        Console.WriteLine("In what could only be possible in a normal man’s dreams, the beating seems");
                        Console.WriteLine("seems to have worked, the dragon’s face collapses onto the ground.\n");
                        Console.WriteLine("Another opponent is down, what could possibly challenge you next.");
                        Console.WriteLine("However that challenge is for another story. ");
                        Console.WriteLine("You have succeeded the treasure is yours.");
                        Console.ReadLine();
                        Console.Clear();
                        Ending6();
                        break;

                    case "s":
                        Console.Clear();
                        Stats myStats = new Stats(names, menu, text, item, num);
                        Ending1(names, menu, text, item, num);
                        break;

                    default:
                        Console.Clear();
                        Ending1(names, menu, text, item, num);
                        break;

                }
        }
        public void Ending2(string[] names, string[] menu, string[] text, bool[] item, int[] num)//mage
        {
                            Console.WriteLine("As you make your way through the middle passage the torches along the walls");
                Console.WriteLine("magically light up as you pass them. After what seems like forever down");
                Console.WriteLine("a long, twisting, and narrow path, you find yourself in a large room.");
                Console.WriteLine("As the torches continue to light up, you can just barely make out");
                Console.WriteLine("the contents of the room.\n");
                Console.WriteLine("“What in the name of Allize..” Caldwell utters, “Is that what I think it is?”");
                Console.WriteLine("“If you think it’s a 30 foot, fire breathing, real life dragon, then yes.");
                Console.WriteLine("I think it’s exactly what you think it is.” You respond.");

                Menu myMenu = new Menu(names, menu, text, item, num);
                names[2] = Console.ReadLine();

                switch (names[2])
                {
                    case "a":
                        Console.Clear();
                        Console.WriteLine("A large monstrous dragon is blocking your path.");
                        Console.WriteLine("No one has seen one in hundreds of years and thought to be extinct.");
                        Console.WriteLine("Yet here one is, blocking the path to the treasure you have been");
                        Console.WriteLine("so eager to seek out.");
                        Console.WriteLine("Maybe you have a trick up or sleeve to use against it.");
                        Console.ReadLine();
                        Console.Clear();
                        Ending1(names, menu, text, item, num);
                        break;

                    case "t":

                        Console.Clear();
                        Console.WriteLine("“How do you suppose we get past that?” Caldwell asks.");
                        Console.ReadLine();
                        Console.Clear();
                        Ending1(names, menu, text, item, num);
                        break;

                    case "n":
                        Console.Clear();
                        Console.WriteLine("You have never seen a dragon before. The sight is impressive.");
                        Console.ReadLine();
                        Console.Clear();
                        Ending1(names, menu, text, item, num);
                        break;

                    case "p":
                        Console.Clear();
                        Console.WriteLine(menu[1]);
                        Console.ReadLine();
                        Console.Clear();
                        Ending1(names, menu, text, item, num);
                        break;

                    case "u":
                        Console.Clear();
                        Console.WriteLine("A mage has many talents, yet nowhere in the handbook did you ever read about");
                        Console.WriteLine("taking down a dragon. This one will have to be improvised. You approach");
                        Console.WriteLine("the dragon, dodging his attacks as any mage should, by blinking around the");
                        Console.WriteLine("room.The quick movements of your teleporting are no match for the dragon.");
                        Console.WriteLine("He cannot keep up. As you get closer you begin to summon an ice spell.");
                        Console.WriteLine("You figure if you can’t beat it with fire maybe you can freeze him.");
                        Console.WriteLine("You conjure massive blocks of ice to rain down on the dragon, yet");
                        Console.WriteLine("he seems unfazed. Knowing you only have one shot at this you blink on");
                        Console.WriteLine("the back of the dragon, and grab ahold of him.\n");
                        Console.WriteLine("You can feel his body begin to freeze, as it take all your energy to pull");
                        Console.WriteLine("this off. You look up and see the dragon’s tail raise up to swat you.");
                        Console.WriteLine("Just before it slams into you it freezes into a large block of ice.");
                        Console.WriteLine("You have done it. The large monster in encased in a massive block of ice.");
                        Console.WriteLine("Half dead, with no energy left, you have succeeded, the treasure is yours.");
                        Console.ReadLine();
                        Console.Clear();
                        Ending6();
                        break;

                    case "s":
                        Console.Clear();
                        Stats myStats = new Stats(names, menu, text, item, num);
                        Ending1(names, menu, text, item, num);
                        break;

                    default:
                        Console.Clear();
                        Ending1(names, menu, text, item, num);
                        break;
                }

        }
        public void Ending3(string[] names, string[] menu, string[] text, bool[] item, int[] num)//theif
        {
                Console.WriteLine("As you make your way through the middle passage the torches along the walls");
                Console.WriteLine("magically light up as you pass them. After what seems like forever down");
                Console.WriteLine("a long, twisting, and narrow path, you find yourself in a large room.");
                Console.WriteLine("As the torches continue to light up, you can just barely make out");
                Console.WriteLine("the contents of the room.\n");
                Console.WriteLine("“What in the name of Allize..” Caldwell utters, “Is that what I think it is?”");
                Console.WriteLine("“If you think it’s a 30 foot, fire breathing, real life dragon, then yes.");
                Console.WriteLine("I think it’s exactly what you think it is.” You respond.");

                Menu myMenu = new Menu(names, menu, text, item, num);
                names[2] = Console.ReadLine();

                switch (names[2])
                {
                    case "a":
                        Console.Clear();
                        Console.WriteLine("A large monstrous dragon is blocking your path.");
                        Console.WriteLine("No one has seen one in hundreds of years and thought to be extinct.");
                        Console.WriteLine("Yet here one is, blocking the path to the treasure you have been");
                        Console.WriteLine("so eager to seek out.");
                        Console.WriteLine("Maybe you have a trick up or sleeve to use against it.");
                        Console.ReadLine();
                        Console.Clear();
                        Ending1(names, menu, text, item, num);
                        break;

                    case "t":

                        Console.Clear();
                        Console.WriteLine("“How do you suppose we get past that?” Caldwell asks.");
                        Console.ReadLine();
                        Console.Clear();
                        Ending1(names, menu, text, item, num);
                        break;

                    case "n":
                        Console.Clear();
                        Console.WriteLine("You have never seen a dragon before. The sight is impressive.");
                        Console.ReadLine();
                        Console.Clear();
                        Ending1(names, menu, text, item, num);
                        break;

                    case "p":
                        Console.Clear();
                        Console.WriteLine(menu[1]);
                        Console.ReadLine();
                        Console.Clear();
                        Ending1(names, menu, text, item, num);
                        break;

                    case "u":
                        Console.Clear();
	   		            Console.WriteLine("You are a very talented thief. For you have never met a challenge");
                        Console.WriteLine("you could not get past. A dragon is the biggest challenge");
                        Console.WriteLine("of them all. You will become a legend, or die trying.\n");
                        Console.WriteLine("Using your quick thinking, and natural ability to think fast. ");
                        Console.WriteLine("You can see that the cavern is supported by large beams. If you");
                        Console.WriteLine("are quick enough, and could get the dragon to destroy the pillars,");
                        Console.WriteLine("it will collapse the cave. If you can manage to slip ");
                        Console.WriteLine("to the other side before it crashes in on the dragon, you will be");
                        Console.WriteLine("able to claim your treasure.\n");
                        Console.WriteLine("You rush towards the dragon, dodging his attacks, as you run towards");
                        Console.WriteLine("the first pillar. You can see his tail flying towards you.");
                        Console.WriteLine("This is it you think to yourself. The tail slams into the first pillar,");
                        Console.WriteLine("as you slide underneath it. The ceiling begins to crumble from the blow");
                        Console.WriteLine("and a large boulder smashes onto the head of the dragon");
                        Console.WriteLine("trapping it underneath.\n");
                        Console.WriteLine("Only in a day’s work for a master thief. ");
                        Console.WriteLine("You have succeeded, the treasure is yours.");
                        Console.ReadLine();
                        Console.Clear();
                        Ending6();
                        break;

                    case "s":
                        Console.Clear();
                        Stats myStats = new Stats(names, menu, text, item, num);
                        Ending1(names, menu, text, item, num);
                        break;

                    default:
                        Console.Clear();
                        Ending1(names, menu, text, item, num);
                        break;
                }

        }
        public void Ending4(string[] names, string[] menu, string[] text, bool[] item, int[] num)//good
        {
            Console.Clear();
            Console.WriteLine("“I think I might be able to bring that barrier down”, Taneya says.");
            Console.WriteLine("She begins to chant, and her eyes start to glow a bright yellow.");
            Console.WriteLine("A forceful wind begins to engulf the caves. Holding on to whatever");
            Console.WriteLine("you can, trying to steady yourself.\n");
            Console.WriteLine("“It is done” she says as she drops down to her knees.");
            Console.WriteLine("The chant must have drained her of her energy, she can bareley stand.");
            Console.WriteLine("You see the barrier begin to fade and allow you to pass through it.");
            Console.WriteLine("As you enter the passage, torches light your way through the dark hall.");
            Console.WriteLine("You finally make it to a large chamber. The torches continue to light up.");
            Console.WriteLine("“It cannot be!”, Taneya exclaims, “This is the libary of Bowden.”");
            Console.WriteLine("“The what?” Caldwell ask.");
            Console.WriteLine("“The libary of Bowden, it was lost centuries ago.” she explains.");
            Console.WriteLine("“This libary is the key of all knowledge. With it we will be able");
            Console.WriteLine("to learn everything from our past, and to advance society by several");
            Console.WriteLine("years.” she continues on, as she looks around at the walls of books.");
            Console.WriteLine("“They say knowledge is power, I'd say we just found the greatest");
            Console.WriteLine("treasure we could ever hope to find.”");
            Console.ReadLine();
            Ending6();
        }
        public void Ending5(string[] names, string[] menu, string[] text, bool[] item, int[] num)//evil
        {
            Console.Clear();
            Console.WriteLine("“Where is it..” Ark says, as he frantically pats down his clothes.");
            Console.WriteLine("“Ah, here we go.” he says as he pulls out the weirdly shaped key.");
            Console.WriteLine("He sticks it into the lock of the Iron door, and turns it.");
            Console.WriteLine("The entire cave begins to shake, the rocks on the walls begin to crumble");
            Console.WriteLine("you manage to dodge them as a few come crashing down.\n");
            Console.WriteLine("The Iron door begins to open, revealing a dark path inside.");
            Console.WriteLine("“Quickly!” Ark demands, as he rushes inside.");
            Console.WriteLine("The halls remain dark, as you travel down the path. Finally you reach");
            Console.WriteLine("a large chamber, the only source of light is coming from a small");
            Console.WriteLine("pedistal in the center of the room.\n");
            Console.WriteLine("Ark quickly rushes to it, and removes what looks like a blood soaked");
            Console.WriteLine("dagger. “This is it, the dagger of Bowden.”");
            Console.WriteLine("“It cannot be!” Caldwell yells out. “It is said that whoever posses that");
            Console.WriteLine("dagger will become invinceable. It is only a legend, it cannot be real.\n”");
            Console.WriteLine("“Oh its real alright, and you brought me right to it.” Ark explains.");
            Console.WriteLine("“With this no one will be able to stop me!”");
            Console.WriteLine("Ark leaps from the platform, and rushes past you. He slips away into the");
            Console.WriteLine("shadows, and out of your sight.\n");
            Console.WriteLine("“What have we done...” Caldwell utters.");
            Console.ReadLine();
            Ending6();

        }
        public void Ending6()//exit
        {
            int leftOffSet5 = (Console.WindowWidth / 2) - 12;
            int topOffSet5 = (Console.WindowHeight / 2) - 2;

            Console.Clear();
            Console.SetCursorPosition(leftOffSet5, topOffSet5);
            Console.Write("Thank you for playing.");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }//endings
}
