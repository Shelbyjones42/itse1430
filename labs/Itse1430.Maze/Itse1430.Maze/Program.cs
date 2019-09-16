/*ITSE 1430
 Lab 1
 Shelby Jones
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itse1430.Maze
{
    class Program
    {

        static void Main ( string[] args )
        {
            Room1 ();
            Console.ReadKey ();
        }

         static char Room1 ()
        {
            Console.WriteLine ("Congradulations you have been selected to explore the Rainbow Rooms.");
            Console.WriteLine ("This is the starting room. You must search each room in order to find which one is the exit");
            Console.WriteLine ("In order to move you will use W,A,S,D");

            do
            {
                Console.WriteLine ("W) Move forward");
                Console.WriteLine ("A) Move left");
                Console.WriteLine ("S) Move backward");
                Console.WriteLine ("D) Move right");
                Console.WriteLine ("E) Examine room");
                Console.WriteLine ("Q) Quite game");


                string input = Console.ReadLine ();

                input = input.ToLower ();
                if (String.Compare (input, "w", true) == 0)
                {
                    return 'W';
                } else if (input == "a")
                    return 'A';
                else if (input == "s")
                    return 'S';
                else if (input == "d")
                    return 'D';
                else if (input == "e")
                    return 'E';
                else if (input == "q")
                    return 'Q';
                else
                    Console.WriteLine ("Invalid Input");


            } while (true);
           
        }

        private static void Room2 ()
        {
            Console.WriteLine ($"Seen it? {haveSeen}");
            int numOfDoors = 2;
        }
        
        private static void Room3 ()
        {
            Console.WriteLine ($"Seen it? {haveSeen}");
            int numOfDoors = 3;
        }

        private static void Room4 ()
        {
            Console.WriteLine ($"Seen it? {haveSeen}");
            int numOfDoors = 2;
        }

        private static void Room5 ()
        {
            Console.WriteLine ($"Seen it? {haveSeen}");
            int numOfDoors = 3;
        }

        private static void Room6 ()
        {
            Console.WriteLine ($"Seen it? {haveSeen}");
            int numOfDoors = 4;
        }

        private static void Room7 ()
        {
            Console.WriteLine ($"Seen it? {haveSeen}");
            int numOfDoors = 3;
        }

        private static void Room8 ()
        {
            Console.WriteLine ($"Seen it? {haveSeen}");
            int numOfDoors = 2;
        }

        private static void Room9 ()
        {
            Console.WriteLine ($"Seen it? {haveSeen}");
            int numOfDoors = 3;
        }

        private static void Room10 ()
        {
            Console.WriteLine ($"Seen it? {haveSeen}");
            int numOfDoors = 2;
        }

        private static void Room11 ()
        {
            Console.WriteLine ($"Seen it? {haveSeen}");
            int numOfDoors = 1;
        }

    static string description;
    static string roomName;
    static int numOfDoors;
    static int direction;
    static bool haveSeen;

    }
}
