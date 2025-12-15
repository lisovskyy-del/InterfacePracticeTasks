namespace MainProgram.DrivableTask;

class Car : IDrivable
{
    public void StartEngine()
    {
        Console.WriteLine("\nCar's engine is started!");
    }

    public void StopEngine()
    {
        Console.WriteLine("\nCar's engine is stopped!");
    }
    public void Drive()
    {
        Console.WriteLine("\nCar is driving!");
    }
}
