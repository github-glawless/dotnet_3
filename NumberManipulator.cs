using System;

namespace dotnet_3
{
    class NumberManipulator
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
            Console.WriteLine("Give me a number dude and I'll make this program square it, add 14 to it, subtract 3 and print the result.  Give it a whirl..(I need an integer):");
            string line = Console.ReadLine(); // Read string from console
            int value;
            if (int.TryParse(line, out value)) // Try to parse the string as an integer
            {
                int squared = value * value ; 
                int squared14 = squared + 14 ; 
                int squared143 = squared14 - 3 ;
                Console.Write("The value you entered is ")  ;
                Console.Write(value);
                Console.WriteLine("The value squared is ") ;
                Console.Write(squared);
                Console.WriteLine("The value squared + 14 is ") ;
                Console.Write(squared14);
                Console.WriteLine("The value squared + 14 - 3 is ") ;
                Console.Write(squared143);
                Console.WriteLine("You rock!!");
            }
            else
            {
            Console.WriteLine("Not an integer dirtbag!");
            }
        }
    }
}
