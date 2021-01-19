/*  Alec Estrada -- Text Adventure Game  */
using System;

namespace TextAdventure
{
    class Program
    {
        public static Player currentPlayer = new Player();

        static void Main(string[] args)
        {
            Start();
        }



        static void Start()
        {
            Console.WriteLine("The fallen Dungeon!!");
            Console.WriteLine("Name: ");
            
            currentPlayer.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("A light shining bright, almost if the rays of the sun were upon you at birth.");
            Console.WriteLine("You awake to a group of people dressed in light colored robes and a circle that glows with every breath you take.");
            if (currentPlayer.name == "")
                Console.Write("I see you don't even remeber your own name, but still no name you will save this world.");
            else
                Console.WriteLine("Hello, " + currentPlayer.name + " we have summoned you to save this world.");

            Console.ReadKey();
        }


    }


}
