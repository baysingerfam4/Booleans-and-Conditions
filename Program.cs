using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Booleans_and_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Carla Baysinger
            // Booleans and Conditions
            // April 26th 2024

            Menu();
            Temperature();
            OddorEven();
            LeapYearChecker();

        }

        public static void Temperature()
        {
            //Prompt the user to enter a temperature.

            //Display a different message depending on the temperature.

            //If the temperature is below 32 - "That's freezing, be careful out there."
            //Between 33 and 50 - "It's really cold out, bring a jacket"
            //Between 51 and 68 - "It's starting to get cold. A sweater should work"
            //Between 69 and 75 - "It's comfortable out. A shirt and jeans will work"
            //Above 76 - "It's T-shirt and shorts time"
            //Make sure to use a try / catch around your code

            
            
                Console.WriteLine("Enter a temperature: "); 
                int temp = int.Parse(Console.ReadLine());
                           
            
                if (temp < 32)
                {

                    Console.WriteLine("That's freezing, be careful out there.");
                }
                else if (temp >= 33 && temp <= 50)
                {
                    Console.WriteLine("It's really cold out, bring a jacket");
                }
                else if (temp >= 51 && temp <= 68)
                {
                    Console.WriteLine("It's starting to get cold. A sweater should work");
                }
                else if (temp >= 69 && temp <= 75)
                {
                    Console.WriteLine("It's comfortable out. A shirt and jeans will work");
                }
                else
                {
                Console.WriteLine("It's T-shirt and shorts time");
                }
            
                
            }
          public static void OddorEven()
          {
            // Odd or Even: Write a C# program that takes an integer input from the user and determines whether the number is odd or even. The program should:
            //Prompt the user to enter an integer.
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0) //Determine whether the number is odd or even using a conditional statement.
            {
                Console.WriteLine("Number is even."); //Print the appropriate message ("The number is odd" or "The number is even").
            }

            else
            {
                Console.WriteLine("Number is odd.");
            }
           

          }

         public static void LeapYearChecker()
        {
            // Leap Year Checker: Write a C# program that checks whether a given year is a leap year or not. The program should:
            //Prompt the user to enter a year.
            Console.WriteLine("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            // Determine whether the year is a leap year using the following criteria:
            // A year is a leap year if it is divisible by 4, except for years that are divisible by 100.
            // However, years that are divisible by 400 are also leap years.
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} is a Leap Year!"); //Print a message indicating whether the year is a leap year or not.
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year");
            }


         }
        public static void Menu()
        {
            //Create a menu that allows the user to choose which one of these equations to run. This will run when you first start the program.
            Console.WriteLine("Which option would you like to run?"); //Ask user which option they would like
            Console.WriteLine("1 - Temperature");
            Console.WriteLine("2 - Odd or Even");
            Console.WriteLine("3 - Leap Year Checker");
            Console.WriteLine("4 - Exit");
            Console.WriteLine("Enter your choice (1-4): "); //After the chosen number it goes to that option
            string userInput = Console.ReadLine();

            //options to choose from in the menu:
            if (userInput == "1")
            {
                Temperature();
            }

            else if (userInput == "2")
            {
                OddorEven();
            }

            else if (userInput == "3")
            {
                LeapYearChecker();

            }
            else
            {
                Console.WriteLine("Exit");
            }
        }


    }

}

