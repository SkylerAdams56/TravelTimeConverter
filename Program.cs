namespace Travel_Time_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Travel Time Calculator");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Enter miles: ");
            double miles = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter miles per hour: ");
            double mph = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Estimated travel time: ");
            double border = 3;
            Console.WriteLine(miles / mph + border);
            Console.WriteLine("hours");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Continue? (y/n): ");
            string choice = Console.ReadLine();
            if (choice == "y")
            {
                Main(args);
            }
            else
            {
                Console.WriteLine("Goodbye!");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}