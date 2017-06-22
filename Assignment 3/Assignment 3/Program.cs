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
            creating the name of the garden. Line 49 is for creating the 
            object for this program, it is an object oriented program after 
            all. Line 51 is the while loop. Within that loop we have 
            the actions the player can take and how they do that. 
            Lines 62-69 is the string and the TryParse check.  
            So the player can select a plant from their various plants 
            and then chose what to do with that specific plant a 
            switch with a switch inside of it is being used. 
            */

            Console.WriteLine("Gardening Simulator 2017");
            Console.WriteLine("Brought to you by Ali, Dayton, & Rajan");
            Console.ReadLine();

            Console.WriteLine("You have ${0} to start with", iMoney);
            Console.WriteLine("In Gardening Simulator 2017, you can buy plants, grow them, sell them, and more!");
            Console.ReadLine();

            string sGardenName = GetGardenName();

            Plant myPlant = new Plant();

            while (true)
            {

                Console.WriteLine("Which plant would you like to do stuff to");
                Console.WriteLine("1.Apple 2.Corn 3.Dragon's Blood 4. Rafflesia");
                Console.ReadLine();
                Console.WriteLine("Press 1, 2, 3, or 4");

                string sPlantSelect = Console.ReadLine();
                int iPlantSelect;
                while (!int.TryParse(sPlantSelect, out iPlantSelect))
                {
                    Console.WriteLine("Try a number from 1-4");
                    sPlantSelect = Console.ReadLine();
                }

                Console.WriteLine("Here are the actions you can take");
                Console.WriteLine("1. Water 2. Grow 3. Fertilize 4. Harvest");
                Console.ReadLine();

                Console.WriteLine("What would you like to do to");
                Console.WriteLine("Press 1, 2, 3, or 4");
                Console.ReadLine();

                string sActionSelect = Console.ReadLine();
                int iActionSelect;
                while (!int.TryParse(sActionSelect, out iActionSelect))
                {
                    Console.WriteLine("Try number, maybe 1, 2, 3, or 4");
                    sActionSelect = Console.ReadLine();
                }

                switch (iPlantSelect)
                {
                    case 1:
                        if (iPlantSelect == 1)
                        {
                            switch (iActionSelect)
                            {
                                case 1:
                                    if (iActionSelect == 1)
                                    {
                                        myPlant.Water();
                                    }
                                    break;
                                case 2:
                                    if (iActionSelect == 2)
                                    {
                                        myPlant.Grow();
                                    }
                                    break;
                                case 3:
                                    if (iActionSelect == 3)
                                    {
                                        myPlant.Fertilize();
                                    }
                                    break;
                                case 4:
                                    if (iActionSelect == 4)
                                    {
                                        myPlant.Harvest();
                                    }
                                    break;
                            }
                        }
                        break;
                    case 2:
                        if (iPlantSelect == 2)
                        {
                            switch (iActionSelect)
                            {
                                case 1:
                                    if (iActionSelect == 1)
                                    {
                                        myPlant.Water();
                                    }
                                    break;
                                case 2:
                                    if (iActionSelect == 2)
                                    {
                                        myPlant.Grow();
                                    }
                                    break;
                                case 3:
                                    if (iActionSelect == 3)
                                    {
                                        myPlant.Fertilize();
                                    }
                                    break;
                                case 4:
                                    if (iActionSelect == 4)
                                    {
                                        myPlant.Harvest();
                                    }
                                    break;
                            }
                        }
                        break;
                    case 3:
                        if (iPlantSelect == 3)
                        {
                            switch (iActionSelect)
                            {
                                case 1:
                                    if (iActionSelect == 1)
                                    {
                                        myPlant.Water();
                                    }
                                    break;
                                case 2:
                                    if (iActionSelect == 2)
                                    {
                                        myPlant.Grow();
                                    }
                                    break;
                                case 3:
                                    if (iActionSelect == 3)
                                    {
                                        myPlant.Fertilize();
                                    }
                                    break;
                                case 4:
                                    if (iActionSelect == 4)
                                    {
                                        myPlant.Harvest();
                                    }
                                    break;
                            }
                        }
                        break;
                    case 4:
                        if (iPlantSelect == 4)
                        {
                            switch (iActionSelect)
                            {
                                case 1:
                                    if (iActionSelect == 1)
                                    {
                                        myPlant.Water();
                                    }
                                    break;
                                case 2:
                                    if (iActionSelect == 2)
                                    {
                                        myPlant.Grow();
                                    }
                                    break;
                                case 3:
                                    if (iActionSelect == 3)
                                    {
                                        myPlant.Fertilize();
                                    }
                                    break;
                                case 4:
                                    if (iActionSelect == 4)
                                    {
                                        myPlant.Harvest();
                                    }
                                    break;
                            }
                        }
                        break;
                }
            }
        }
        // Get the Garden's name
        static string GetGardenName()
        {
            bool isGardenName = false;
            string sGardenName = "";
            int iGardenName = 0;
            while (isGardenName == false)
            {
                //Get the garden's name
                Console.Write("What would you like to name your garden?");
                sGardenName = Console.ReadLine();

                //If player input is null
                if (sGardenName == "")
                {
                    Console.WriteLine("\nPlease use valid charachters.");
                }

                //If player input is string
                else
                {
                    Console.WriteLine("WOW, {0}, what a great name!", sGardenName);
                    isGardenName = true;
                }

            }
            return sGardenName;
        }
    }
}
