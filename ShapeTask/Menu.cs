namespace MainProgram.ShapeTask;

class Menu
{
    static decimal DecimalInput(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            if (decimal.TryParse(input, out decimal result))
            {
                return result;
            }
            Console.WriteLine("\nInvalid input. Please enter a number.");
        }
    }

    static Circle CircleInput()
    {
        decimal radius = DecimalInput("\nEnter radius: ");
        return new Circle(radius);
    }
    static Rectangle RectangleInput()
    {
        decimal length = DecimalInput("\nEnter length: ");
        decimal width = DecimalInput("\nEnter width: ");
        return new Rectangle(length, width);
    }

    static Triangle TriangleInput()
    {
        decimal _base = DecimalInput("\nEnter base: ");
        decimal height = DecimalInput("\nEnter height: ");
        decimal side = DecimalInput("\nEnter side: ");
        return new Triangle(_base, height, side);
    }

    public static void Run()
    {
        Circle? circle = null;
        Rectangle? rectangle = null;
        Triangle? triangle = null;

        while (true)
        {
            Console.WriteLine("\n1. Circle");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Triangle");
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
                    circle = CircleInput();

                    if (circle != null)
                    {
                        Console.WriteLine($"Area: {circle.CalculateArea()}");
                        Console.WriteLine($"Perimeter: {circle.CalculatePerimeter()}");
                    }
                }
                else if (userChoice == 2)
                {
                    rectangle = RectangleInput();

                    if (rectangle != null)
                    {
                        Console.WriteLine($"Area: {rectangle.CalculateArea()}");
                        Console.WriteLine($"Perimeter: {rectangle.CalculatePerimeter()}");
                    }
                }
                else if (userChoice == 3)
                {
                    triangle = TriangleInput();

                    if (triangle != null)
                    {
                        Console.WriteLine($"Area: {triangle.CalculateArea()}");
                        Console.WriteLine($"Perimeter: {triangle.CalculatePerimeter()}");
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid choice! Enter a number between 0-3!");
                }
            }
            else
            {
                Console.WriteLine("\nInvalid input! Enter a number!");
            }
        }
    }
}
