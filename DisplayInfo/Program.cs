using System;

namespace DisplayInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get first and last name from user input
            Console.WriteLine("Enter your first and last name.");
            string name = Console.ReadLine();
            // Get their favorite number
            Console.WriteLine($"Thanks {name}, what is your favorite number?");
            string favnum = Console.ReadLine();
            // Get their favorite animal
            Console.WriteLine($"Also, what is your favorite animal?");
            string favanimal = Console.ReadLine();
            Console.WriteLine($"So {name}, your favorite number is {favnum} and your your favorite animal is {favanimal}");



            // Once you have gotten all their info and stored it,
            // display it back to them.

            // If their favorite number is greater than 10, display it in green.
            // If their favorite number is less than 5, display it in red.
        }
    }
}
