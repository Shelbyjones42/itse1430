/*ITSE 1430
 Lab 1
 Shelby Jones
 */
using System;

namespace HelloWorld
{
    class Program
    {

        static void Main ( string[] args )
        {
            string name = "";

            //string if = ""; 

            //Definitely assigned
            //name = "Bob";
            string name2; Console.ReadLine ();
            //name2 = Console.ReadLine ();

            name2 = name = "Sue";
            Console.WriteLine (name2);
            Console.WriteLine ("Hello World!");

            //Another block
            //Yet another block

            int hours = 8;
            double payRate = 15.25;

            double totalPay = payRate * hours;

            string fullName = "Fred" + " " + "Jones";
        }
    }
}
