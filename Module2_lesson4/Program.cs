using Microsoft.VisualBasic.FileIO;
using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Module2_lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo culture = CultureInfo.InvariantCulture;
            //EXERCISE 1 z obsluga wyjatkow
            string name;
            string surname;
            int age;
            char sex;
            string taxId;
            string employeeId;
            bool isValidInput = false;

            Console.WriteLine("Write your first name");
            name = Console.ReadLine();
            Console.WriteLine("Write your surname");
            surname = Console.ReadLine();
            Console.WriteLine("Write your age");

            while (!isValidInput)
            {
                if (int.TryParse(Console.ReadLine(), out age))
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid age as a number.");
                }
            }
            Console.WriteLine(" What is your sex, you can choose \"m\" for male or \"f\" for female");
             isValidInput = false;
            while (!isValidInput)
            {
                if (char.TryParse(Console.ReadLine(), out sex))
                {
                    if (sex == 'f' || sex =='m')
                    {
                        isValidInput = true;
                    }
                    else
                    {
                        isValidInput = false;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter only \"m\" or \"f\".");
                }
            }
            Console.WriteLine("Write your tax Id");
            taxId = Console.ReadLine();
            Console.WriteLine("Write your employee Id");
            employeeId = (Console.ReadLine());
            Console.ReadKey();

            //EXERCISE 2
            char a = 'a';
            char b = 'b';
            char c = 'c';
            Console.WriteLine($"reverse order {c} {b} {a}");
            Console.ReadKey();

            //EXERCISE 3  tu nie dawalam obslugi wyjatkow ale wiem, ze powinnam

            Console.WriteLine("Enter the width of the rectangle:");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the length of the rectangle:");
            double length = Convert.ToDouble(Console.ReadLine());

            double diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(length, 2));
            double roundedDiagonal = Math.Round(diagonal, 2);

            Console.WriteLine($"The length of the diagonal of the rectangle is: {roundedDiagonal}");
            Console.ReadKey();

            //EXERCISE 4
            int num = 10;
            string str = "Szkola Dotneta";
            double num2 = 12.5;

            //EXERCISE 5
            Console.WriteLine("What is your name?");
            string name1 = Console.ReadLine();

            Console.WriteLine("Write the first letter of your surname ");
            char firstChar = '\0';
            isValidInput = false;
            while (!isValidInput)
            {
                if (char.TryParse(Console.ReadLine(), out firstChar))
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter only one character.");
                }
            }
            Console.WriteLine("Write your phone number with international prefix e.g: 0012345678");
            isValidInput = false;
            long phone = 0;
            while (!isValidInput)
            {
                if (long.TryParse(Console.ReadLine(), out phone))
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter only numbers.");
                }
            }
            Console.WriteLine("What is your weight?");
            isValidInput = false;
            double weight = 0.0;
            while (!isValidInput)
            {
                if (double.TryParse(Console.ReadLine(), culture, out weight))
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid weight as a number.");
                }
            }
            Console.WriteLine("Do you like pizza? (You can answer true or false)");
            isValidInput = false;
            bool pizza = false;
            while (!isValidInput)
            {
                if (bool.TryParse(Console.ReadLine(), out pizza))
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter only \"true\" or \"false\".");
                }
            }
            string str2;
            if (pizza)
            {
                str2 = "like pizza, me too ;-)!";
            }
            else
            {
                str2 = "don't like pizza. What a pity!";
            }

            Console.WriteLine($"Hello {name1} {firstChar}. Your phone number is {phone} and your weight is {weight}. \r\n You {str2}");
            Console.ReadKey();
        }
    }
}


