using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller_ProjectOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //part one of my program will ask a user a series of questions

            Console.WriteLine("Hello, Welcome to Fortune Teller. Please enter your first name to get started.");
            string firstName = Console.ReadLine();

            Console.WriteLine("Thanks " + firstName + "! Now please enter your last name.");
            string lastName = Console.ReadLine();
            //just got users first and last name enter 

            Console.WriteLine("Okay " + firstName + " " + lastName + ". Now please enter your age.");
            int usersAge = int.Parse(Console.ReadLine());
            //users age inputed

            Console.WriteLine(firstName + ", what number month were you born? For example: enter 12 for December.");
            int birthMonth = int.Parse(Console.ReadLine());
            //users birth month as an integer

            Console.WriteLine("Okay " + firstName + " " + lastName + ". You are " + usersAge + " and were born in month number " + birthMonth 
                + ". \nNow, please enter your favorite ROYGBIV color.\nIf you do not know what ROYGBIV is, then enter \"Help.\"");

            string favoriteColor = Console.ReadLine();

            if (favoriteColor == "Help")
            {
                    Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet is what ROYGBIV stands for.\nNow enter which color is your favorite.");
                    favoriteColor = Console.ReadLine();
                    Console.WriteLine(favoriteColor + " is your favorite color.");
            }
            else
            {
                Console.WriteLine("You have enter: " + favoriteColor + " as your favorite color");
            }
            //if else statement used to determine users favorite ROYGBIV color

            Console.WriteLine("Finally, please enter the number of siblings you have.");
            int number_of_siblings = int.Parse(Console.ReadLine());
            Console.WriteLine("You have entered: " + number_of_siblings + " as the number of siblings you have.");
            //user enters the number of siblings they have. Part One complete

            //variables to remember: firstName, lastName, usersAge, birthMonth, favoriteColor, number_of_siblings

            int retireYears = 0;
            if (usersAge % 2 == 0) 
            {
                retireYears = 50; //even number
            }
            else
            {
                retireYears = 100;
            }

                //Part Three 
                Console.WriteLine(firstName + " " + lastName + " will retire in " + retireYears);
        }
    }
}
