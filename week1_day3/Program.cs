using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_day3
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 2;
            int secondNumber = 6;
            if (firstNumber > secondNumber) 
            {
                //if this is true do something
                Console.WriteLine("you have broken math. good job");
            }
            else
            {
                // do something else
                Console.WriteLine(" that makes sense");



               
            }

            Console.WriteLine(" what day is today");
            string userAnswer = Console.ReadLine();
            if (userAnswer == "Monday")
            {
                Console.WriteLine("Back to work");
               }

            else if (userAnswer == "Friday")
                {
                Console.WriteLine("happy friday");

            }

            Console.WriteLine("how old are you?");
            int userAage = int.Parse(Console.ReadLine());
            if (userAge <= 1)
            { 
                Console.WriteLine("yay toddlers!");
        }
        else if (userAge >= 4 &&  userAge < 4)
            Console.WriteLine(" Enjoy childhood");

    }



}
