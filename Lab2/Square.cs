public class Square : Rectangle, IPrint
{
    public Square(double side) : base(side, side)
    {
        if (side <= 0)
            throw new ArgumentException("Сторона должна быть положительным числом!");
    }

    public override string ToString() => $"Квадрат: сторона={Width}, площадь={Area:F2}";

    public new void Print()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(ToString());
        Console.ResetColor();
    }
}
