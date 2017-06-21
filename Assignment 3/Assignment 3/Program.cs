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

            /*Welcoming the player to game & letting them know what they
            can expect from Gardening Simulator 2017. Lines 36-40 are for 
            creating the name of the garden. Line 43 is for creating the 
            object for this program, it is an object oriented program after 
            all.
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

    
        }
    }
}
