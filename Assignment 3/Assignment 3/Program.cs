using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* This program is a farming simulator. It was made for GD47's Programming 1
    Assignment 3. It should take in several forms of input from the player, 
    things like: what to plant, what to water, what to feed, what to harvest.
    Not 100% sure what the interface will look like, but we'll try stuff out.
    It was made by Ali, Dayton Ruhl, & Rajan.
 */

namespace Assignment_3
{
    class Program
    {
        static public int iMoney;

        static void Main(string[] args)
        {
            iMoney = 100;

            /*Welcoming the player to the game & letting them know what they
            can expect from Gardening Simulator 2017. Lines 36-40 are for 
            creating the name of the garden. Line 43 is for creating the 
            object for this program, it is an object oriented program after 
            all. Lines 51 is the while loop. Within that loop we have 
            the actions the player can take and how they do that. Lines 57-66
            is the string and the TryParse check that. Lines 68-94 are the cases 
            contained within the switch. When the player selects one of the actions
            the function is called and and its effects take place.
            */

            Console.WriteLine("Gardening Simulator 2017");
            Console.WriteLine("Brought to you by Ali, Dayton, & Rajan");
            Console.ReadLine();

            Console.WriteLine("You have {0} to start with", iMoney);
            Console.WriteLine("In Gardening Simulator 2017, you can buy plants, grow them, sell them, and more!");
            Console.ReadLine();

            Console.WriteLine("What would you like to name your garden?");
            string sGardenName = Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("WOW, {0}, what a great name!", sGardenName);
            Console.ReadLine();

            Plant myPlant = new Plant();

           while (true)
            {
                Console.WriteLine("Here are the actions you can take");
                Console.WriteLine("1. Water 2. Grow 3. Fertilize 4. Harvest");
                Console.ReadLine();

                Console.WriteLine("What would you like to in {0} today", sGardenName);
                Console.WriteLine("Press 1, 2, 3, or 4");
                Console.ReadLine();

                string sActionSelect = Console.ReadLine();
                int iActionSelect;
                bool bActionSelectResult = int.TryParse(sActionSelect, out iActionSelect);
                if (bActionSelectResult == false)
                {
                    Console.WriteLine("Try number, maybe 1, 2, 3, or 4");
                    sActionSelect = Console.ReadLine();
                }

                switch (iActionSelect)
                    {
                    case 1:
                        if (iActionSelect == 1)
                        {
                        myPlant.Water();
                        }
                        break;
                    case 2: 
                        if (iActionSelect==2)
                        {
                            myPlant.Grow();
                        }
                        break;
                    case 3:
                        if (iActionSelect==3)
                        {
                            myPlant.Fertilize();
                        }
                        break;
                    case 4:
                        if (iActionSelect==4)
                        {
                            myPlant.Harvest();
                        }
                        break;
                    }
            }
    
        }
    }
}
