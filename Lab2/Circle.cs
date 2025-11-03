public class Circle : GeometricFigure, IPrint
{
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Радиус должен быть положительным числом!");
        Radius = radius;
    }

    public override double Area => Math.PI * Radius * Radius;

    public override string ToString() => $"Круг: радиус={Radius}, площадь={Area:F2}";
    public new void Print()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(ToString());
        Console.ResetColor();
    }
}
