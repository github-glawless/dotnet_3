using System;

namespace dotnet_3
{
    class NumberManipulator
    {
        static void Main(string[] args)
        {

            //Create a new console application called NumberManipulator.
            //Assign Console.ReadLine() to a variable to get a number from
            // the command line when the program is run, and then square, 
            //add 14, subtract 3 and print the result of the 
            //cumulative effect of this with Console.WriteLine().
            //
            //Once your application compiles add it to a public 
            //GitHub repository and paste the link below.

            Console.WriteLine("Give me an integer:");
            string line = Console.ReadLine(); // Read string from console
            int value;
            if (int.TryParse(line, out value)) // Try to parse the string as an integer
            {
                int squared = value * value ; 
                int squared14 = squared + 14 ; 
                int squared143 = squared14 - 3 ;
                Console.Write($"The value you entered is {value}. Sqauring it, adding 14 and subtracting 3 gives {(value * value) +14 -3}.  ");
                Console.WriteLine("You rock dude!!");
            }
            else
            {
            Console.WriteLine("Not an integer dirtbag!");
            }
        }
    }
}
