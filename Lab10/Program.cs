using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            int i = 0;
            while (repeat)
            {
                Circle circle1 = new Circle();
                //Console.WriteLine("Input radius");
                circle1.Radius = Validator("Input Radius"); //radius from user input



                double circumference = circle1.CalculateCircumference();
                double area = circle1.CalculateArea();
                string formattedCir = circle1.CalculateFormattedCircumference();
                /*         Console.WriteLine(circumference + "  " + area);*/ //unformatted
                Console.WriteLine("Your circumference is: " + formattedCir); //formatted circumference
                string formattedArea = circle1.CalculateFormattedArea();
                Console.WriteLine("Your area is: " + formattedArea);//formatted area
                i++; // counts amount of times you looped/amount of circles created
                repeat = Confirm("Do you wish to continue?(y/n)");
            }
            Console.WriteLine($"Goodbye! You've created {i} circle(s)");
        }
        public static double Validator(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            while (!Regex.IsMatch(input, "^[0-9.]+$"))
            {
                Console.WriteLine("Invalid input. " + prompt);
                input = Console.ReadLine();
            }
            double num = double.Parse(input);
            return num;
        }
        public static bool Confirm(string message) //method for yes or no questions
        {
            Console.Write(message);
            string input = Console.ReadLine();

            if (input.ToLower() == "y") //continues program
            {
                return true;
            }
            else if (input.ToLower() == "n") //closes program
            {
                return false;
            }
            else //invalid input
            {
                Console.WriteLine("Invalid input.");
                return Confirm(message);
            }
        }
    }
}
