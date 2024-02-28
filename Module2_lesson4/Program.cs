using Microsoft.VisualBasic.FileIO;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Module2_lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXERCISE 1
            string name;
            string surname;
            int age;
            char sex;
            string description;
            string taxId;
            long employeeId;

            Console.WriteLine("Write your first name");
            name = Console.ReadLine();
            Console.WriteLine("Write your surname");
            surname = Console.ReadLine();
            Console.WriteLine("Write your age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine(" What is your sex, you can choose \"m\" for male or \"f\" for female");
            sex = char.Parse(Console.ReadLine());
            if (sex =='f') 
            {
                description = "female";
                    }
            else
            {
                description = "male";
;            }
            Console.WriteLine("Write your tax Id");
            taxId = Console.ReadLine();
            Console.WriteLine("Write your employee Id");
            employeeId = long.Parse(Console.ReadLine());
            Console.Write($"Hello {name} {surname}!\r\n You are {age} old and your sex is {description}.\r\n Your tax id is {taxId} " +
                $"and your employee Id is {employeeId}. Press any key to exit");
            Console.ReadKey();

            //EXERCISE 2
            char a = 'a';
            char b = 'b';
            char c = 'c';
            Console.WriteLine( $"reverse order {c} {b} {a}");
            Console.ReadKey();

            //EXERCISE 3

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
            char firstChar = char.Parse(Console.ReadLine());
            Console.WriteLine("Write your phone number with international prefix e.g: 0012345678");
            long phone = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("What is your weight?");
            CultureInfo culture = CultureInfo.InvariantCulture;
            double weight = double.Parse(Console.ReadLine(), culture);
            Console.WriteLine("Do you like pizza? (You can answer true or false)");
            string str2;
            bool pizza = bool.Parse(Console.ReadLine());
            if (pizza)
            {
                str2 = "like";
            }
            else
            {
                str2 = "don't like";
            }
            Console.WriteLine($"Hello {name1} {firstChar}. Your phone number is {phone} and your weight is {weight}. \r\n You {str2} pizza");
            Console.ReadKey(); 

        }
    }
}
