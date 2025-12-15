using System.Runtime.InteropServices;

namespace MainProgram.ArrayTask;

class Menu
{
    static string StringInput(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            if (input != null)
            {
                return input;
            }
            Console.WriteLine("\nInvalid input. Please enter a string.");
        }
    }

    static int IntInput(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int result))
            {
                return result;
            }
            Console.WriteLine("\nInvalid input. Please enter a number.");
        }
    }

    static Array ArrayInput()
    {
        int capacity = IntInput("\nEnter capacity for array: ");
        return new Array(capacity);
    }

    public static void Run()
    {
        Array? array = null;

        while (true)
        {
            Console.WriteLine("\n1. Create an array");
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
                    array = ArrayInput();

                    if (array != null)
                    {
                        while (true)
                        {
                            Console.WriteLine("\n1. Add elements into array");
                            Console.WriteLine("2. Proceed further");
                            Console.WriteLine("0. Exit");
                            Console.Write("Your choice: ");
                            string? choice = Console.ReadLine();

                            if (int.TryParse(choice, out int elementChoice))
                            {
                                if (elementChoice == 0)
                                {
                                    Console.WriteLine("\nExitting...");
                                    break;
                                }
                                else if (elementChoice == 1)
                                {
                                    int number = IntInput("\nEnter a number: ");
                                    array.Add(number);
                                }
                                else if (elementChoice == 2)
                                {
                                    while (true)
                                    {
                                        Console.WriteLine("\n1. Show all elements");
                                        Console.WriteLine("2. Show all elements with info");
                                        Console.WriteLine("3. Find maximum");
                                        Console.WriteLine("4. Find minimum");
                                        Console.WriteLine("5. Calculate average");
                                        Console.WriteLine("6. Find by user value");
                                        Console.WriteLine("7. Sort by ascending");
                                        Console.WriteLine("8. Sort by descending");
                                        Console.WriteLine("9. Sort by user parameter");
                                        Console.WriteLine("0. Exit");
                                        Console.Write("Your choice: ");
                                        string? arrayInput = Console.ReadLine();

                                        if (int.TryParse(arrayInput, out int arrayChoice))
                                        {
                                            if (arrayChoice == 0)
                                            {
                                                Console.WriteLine("\nExitting...");
                                                break;
                                            }
                                            else if (arrayChoice == 1)
                                            {
                                                array.Show();
                                            }
                                            else if (arrayChoice == 2)
                                            {
                                                string info = StringInput("\nEnter a string: ");
                                                array.Show(info);
                                            }
                                            else if (arrayChoice == 3)
                                            {
                                                Console.WriteLine($"\nMaximum: {array.Max()}");
                                            }
                                            else if (arrayChoice == 4)
                                            {
                                                Console.WriteLine($"\nMinimum: {array.Min()}");
                                            }
                                            else if (arrayChoice == 5)
                                            {
                                                Console.WriteLine($"\nAverage: {array.Avg()}");
                                            }
                                            else if (arrayChoice == 6)
                                            {
                                                int userValue = IntInput("\nEnter a value: ");

                                                if (array.Search(userValue))
                                                {
                                                    Console.WriteLine("\nValue was found!");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("\nValue was not found.");
                                                }
                                            }
                                            else if (arrayChoice == 7)
                                            {
                                                Console.WriteLine("\nSorted array by ascending:\n");
                                                array.SortAsc();
                                            }
                                            else if (arrayChoice == 8)
                                            {
                                                Console.WriteLine("\nSorted array by descending:\n");
                                                array.SortDesc();
                                            }
                                            else if (arrayChoice == 9)
                                            {
                                                bool isAsc;

                                                Console.WriteLine("\n1. Sort array by ascending");
                                                Console.WriteLine("2. Sort array by descending");
                                                Console.WriteLine("0. Exit");
                                                Console.Write("Your choice: ");
                                                string? sortInput = Console.ReadLine();

                                                if (int.TryParse(sortInput, out int sortChoice))
                                                {
                                                    if (sortChoice == 0)
                                                    {
                                                        Console.WriteLine("\nExitting...");
                                                        break;
                                                    }
                                                    else if (sortChoice == 1)
                                                    {
                                                        isAsc = true;
                                                        array.SortByParam(isAsc);
                                                    }
                                                    else if (sortChoice == 2)
                                                    {
                                                        isAsc = false;
                                                        array.SortByParam(isAsc);
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
                else
                {
                    Console.WriteLine("\nInvalid choice! Enter a number between 0-1!");
                }
            }
            else
            {
                Console.WriteLine("\nInvalid input! Enter a number!");
            }
        }
    }
}