namespace MainProgram.DrivableTask;

class Menu
{
    public static void Run()
    {
        while (true)
        {
            Console.WriteLine("\n1. Start the car");
            Console.WriteLine("2. Start the bike");
            Console.WriteLine("0. Exit");
            Console.Write("Your choice: ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int userChoice))
            {
                if (userChoice == 0)
                {
                    Console.WriteLine("\nExitting..");
                    break;
                }
                else if (userChoice == 1)
                {
                    Car car = new();
                    car.StartEngine();
                    car.Drive();
                    car.StopEngine();
                }
                else if (userChoice == 2)
                {
                    Bike bike = new();
                    bike.StartEngine();
                    bike.Drive();
                    bike.StopEngine();
                }
                else
                {
                    Console.WriteLine("\nInvalid choice! Enter a number between 0-2!");
                }
            }
            else
            {
                Console.WriteLine("\nInvalid input! Enter a number!");
            }
        }
    }
}
