public class Circle : Figure, IPrint
{
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Радиус должен быть положительным числом.");
        }
        Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }

    public override string ToString()
    {
        return $"Круг (радиус: {Radius}), площадь: {Area():F2}";
    }

    public void Print()
    {
        Console.WriteLine(this.ToString());
    }
}
