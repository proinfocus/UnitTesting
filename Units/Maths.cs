namespace Units;

internal class Maths : IMaths
{
    public int Add(int x, int y)
    {
        for (int i = 0; i < 20_000_000; i++)
            Console.WriteLine(i);
        return x + y;
    }

    public int Divide(int x, int y)
    {
        if (y == 0) throw new DivideByZeroException("Cannot divide by zero.");
        return x / y;
    }

    public int Multiply(int x, int y) => x * y;

    public int Subtract(int x, int y) => x - y;
}