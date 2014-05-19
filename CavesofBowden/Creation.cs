using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CavesofBowden;

namespace CavesofBowden
{
    public class Creation //char creation
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
}
