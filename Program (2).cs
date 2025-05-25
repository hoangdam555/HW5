using System;

class UnitConverter
{
    public static double FeetToInches(double feet)
    {
        return feet * 12;
    }

   
    public static double YardsToInches(double yards)
    {
        return yards * 36;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Unit Conversion Program");

        while (true)
        {
            Console.WriteLine("\nChoose a conversion option:");
            Console.WriteLine("1. Feet to Inches");
            Console.WriteLine("2. Yards to Inches");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            if (choice == "3")
            {
                Console.WriteLine("Exiting the program. Goodbye!");
                break;
            }

            Console.Write("Enter the value to convert: ");
            if (double.TryParse(Console.ReadLine(), out double value))
            {
                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"{value} feet = {FeetToInches(value)} inches");
                        break;
                    case "2":
                        Console.WriteLine($"{value} yards = {YardsToInches(value)} inches");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose 1, 2, or 3.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        }
    }
}
