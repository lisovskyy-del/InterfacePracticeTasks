namespace MainProgram.ShapeTask;

class Triangle
{
    private decimal _base;
    private decimal _height;
    private decimal _side;

    public decimal Base
    {
        get => _base;
        set
        {
            if (value < 0)
            {
                throw new Exception("Value cannot be less than 0!");
            }

            _base = value;
        }
    }

    public decimal Height
    {
        get => _height;
        set
        {
            if (value < 0)
            {
                throw new Exception("Value cannot be less than 0!");
            }

            _height = value;
        }
    }
    public decimal Side
    {
        get => _side;
        set
        {
            if (value < 0)
            {
                throw new Exception("Value cannot be less than 0!");
            }

            _side = value;
        }
    }

    public Triangle(decimal _base, decimal height, decimal side)
    {
        this.Base = _base;
        this.Height = height;
        this.Side = side;
    }

    public decimal CalculateArea()
    {
        return (Base * Height) / 2;
    }

    public decimal CalculatePerimeter()
    {
        return Base + Height + Side;
    }
}
