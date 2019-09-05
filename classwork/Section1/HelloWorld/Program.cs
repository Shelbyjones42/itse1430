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
            //Movie data
            //string title;
            //int runLength;
            //int releaseYear;
            //string description;
            //bool haveSeen;

            while (true)
            {
                char input = DisplayMenu ();
                if (input == 'A')
                    AddMovie ();
                else if (input == 'D')
                    DisplayMovie ();
                else if (input == 'Q')
                    break;
            };
        }

        static void AddMovie ()
        {
            //Get title
            Console.Write ("Title: ");
            title = Console.ReadLine ();

            //Get description
            Console.Write ("Description: ");
            description = Console.ReadLine ();

            //Get release year
            releaseYear = ReadInt32 ("Release Year: ");

            //Get run length
            runLength = ReadInt32 ("Run Length (in minutes): ");

            //Get have seen
            haveSeen = ReadBoolean ("Have Seen? ");

        }

        static void DisplayMovie()
        {
            //Title, Description, Release Year, Run Length, HasSeen
            Console.WriteLine(title);
            Console.WriteLine(description);

            //Formatting strings
            //1) String concat
            Console.WriteLine("Released " + releaseYear);

            //2) Printf
            //Console.WriteLine("Run time; {0}", runLength);

            //3) String formatting
            var formattedString = String.Format ("Run time; {0}", runLength);
            Console.WriteLine (formattedString);

            //4) String interpolation
            Console.WriteLine($"Seen it? {haveSeen}" );
        }
        static bool ReadBoolean ( string message )
        {
            while (true)
            {
                Console.Write (message);

                string input = Console.ReadLine ();

                //Bool result = Boolean.Parse (input);
                //bool result;
                //if (Boolean.TryParse (input, out result))
                if (Boolean.TryParse(input, out bool result))
                    return result;

                Console.WriteLine ("Not a boolean");
            };
        }
        static int ReadInt32 (string message)
        {
            while (true)
            {
                Console.Write (message);

                var input = Console.ReadLine ();

                //int result = Int32.Parse (input);
                //int result;
                //if (Int32.TryParse (input, out result))
                if (Int32.TryParse(input, out var result))
                    return result;

                Console.WriteLine ("Not a number");
            };
        }

        static char DisplayMenu ()
        {
            do
            {
                Console.WriteLine("A)dd Movie");
                Console.WriteLine ("D)isplay Movie");
                Console.WriteLine("Q)uit");

                string input = Console.ReadLine();

                //Lower Case
                input = input.ToLower();
                // if (input == "A" || input == "a")
                //if (input == "a")
                if (String.Compare (input, "a", true) == 0)
                {
                    return 'A';
                } else if (input == "q")
                {
                    return 'Q';
                } else if (input == "d")
                    return 'D';
                else
                    Console.WriteLine("Invalid input");

            } while(true);
        }

        private static void DemoLanguage ()
        {
            string name = "";

            //string if = ""; 

            //Definitely assigned
            //name = "Bob";
            string name2;
            Console.ReadLine ();
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

            DemoArithmetic ();
            DemoRelational ();
            DemoLogical ();
            DemoConditional ();
        }

        static void DemoArithmetic ()
        {
            int hours = 8;
            double payRate = 15.25;

            double totalPay = hours * payRate;

            double taxes = totalPay * 0.33;

            //Combination operators work
            hours += 8;

            totalPay = hours * payRate;
            double newTaxes = totalPay * 0.66;
        }

        static void DemoRelational ()
        {
            int grade = 75;
            int passingGrade = 60;

            bool isGreater = grade > passingGrade;
            bool isGreaterThanOrEqual = grade >= passingGrade;
            bool isLessThan = grade < passingGrade;
            bool isLessThanOrEqual = grade <= passingGrade;
            bool isEqual = grade == passingGrade;
            bool isNotEqual = grade != passingGrade;
        }

        static void DemoLogical ()
        {
            bool value1 = true;
            bool value2 = false;

            //Both left and right must be true
            bool logicalAnd = value1 && value2;

            //Either left or right must be true
            bool logicalOr = value1 || value2;

            //Negates the value
            bool logicalNot = !value1;
        }

        static void DemoConditional ()
        {
            int grade = 75;

            // C ? T : F
            // Evaluate C, if true then T is the value of the expression
            //otherwise F is
            bool isPassing = grade > 60 ? true : false;

            //Equivalent to what an if statement could do if it were an expression
            if (grade > 60)
                isPassing = true;
            else
                isPassing = false;
        }

        static void DemoArray()
        {
            double[] payRates = new double[100];

            //50th element to 7.25
            payRates[49] = 7.25;

            //Read 89th element inoto temp variable
            double payRate = payRates[88];

            //Print out the 80th element
            Console.WriteLine(payRates[79]);

            //An empty aaray
            //bool[] isPassing = new bool[0];
            var isPassing = new bool[0];

            //Enumerating an array
            for (int index = 0; index < payRates.Length; ++index)
                Console.WriteLine(payRates[index]);

            //Type infrenencing
            //string name = "Bob William Smith Jr III";
            var name = "Bob William Smith Jr III";
            // name = 20;
            

            string[] nameParts = name.Split (' ');
        }

        //Don't do this oustside lab 1
        static string title;
        static string description;
        static int runLength;
        static int releaseYear;
        static bool haveSeen;
    }
}
