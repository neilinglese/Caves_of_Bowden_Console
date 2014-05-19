using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.Threading;
using CavesofBowden;

namespace CavesofBowden
{
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
                    Console.WriteLine("“Your " + names[0] + " right? I heard them mention it as they dragged you down here.”");
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
                    Console.ForegroundColor = ConsoleColor.Green; Console.Write("Chapter Two "); Console.ForegroundColor = ConsoleColor.White; Console.Write(" - "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("Old Friends"); Console.ForegroundColor = ConsoleColor.White;
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
                    Console.ForegroundColor = ConsoleColor.Green; Console.Write("Chapter Two "); Console.ForegroundColor = ConsoleColor.White; Console.Write(" - "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("Is anyone home?"); Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    Console.Clear();
                    Story12(names, menu, text, item, num);
                    break;

                case "l":
                    Console.Clear();
                    Console.SetCursorPosition(leftOffSet5, topOffSet5);
                    Console.ForegroundColor = ConsoleColor.Green; Console.Write("Chapter Two "); Console.ForegroundColor = ConsoleColor.White; Console.Write(" - "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("Lending a hand"); Console.ForegroundColor = ConsoleColor.White;
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
            Console.WriteLine("Do you know what this is ”" + names[0] + "as he ");
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
                    Console.ForegroundColor = ConsoleColor.Green; Console.Write("Chapter Three "); Console.ForegroundColor = ConsoleColor.White; Console.Write(" - "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("The Caves"); Console.ForegroundColor = ConsoleColor.White;
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
                    Console.ForegroundColor = ConsoleColor.Green; Console.Write("Chapter Three "); Console.ForegroundColor = ConsoleColor.White; Console.Write(" - "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("The Caves"); Console.ForegroundColor = ConsoleColor.White;
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
}
