public class Rectangle : GeometricFigure, IPrint
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
    {
        if (width <= 0 || height <= 0)
            throw new ArgumentException("Ширинв и высота должны быть положительными числами!");
        Width = width;
        Height = height;
    }

    public override double Area => Width * Height;

    public override string ToString() => $"Прямоугольник: ширина={Width}, высота={Height}, площадь={Area:F2}";

    public new void Print()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(ToString());
        Console.ResetColor();
    }
}
