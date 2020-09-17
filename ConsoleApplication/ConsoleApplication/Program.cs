using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, location;
            // Prompt for username
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();

            // Prompt for Locatrion
            Console.WriteLine("Where are you from");
            location = Console.ReadLine();

            //Date without time
            string date = DateTime.UtcNow.ToString("MM-dd-yyy");

            Console.WriteLine($"My name is  {name}, I am from {location}");

            Console.WriteLine(date);

            GlazerApp();
            DaysLeft();
        }

        private static void GlazerApp()
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            // Prompt for width
            Console.WriteLine("Please enter the Width");
            widthString = Console.ReadLine();

            // Please enter Height 
            Console.WriteLine("Please enter Height");
            heightString = Console.ReadLine();

            // Conventions 
            width = double.Parse(widthString);
            height = double.Parse(heightString);

            // The Math
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            //Return Values
            Console.WriteLine($"The length of the wood is {woodLength} feet");
            Console.WriteLine($"The area of the glass is {glassArea} square metres");

            //Prompt for Exit
            Console.WriteLine("Press any Key to exit ");
            Console.ReadLine();
        }

        private static void DaysLeft()
        {
            // Number of days left to Christmas
            DateTime today = DateTime.Now;
            int daysleft = new DateTime(today.Year, 12, 31).DayOfYear - today.DayOfYear;
            Console.WriteLine($"There are {daysleft} days left to Christmas Yayyy!!!");
        }

    }
}

