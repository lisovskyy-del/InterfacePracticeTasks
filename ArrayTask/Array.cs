namespace MainProgram.ArrayTask;

class Array : IOutput, IMath, ISort
{
    public int[] Data { get; private set; }
    public int Count { get; private set; }

    public Array(int capacity)
    {
        this.Data = new int[capacity];
        this.Count = 0;
    }

    public void Add(int value)
    {
        if (Count == Data.Length)
        {
            Resize(Data.Length * 2);
        }

        Data[Count] = value;
        Count++;
    }

    private void Resize(int newSize)
    {
        int[] temp = new int[newSize];
        for (int i = 0; i < Count; i++)
        {
            temp[i] = Data[i];
        }
        Data = temp;
    }
    public void Show()
    {
        for (int i = 0; i < Data.Length; i++)
        {
            Console.WriteLine(Data[i]);
        }
    }

    public void Show(string info)
    {
        for (int i = 0; i < Data.Length; i++)
        {
            Console.WriteLine($"{Data[i]} {info}");
         }
    }

    public int Max()
    {
        int max = Data[0];

        for (int i = 0; i < Data.Length; i++)
        {
            if (max < Data[i])
            {
                max = Data[i];
            }
        }

        return max;
    }

    public int Min()
    {
        int min = Data[0];

        for (int i = 0; i < Data.Length; i++)
        {
            if (min > Data[i])
            {
                min = Data[i];
            }
        }

        return min;
    }

    public float Avg()
    {
        float sum = 0.0f;

        for (int i = 0; i < Data.Length; i++)
        {
            sum += Data[i];
        }

        sum = sum / Data.Length;

        return sum;
    }

    public bool Search(int valueToSearch)
    {
        for (int i = 0; i < Data.Length; i++)
        {
            if (valueToSearch == Data[i])
            {
                return true;
            }
        }

        return false;
    }

    public void SortAsc()
    {
        var sortedArray = Data.OrderBy(n => n).ToArray();
        foreach (int i in sortedArray)
        {
            Console.WriteLine(i);
        }
    }

    public void SortDesc()
    {
        var sortedArray = Data.OrderByDescending(n => n).ToArray();
        foreach (int i in sortedArray)
        {
            Console.Write(i);
        }
    }

    public void SortByParam(bool isAsc)
    {
        if (isAsc)
        {
            SortAsc();
        }
        else
        {
            SortDesc();
        }
    }
}