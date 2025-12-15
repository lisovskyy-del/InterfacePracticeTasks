namespace MainProgram.ShapeTask;

class Circle : IShape
{
    private decimal _radius;

    public decimal Radius
    {
        get => _radius;
        set
        {
            if (value < 0)
                throw new Exception("Radius cannot be less than 0");

            _radius = value;
        }
    }

    public Circle(decimal radius)
    {
        this.Radius = radius;
    }

    public decimal CalculateArea()
    {
        return 3.14m * Radius * Radius;
    }

    public decimal CalculatePerimeter()
    {
        return 2m * 3.14m * Radius;
    }
}
