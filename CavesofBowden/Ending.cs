using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CavesofBowden;

namespace CavesofBowden
{
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
