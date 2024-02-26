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
            Console.WriteLine("Write your tax Id");
            taxId = Console.ReadLine();
            Console.WriteLine("Write your employee Id");
            employeeId = long.Parse(Console.ReadLine());
            Console.Write($"Hello {name} {surname}!\r\n You are {age} old and your sex is {sex}.\r\n Your tax id is {taxId} " +
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

        }
    }
}
