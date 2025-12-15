namespace MainProgram.ShapeTask;

class Rectangle
{
    private decimal _length;
    private decimal _width;

    public decimal Length
    {
        get => _length;
        set
        {
            if (value < 0)
            {
                throw new Exception("Value cannot be less than 0!");
            }

            _length = value;
        }
    }

    public decimal Width
    {
        get => _length;
        set
        {
            if (value < 0)
            {
                throw new Exception("Value cannot be less than 0!");
            }

            _length = value;
        }
    }

    public Rectangle(decimal length, decimal width)
    {
        this.Length = length;
        this._width = width;
    }

    public decimal CalculateArea()
    {
        return Length * Width;
    }

    public decimal CalculatePerimeter()
    {
        return 2 * (Length + Width);
    }
}
