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

            // Call the GetGardenName function
            string sGardenName = GetGardenName();

            Plant myPlant = new Plant();

            // Calling functions to bet a number and amount of money.
            int iPlantSelect = iPlantSelection();

            // Calling functions to bet a number and amount of money.
            int iActionSelect = iActionSelection();

            while (true)
            {
                
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
        // Read the user plant selection and convert it to integer. If it's not valid then ask again.
        static int iPlantSelection()
        {
            int iPlantSelect = 0;
            bool isPlantSelectionValid = false;
            while (isPlantSelectionValid == false)
            {
                string[] sPlantSelections = new string[] {"0", "Apple", "Corn", "Dragon's Blood", "Rafflesia"};

                // Get the user selection.
                Console.WriteLine("\nWhich plant would you like to do stuff to?");
                Console.WriteLine("1.Apple 2.Corn 3.Dragon's Blood 4. Rafflesia");
                string sPlantSelection = Console.ReadLine();

                // Get the user selection and convert it to integer.
                if (int.TryParse(sPlantSelection, out iPlantSelect))
                {
                    // Check that the user selection is between 0 and 5.
                    if (iPlantSelect > 0 && iPlantSelect < 5)
                    {
                        // Return the user selection if it's between 0 and 5.
                        Console.WriteLine("\n>You selected \"{0}\"", sPlantSelections[iPlantSelect]);
                        isPlantSelectionValid = true;
                    }
                    else
                    {
                        Console.WriteLine("\n>Try a number from 1 to 4");
                    }
                }
                // If the user selection is not an integer.
                else
                {
                    Console.WriteLine("\n>Try a number from 1 to 4");
                }
            }
            return iPlantSelect;
        }
        // Get the user action and convert it to integer. If it's not valid then ask again.
        static int iActionSelection()
        {
            int iActionSelect = 0;
            bool isActionValid = false;
            while (isActionValid == false)
            {
                string[] sActions = new string[] { "0", "Water", "Grow", "Fertilize", "Harvest" };

                // Get the user action.
                Console.WriteLine("\nHere are the actions you can take. What would you like to do to?");
                Console.WriteLine("1. Water 2. Grow 3. Fertilize 4. Harvest");
                string sAction = Console.ReadLine();

                // Get the action and convert it to integer.
                if (int.TryParse(sAction, out iActionSelect))
                {
                    // Check that the action is between 0 and 5.
                    if (iActionSelect > 0 && iActionSelect < 5)
                    {
                        // Return the action if it's between 0 and 5.
                        Console.WriteLine("\n>You selected \"{0}\"", sActions[iActionSelect]);
                        isActionValid = true;
                    }
                    else
                    {
                        Console.WriteLine("\n>Try a number from 1 to 4");
                    }
                }
                // If the action is not an integer.
                else
                {
                    Console.WriteLine("\n>Try a number from 1 to 4");
                }
            }
            return iActionSelect;
        }
    }
}
