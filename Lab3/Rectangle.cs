public class Rectangle : Figure, IPrint
{
    public double Width { get; protected set; }
    public double Height { get; protected set; }

    public Rectangle(double width, double height)
    {
        if (width <= 0 || height <= 0)
        {
            throw new ArgumentException("Ширина и высота должны быть положительными числами.");
        }
        Width = width;
        Height = height;
    }

    public override double Area()
    {
        return Width * Height;
    }

    public override string ToString()
    {
        return $"Прямоугольник (ширина: {Width}, высота: {Height}), площадь: {Area():F2}";
    }

    public void Print()
    {
        Console.WriteLine(this.ToString());
    }
}
